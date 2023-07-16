using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MedicalMenagementSystem
{
    public partial class medicalRecordsModyfication : Form
    {
        /// <summary>
        /// import DLL
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("cppDLL.dll")]
        static extern IntPtr IDToCaseNumber(IntPtr s);

        string currentPatient;
        public medicalRecordsModyfication()
        {
            InitializeComponent();

            recordTextBox.Enabled = false;
            infoSaveButton.Enabled = false;
        }

        /// <summary>
        /// load patient's medical records info serch by ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton3_Click(object sender, EventArgs e)
        {
            cnTextBox.Text = null;
            IntPtr ptrIn = Marshal.StringToHGlobalAnsi(idTextBox3.Text);
            IntPtr ptrRet = IDToCaseNumber(ptrIn);
            string caseNumber = Marshal.PtrToStringAnsi(ptrRet);

            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            string selectPatient = "patient" + caseNumber;
            currentPatient = selectPatient;
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
                    MessageBox.Show("account not found！");
                    idTextBox3.Text = null;
                    dgv1.DataSource=null;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// load patient's medical records info serch by case number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            idTextBox3.Text=null;
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            string selectPatient = "patient" + cnTextBox.Text;
            currentPatient = selectPatient;
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
                    MessageBox.Show("不存在此病历号！");
                    cnTextBox.Text = "";
                    dgv1.DataSource = null;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string originalRecordText;
        string recordDepartment;
        string recordDoctorName;
        string recordDate;
        string recordTime;

        /// <summary>
        /// load medical record content to textbox
        /// </summary>
        bool isLoad = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if(dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                recordDepartment = dgv1.CurrentRow.Cells[0].Value.ToString();
                recordDoctorName = dgv1.CurrentRow.Cells[1].Value.ToString();
                recordDate = dgv1.CurrentRow.Cells[2].Value.ToString();
                recordTime = dgv1.CurrentRow.Cells[3].Value.ToString();
                recordTextBox.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                originalRecordText = recordTextBox.Text;
                isLoad = true;
            }
            else
            {
                MessageBox.Show("Please Click the [Load] Button To Choose A Person First.");
            }
        }

        private void infoEditButton_Click(object sender, EventArgs e)
        {
            recordTextBox.Enabled = true;
            infoSaveButton.Enabled = true;
        }

        /// <summary>
        /// save the edited record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoSaveButton_Click(object sender, EventArgs e)
        {   
            if(originalRecordText != recordTextBox.Text && isLoad)
            {
                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                string selectPatient = currentPatient;
                currentPatient = selectPatient;
                try
                {
                    conn.Open();
                    String op = "update " + currentPatient +" set result='" + recordTextBox.Text +"'where department='" + recordDepartment+"' and doctorname='"+recordDoctorName+"' and date='"+recordDate+"' and time='"+recordTime+"'";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The edited record has been successfully saved!");
                        dgv1.DataSource = null;
                        recordTextBox.Enabled = false;
                        infoSaveButton.Enabled = false;
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
        /// delete the seleted record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                var rDepartment = dgv1.CurrentRow.Cells[0].Value.ToString();
                var rDoctorName = dgv1.CurrentRow.Cells[1].Value.ToString();
                var rDate = dgv1.CurrentRow.Cells[2].Value.ToString();
                var rTime = dgv1.CurrentRow.Cells[3].Value.ToString();
                var rText = dgv1.CurrentRow.Cells[4].Value.ToString();

                var connectStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords";
                using(MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    string modifyString1 = string.Format("delete from "+ currentPatient +" where date='"+ rDate +"' and time='"+ rTime +"' and result='"+ rText +"';");
                    using (MySqlCommand myCommand = new MySqlCommand(modifyString1, conn))
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                dgv1.DataSource = null;
            }
            else
            {
                MessageBox.Show("Please load the medical records and select one!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool formMove = false;
        Point formPoint;
        private void medicalRecordsModyfication_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void medicalRecordsModyfication_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void medicalRecordsModyfication_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// add users to list view and display
        /// </summary>
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
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void medicalRecordsModyfication_Load(object sender, EventArgs e)
        {
            addUserToListView();
        }

        private void patientListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                idTextBox3.Text = patientListView.SelectedItems[0].Text;
            }
        }
    }
}
