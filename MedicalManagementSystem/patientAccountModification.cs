using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlX.XDevAPI.Relational;
using System.Runtime.InteropServices;

namespace MedicalMenagementSystem
{
    public partial class patientAccountModification : Form
    {
        /// <summary>
        /// import dll
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("cppDLL.dll")]
        static extern IntPtr getPatientName(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getPatientCaseNumber(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getPatientBirthDate(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getPatientAge(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getPatientSex(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr IDToCaseNumber(IntPtr s);
        public patientAccountModification()
        {
            InitializeComponent();

            passwordTextBox.Enabled = false;
            saveButton .Enabled = false;

            nameTextBox.Enabled = false;
            cnTextbox.Enabled = false;
            bdTextBox.Enabled = false;
            ageTextBox.Enabled = false;
            sexTextBox.Enabled = false;
        }


        /// <summary>
        /// load patient's account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String op = "select * from idpwpatient";
                try
                {
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(op, conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgv1.DataSource = dtbl;
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
        }

        /// <summary>
        /// save the new password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                passwordTextBox.Enabled = false;
                saveButton.Enabled = false;

                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string id = dgv1.CurrentRow.Cells[0].Value.ToString();
                    String op = "update idpwpatient set password =" + passwordTextBox.Text + " where id=" + id;
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("保存成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //更新dgv1
                    try
                    {
                        MySqlDataAdapter sqlDa = new MySqlDataAdapter("select * from idpwpatient", conn);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        dgv1.DataSource = dtbl;
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
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = true;
            saveButton.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passwordTextBox.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            nameTextBox.Text = "";
            cnTextbox.Text = "";
            bdTextBox.Text = "";
            ageTextBox.Text = "";
            sexTextBox.Text = "";
        }

        /// <summary>
        /// close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void infoEditButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
            cnTextbox.Enabled = true;
            bdTextBox.Enabled = true;
            ageTextBox.Enabled = true;
            sexTextBox.Enabled = true;
        }

        /// <summary>
        /// save basic info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoSaveButton_Click(object sender, EventArgs e)
        {
            if (isLoad)
            { 
                nameTextBox.Enabled = false;
                cnTextbox.Enabled = false;
                bdTextBox.Enabled = false;
                ageTextBox.Enabled = false;
                sexTextBox.Enabled = false;

                String connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();    //"'"
                    String op = "update informationofpatient " + " set " + "name = " + "'" + nameTextBox.Text + "'" + "," + "birthDate = " + "'" + bdTextBox.Text + "'" + "," + "age = " + "'" + ageTextBox.Text + "'" + "," + "sex = " + "'" + sexTextBox.Text + "'" + "where caseNumber = " + "'" + cnTextbox.Text + "'";

                    try
                    {
                        //MySqlCommand cmd = new MySqlCommand("set names gbk "+ op, conn);
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
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
            }

        }

        /// <summary>
        /// load basic info
        /// </summary>
        bool isLoad = false;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                IntPtr ptrIn = Marshal.StringToHGlobalAnsi(dgv1.CurrentRow.Cells[0].Value.ToString());
                IntPtr ptrRet;

                ptrRet = getPatientName(ptrIn);
                nameTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getPatientCaseNumber(ptrIn);
                cnTextbox.Text = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getPatientBirthDate(ptrIn);
                bdTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getPatientAge(ptrIn);
                ageTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getPatientSex(ptrIn);
                sexTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

                isLoad = true;
            }
            else
            {
                MessageBox.Show("Please Click [Load Patients' Accounts] Button And Then Choose A Patient.");
            }
        }

        /// <summary>
        /// jump to account creation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            new createAccountPatient(this).Show();
            this.Hide();
        }

        /// <summary>
        /// delete relavant information in different database.
        /// </summary>
        /// <param name="myReader"></param>
        /// <param name="currentPatient"></param>
        /// <param name="currentPatientCaseNumber"></param>
        private void deleteInfoFromPandDappointment(MySqlDataReader myReader,string currentPatient,string currentPatientCaseNumber)
        {
            //保存好医生信息
            string doctornameString = myReader.GetString(0);
            string dateString = myReader.GetString(1);
            string timeString = myReader.GetString(2);

            //在患者数据库中删除此信息
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "delete from " + currentPatient + " where doctorName='" + doctornameString + "' and date='" + dateString + "' and time='" + timeString + "'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(op, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("患者预约删除成功！");
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
                    MessageBox.Show("医生预约删除成功！");
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
        }

        /// <summary>
        /// delete the patient's account
        /// </summary>
        string currentPatient;
        string currentPatientCaseNumber;

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                //删除账号库中该用户的账号和密码
                string selectID = dgv1.CurrentRow.Cells[0].Value.ToString();
                //通过id求出caseNumber
                IntPtr ptrIn = Marshal.StringToHGlobalAnsi(selectID);
                IntPtr ptrRet = IDToCaseNumber(ptrIn);  //这一步要在information的删除前做。不然information删除了这里就找不到了
                string currentPatientCaseNumber = Marshal.PtrToStringAnsi(ptrRet);
                currentPatient = "patient" + currentPatientCaseNumber;

                String connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from idpwpatient where id=" + selectID;

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

                //删除information中该用户信息
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from informationofpatient where id=" + selectID;
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        
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


                //删除预约库中该患者的信息和对应医生的信息
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();

                    string op = "select * from " + currentPatient;
                    MySqlCommand myCommand = new MySqlCommand(op, conn);
                    MySqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        //用循环删除预约库中该患者的信息和对应医生的信息
                        deleteInfoFromPandDappointment(myReader, currentPatient, currentPatientCaseNumber);
                    }
                    myReader.Close();
                    myReader.Dispose();
                    conn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //删除appointmentinfopatient中这个患者的表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "drop table " + currentPatient;
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        
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

                //删除medicalrecords中这个患者的表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "drop table " + currentPatient;
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        
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

                MessageBox.Show("User Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Please load the accounts first and then choose one.");
            }
        }

        bool formMove = false;
        Point formPoint;
        private void patientAccountModification_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void patientAccountModification_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void patientAccountModification_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void patientAccountModification_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
