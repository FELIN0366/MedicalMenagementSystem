using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace MedicalMenagementSystem
{
    public partial class navigatorPatient : Form
    {
        /// <summary>
        /// global variables
        /// </summary>
        frmLoginPatient formBack;
        string userId;


        /// <summary>
        /// DLL import
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

        public navigatorPatient()
        {
            InitializeComponent();

        }

        public navigatorPatient(IntPtr ptrIn)
        {
            InitializeComponent();

            IntPtr ptrRet;

            ptrRet = getPatientCaseNumber(ptrIn);
            caseNumberContent.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientName(ptrIn);
            nameTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientBirthDate(ptrIn);
            birthDateTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientAge(ptrIn);
            ageTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientSex(ptrIn);
            sexTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);
        }

        /// <summary>
        /// load basic info through dll function
        /// </summary>
        /// <param name="ptrIn"></param>
        /// <param name="f"></param>
        public navigatorPatient(IntPtr ptrIn,frmLoginPatient f)
        {
            InitializeComponent();

            userId = Marshal.PtrToStringAnsi(ptrIn);
            Console.WriteLine(userId);

            IntPtr ptrRet;

            //ptrRet = getCaseNumber(ptrIn);
            ptrRet = getPatientCaseNumber(ptrIn);
            caseNumberContent.Text = Marshal.PtrToStringAnsi(ptrRet);

            //ptrRet = getName(ptrIn);
            ptrRet = getPatientName(ptrIn);
            nameTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            //ptrRet = getBirthDate(ptrIn);
            ptrRet = getPatientBirthDate(ptrIn);
            birthDateTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            //ptrRet = getAge(ptrIn);
            ptrRet = getPatientAge(ptrIn);
            ageTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            //ptrRet = getSex(ptrIn);
            ptrRet = getPatientSex(ptrIn);
            sexTextBox.Text = Marshal.PtrToStringAnsi(ptrRet);

            formBack = f;
        }

        private void patient_info_Load(object sender, EventArgs e)
        {

        }

        private void nameContent_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// activate the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
            birthDateTextBox.Enabled = true;
            ageTextBox.Enabled = true;  
            sexTextBox.Enabled = true;
            saveButton.Enabled = true;
        }

        /// <summary>
        /// save the basic infos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = false;
            birthDateTextBox.Enabled =false;
            ageTextBox.Enabled = false;
            sexTextBox.Enabled = false;
            saveButton.Enabled = false;

            //更新信息
            String connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();    //"'"
                String op = "update informationofpatient " + " set " + "name = " + "'" + nameTextBox.Text + "'" + "," + "birthDate = " + "'" + birthDateTextBox.Text + "'" + "," + "age = " + "'" + ageTextBox.Text + "'" + "," + "sex = " + "'" + sexTextBox.Text + "'"+"where caseNumber = "+"'"+caseNumberContent.Text+"'";

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

        /// <summary>
        /// go back to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you going back to login?", "tips",MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                formBack.clearClick();
                formBack.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// load appointments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String user = "patient" + caseNumberContent.Text;
                String op = "select * from" + " " + user;
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
        /// load medical records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton2_Click(object sender, EventArgs e)
        {
            dgv2.DataSource = null;
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String user = "patient" + caseNumberContent.Text;
                String op = "select * from" + " " + user;
                try
                {
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(op, conn);
                    DataTable dtb2 = new DataTable();
                    sqlDa.Fill(dtb2);
                    dgv2.DataSource = dtb2;
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool formMove = false;
        Point formPoint;
        private void navigatorPatient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void navigatorPatient_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void navigatorPatient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            new registrationPatient(nameTextBox.Text, caseNumberContent.Text, this).Show();
            this.Hide();
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// load detail button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void detailButton_Click(object sender, EventArgs e)
        {
            if(dgv2.DataSource != null && (dgv2.SelectedRows.Count == 1 || dgv2.SelectedCells.Count == 1))
            { 
                string departmentC = dgv2.CurrentRow.Cells[0].Value.ToString();
                string docC = dgv2.CurrentRow.Cells[1].Value.ToString();
                string dateC = dgv2.CurrentRow.Cells[2].Value.ToString();
                string timePC = dgv2.CurrentRow.Cells[3].Value.ToString();
                string resultC = dgv2.CurrentRow.Cells[4].Value.ToString();
                new MedicalRecordDetail(dateC,timePC,departmentC,docC,resultC).Show();
            }
            else
            {
                MessageBox.Show("Please load the data first!");
            }
        }

        /// <summary>
        /// check whether the user has registrated their face and jump to different form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void face_recognition_registration_button_Click(object sender, EventArgs e)
        {
            //新建实例
            // 设置APPID/AK/SK
            var API_KEY = "Ou8uuvsLl1fUg7GVSRvDB7oa";
            var SECRET_KEY = "wSRRBwOR3Zar2ahiGWNta9ANIrdG9D1F";
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

            //查询用户的人脸的face_token
            try
            {
                var groupId = "patient";
                var result = client.FaceGetlist(userId, groupId);

                if (result["error_code"].ToString() == "0")
                {
                    DialogResult res = MessageBox.Show("It is already registered. Do you want to update the face? ", "Tips", MessageBoxButtons.YesNo);
                    
                    if (res == DialogResult.Yes)
                    {
                        //想要更新人脸信息
                        new faceRecognitionUpdate(userId).Show();
                    }
                }
                else
                {
                    //还未注册人脸
                    new faceRecognitionRegistration(userId).Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// load the chat room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chatButton_Click(object sender, EventArgs e)
        {
            new chatroom(userId, "patient").Show();
        }
    }
}
