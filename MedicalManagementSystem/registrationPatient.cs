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
using System.Xml;
using MySql.Data.MySqlClient;

namespace MedicalMenagementSystem
{
    public partial class registrationPatient : Form
    {
        ////////////////////////////////////////////////////////
        ///这一部分用于从数据库中添加科室-医生层次结构
        List<string> departmentList = new List<string>();
        List<string> doctorList = new List<string>();
        Dictionary<string, string> hierarchy = new Dictionary<string, string>();
        private void addDepartment()
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=departmentanddoctor";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "show tables;";
                MySqlCommand myCommand = new MySqlCommand(op, conn);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string temp = myReader.GetString(0);
                    if(temp != "format")
                        departmentList.Add(temp);
                }
                myReader.Close();
                myReader.Dispose();
                conn.Close();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addDoctor()
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=departmentanddoctor";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string alldoctor = "";
                for (int i = 0; i < departmentList.Count; i++)
                {
                    string op = "select * from " + departmentList[i];
                    MySqlCommand myCommand = new MySqlCommand(op, conn);
                    MySqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        doctorList.Add(myReader.GetString(0));
                    }

                    if (doctorList.Count > 0)
                    {
                        alldoctor = doctorList[0];
                        for (int j = 1; j < doctorList.Count; j++)
                        {
                            alldoctor += "," + doctorList[j];
                        }
                    }
                    hierarchy.Add(departmentList[i], alldoctor);
                    doctorList.Clear();
                    myReader.Close();
                    myReader.Dispose();
                }
                
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addHierarchy()
        {
            addDepartment();
            addDoctor();
        }

        ///////////////////////////////////////////////////



        navigatorPatient formBack;
        appointmentModification appointmentModification;
        public registrationPatient()
        {
            InitializeComponent();
        }
        public registrationPatient(String t)
        {
            InitializeComponent();
            caseNumberLabel.Text = t;
        }

        public registrationPatient(String t,navigatorPatient f)
        {
            InitializeComponent();
            caseNumberLabel.Text = t;
            formBack = f;
        }
        public registrationPatient(String t, appointmentModification f)
        {
            InitializeComponent();
            caseNumberLabel.Text = t;
            appointmentModification = f;
        }


        public registrationPatient(string name,string caseNumber, navigatorPatient f)
        {
            InitializeComponent();
            nameLabel.Text = name;
            caseNumberLabel.Text = caseNumber;
            formBack = f;
        }

        private void registration_Load(object sender, EventArgs e)
        {

            addHierarchy();

            foreach (KeyValuePair<string, string> kv in hierarchy)
            {
                comboBox1.Items.Add(kv.Key);
            }

            dateLabel.Text = "";
            timePeriodLabel.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointment;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                String doctor = comboBox2.Text;
                String op = "select * from" + " " + doctor + " " + "where remainingAccess != 0";
                try
                {
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter(op, conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgv1.DataSource = dtbl;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please Choose Department-Doctor First!");
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每当改变第一个控件内容的时侯，之前的内容进行清空
            if (dgv1.DataSource != null)
                dgv1.DataSource = null;
            if(dateLabel.Text != "")
                dateLabel.Text = "";
            if (timePeriodLabel.Text != "")
                timePeriodLabel.Text = "";
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            //将value的值进行赋值
            string str = comboBox1.SelectedItem.ToString();
            Console.WriteLine("str is ", str);
            string[] str1 = hierarchy[str].Split(',');
            comboBox2.Items.AddRange(str1);
        }

        bool ifChosen = false;
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                try
                {
                    dateLabel.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                    timePeriodLabel.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
                    ifChosen = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请选择科室-选择医生-查询 后点击表格左侧以选择整行进行选择");
                }
            }
            else
            {
                MessageBox.Show("Please Load the schedule first.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null)
                dgv1.DataSource = null;
            if(dateLabel.Text != "")
                dateLabel.Text = "";
            if (timePeriodLabel.Text != "")
                timePeriodLabel.Text = "";
        }

        private void configurationButton_Click(object sender, EventArgs e)
        {
            if (ifChosen)
            {
                //将患者的预约信息写入数据库
                String selectPatient = "patient" + caseNumberLabel.Text;
                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "insert into" + " " + selectPatient + " " + "value(" + "'" + comboBox2.Text + "'" + "," + "'" + dateLabel.Text + "'" + "," + "'" + timePeriodLabel.Text + "'" + ")";
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

                //对应医生对应时间段剩余号数减1   构造连接字符串，连接上对应医生的预约表，在对应时间号数-1
                String selectDoctor = comboBox2.Text;
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointment;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "update" + " " + selectDoctor + " " + "set remainingAccess = remainingAccess - 1 where " + "date = " + "'" + dateLabel.Text + "'" + " and time = " + "'" + timePeriodLabel.Text + "'";
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

                //将患者预约信息加载到医生的预约信息表中
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "insert into" + " " + selectDoctor + " " + "value(" + "'" + nameLabel.Text + "'" + "," + "'" + caseNumberLabel.Text + "'" + "," + "'" + dateLabel.Text + "'" + "," + "'" + timePeriodLabel.Text + "'" + ")"; ;
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

                MessageBox.Show("预约成功!");



                //datagridview重新加载
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointment;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    //MessageBox.Show("Connection Open ! ");
                    String doctor = comboBox2.Text;
                    String op = "select * from" + " " + doctor + " " + "where remainingAccess != 0";
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
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if(formBack != null)
                formBack.Show();
            if(appointmentModification != null)
                appointmentModification.Show();
        }

        bool formMove = false;
        Point formPoint;
        private void registrationPatient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void registrationPatient_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void registrationPatient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
