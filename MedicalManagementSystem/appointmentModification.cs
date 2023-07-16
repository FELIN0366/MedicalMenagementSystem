using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicalMenagementSystem
{
    public partial class appointmentModification : Form
    {
        /// <summary>
        /// import DLL
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("cppDLL.dll")]
        static extern IntPtr IDToCaseNumber(IntPtr s);
        public appointmentModification()
        {
            InitializeComponent();
        }


        /// <summary>
        /// load patient's appointment info
        /// </summary>
        string currentPatient;
        string currentPatientCaseNumber;
        private void button6_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            string selectPatient = "patient" + cnTextBox.Text;
            currentPatient = selectPatient;
            currentPatientCaseNumber = cnTextBox.Text;
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String op = "select * from " + selectPatient;
                try
                {
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(op, conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgv1.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Case Number Not Found！");
                    dgv1.DataSource=null;
                    cnTextBox.Text = "";
                    currentPatient = null;
                    currentPatientCaseNumber = null;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// load patient's appointment info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            cnTextBox.Text = null;
            IntPtr ptrIn = Marshal.StringToHGlobalAnsi(idTextBox.Text);
            IntPtr ptrRet = IDToCaseNumber(ptrIn);
            string caseNumber = Marshal.PtrToStringAnsi(ptrRet);

            if (caseNumber != "-1")
            {

                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                string selectPatient = "patient" + caseNumber;
                currentPatient = selectPatient;
                currentPatientCaseNumber = caseNumber;
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Open ! ");
                    String op = "select * from " + selectPatient;
                    try
                    {
                        MySqlDataAdapter sqlDa = new MySqlDataAdapter(op, conn);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        dgv1.DataSource = dtbl;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ID not found.");
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ID not found.");
                idTextBox.Text = "";
                dgv1.DataSource = null;
                currentPatient = null;
                currentPatientCaseNumber = null;
            }
        }

        string currentDoctor;
        private void button4_Click(object sender, EventArgs e)
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            string selectDoctor = docnTextBox.Text;
            currentDoctor = selectDoctor;
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String op = "select * from " + selectDoctor;
                try
                {
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(op, conn);
                    DataTable dtb2 = new DataTable();
                    sqlDa.Fill(dtb2);
                    dgv2.DataSource = dtb2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doctor not found.");
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// delete patient's appointment that has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                //保存好医生信息
                string doctornameString = dgv1.CurrentRow.Cells[0].Value.ToString();
                string dateString = dgv1.CurrentRow.Cells[1].Value.ToString();
                string timeString = dgv1.CurrentRow.Cells[2].Value.ToString();

                //在患者数据库中删除此信息
                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "delete from "+ currentPatient +" where doctorName='"+doctornameString+"' and date='"+dateString+"' and time='"+timeString+"'";
                    //string op = "delete from 扁鹊 where patient_name=罗云扬 and date=dateString and time=timeString";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        dgv1.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //在医生预约库中删除此数据
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "delete from " + doctornameString + " where patient_casenumber='" + currentPatientCaseNumber + "' and date='" + dateString + "' and time='" + timeString + "'";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        dgv2.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Patient's Appointment Has Been Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Please Load and select data first!");
            }
        }

        /// <summary>
        /// delete doctor's appointment that has been selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv2.DataSource != null && (dgv2.SelectedRows.Count == 1 || dgv2.SelectedCells.Count == 1))
            { 
                //保存好患者信息
                string patientCaseNumberString = dgv2.CurrentRow.Cells[1].Value.ToString();
                string dateString = dgv2.CurrentRow.Cells[2].Value.ToString();
                string timeString = dgv2.CurrentRow.Cells[3].Value.ToString();
                string patientString = "patient" + patientCaseNumberString;

                //在医生数据库中删除此信息
                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "delete from " + currentDoctor + " where patient_casenumber='" + patientCaseNumberString + "' and date='" + dateString + "' and time='" + timeString + "'";
                    //string op = "delete from 扁鹊 where patient_name=罗云扬 and date=dateString and time=timeString";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        dgv2.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //在患者预约库中删除此数据
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "delete from " + patientString + " where doctorName='" + currentDoctor + "' and date='" + dateString + "' and time='" + timeString + "'";
                    //string op = "delete from 扁鹊 where patient_name=罗云扬 and date=dateString and time=timeString";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        dgv1.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Doctor's Appointment Has Been Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Please load and select data first!");
            }
        }

        /// <summary>
        /// jump to appointment creation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(currentPatientCaseNumber);
            if (currentPatientCaseNumber != null)
            {
                new registrationPatient(currentPatientCaseNumber, this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Load The Information First!");
            }
        }

        /// <summary>
        /// close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool formMove = false;
        Point formPoint;
        private void appointmentModification_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void appointmentModification_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void appointmentModification_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void addUserToListView()
        {
            try
            {
                string connectStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information";
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    string op = string.Format("select * from informationofpatient");
                    using (MySqlCommand myCommand = new MySqlCommand(op, conn))
                    {
                        
                        MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                        while (myReader.Read())
                        {
                            patientListView.Items.Add(myReader["id"].ToString());
                        }
                        myReader.Close();
                        myReader.Dispose();
                    }

                    op = string.Format("select * from informationofdoctor");
                    using (MySqlCommand myCommand = new MySqlCommand(op, conn))
                    {
                        MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                        while (myReader.Read())
                        {
                            doctorListView.Items.Add(myReader["name"].ToString());
                        }
                        myReader.Close();
                        myReader.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appointmentModification_Load(object sender, EventArgs e)
        {
            addUserToListView();
        }

        private void patientListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                idTextBox.Text = patientListView.SelectedItems[0].Text;
            }
        }

        private void doctorListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                docnTextBox.Text = doctorListView.SelectedItems[0].Text;
            }
        }
    }
}
