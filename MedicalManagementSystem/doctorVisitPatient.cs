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
    public partial class doctorVisitPatient : Form
    {
        /// <summary>
        /// import DLL
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
        public doctorVisitPatient()
        {
            InitializeComponent();
        }
        public doctorVisitPatient(IntPtr ptrIn) //接收到患者的id
        {
            InitializeComponent();

            IntPtr ptrRet;

            ptrRet = getPatientCaseNumber(ptrIn);
            caseNumberLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientName(ptrIn);
            nameContentLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientAge(ptrIn);
            ageLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientSex(ptrIn);
            sexLabel.Text = Marshal.PtrToStringAnsi(ptrRet);
        }

        navigatorDoctor goBack;
        public doctorVisitPatient(IntPtr ptrIn,navigatorDoctor f) //接收到患者的id
        {
            InitializeComponent();

            resultTxtbox.Enabled = false;   //初始化txtbox不可用以防误触

            IntPtr ptrRet;

            ptrRet = getPatientCaseNumber(ptrIn);
            caseNumberLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientName(ptrIn);
            nameContentLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientAge(ptrIn);
            ageLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientSex(ptrIn);
            sexLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            goBack = f;

        }

        public doctorVisitPatient(IntPtr ptrIn, navigatorDoctor f,string date,string timeP) //接收到患者的id
        {
            InitializeComponent();

            resultTxtbox.Enabled = false;   //初始化txtbox不可用以防误触

            dateLabel.Text = date;
            timePLabel.Text = timeP;

            IntPtr ptrRet;

            ptrRet = getPatientCaseNumber(ptrIn);
            caseNumberLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientName(ptrIn);
            nameContentLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientAge(ptrIn);
            ageLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientSex(ptrIn);
            sexLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            goBack = f;

        }

        /// <summary>
        /// load info and load form
        /// </summary>
        /// <param name="ptrIn"></param>
        /// <param name="f"></param>
        /// <param name="docorName"></param>
        /// <param name="department"></param>
        /// <param name="date"></param>
        /// <param name="timeP"></param>
        public doctorVisitPatient(IntPtr ptrIn, navigatorDoctor f, string docorName,string department,string date, string timeP) //接收到患者的id
        {
            InitializeComponent();

            resultTxtbox.Enabled = false;   //初始化txtbox不可用以防误触
            finishButton.Enabled = false;

            dateLabel.Text = date;
            timePLabel.Text = timeP;
            doctorNameLabel.Text = docorName;
            departmentLabel.Text = department;

            IntPtr ptrRet;

            ptrRet = getPatientCaseNumber(ptrIn);
            caseNumberLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientName(ptrIn);
            nameContentLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientAge(ptrIn);
            ageLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getPatientSex(ptrIn);
            sexLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

            goBack = f;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) //屏蔽掉回车键
        {
            if ((int)e.KeyCode == 13)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goBack.resetDataGredView();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            resultTxtbox.Enabled = true;
            finishButton.Enabled = true;
        }

        private void doctorVisitPatient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTxtbox.Enabled = false;
            finishButton.Enabled = false;
        }

        public void hideForm()
        {
            goBack.resetDataGredView();
            this.Hide();
        }

        /// <summary>
        /// write the result to MySQL database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishButton_Click(object sender, EventArgs e)
        {
            bool judgeWhetherFinish = false;

            //连接数据库并写入
            String selectPatient = "patient" + caseNumberLabel.Text;
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                String op = "insert into" + " " + selectPatient + " " + "value(" + "'" + departmentLabel.Text + "'" + "," + "'" + doctorNameLabel.Text + "'" + "," + "'" + dateLabel.Text + "'" + "," + "'" + timePLabel.Text + "'" + "," + "'" + resultTxtbox.Text + "'" + ")";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(op, conn);
                    cmd.ExecuteNonQuery();

                    judgeWhetherFinish = true;
                    MessageBox.Show("Consultation finished！The result has been written to patient's medical record database");
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

            if(judgeWhetherFinish)  //问诊完成，删除医生预约和患者预约
            {
                //删除患者预约
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from" + " " + selectPatient + " " + "where doctorname=" + "'" + doctorNameLabel.Text + "'" + " and date=" + "'" + dateLabel.Text + "'" + " and time=" + "'" + timePLabel.Text + "'" ;
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

                //删除医生预约信息
                string selectDoctor = doctorNameLabel.Text;
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from" + " " + selectDoctor + " " + "where patient_name=" + "'" + nameContentLabel.Text + "'" + " and date=" + "'" + dateLabel.Text + "'" + " and time=" + "'" + timePLabel.Text + "'";
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

                hideForm();
            }



        }

        bool formMove = false;
        Point formPoint;
        private void doctorVisitPatient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void doctorVisitPatient_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void doctorVisitPatient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
