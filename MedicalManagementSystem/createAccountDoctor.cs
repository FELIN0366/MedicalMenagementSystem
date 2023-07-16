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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicalMenagementSystem
{
    public partial class createAccountDoctor : Form
    {

        private void addDepartment()
        {
            departmentComboBox.Items.Clear();
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=alldepartment";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "select * from departmentlist";
                MySqlCommand myCommand = new MySqlCommand(op, conn);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    departmentComboBox.Items.Add(myReader.GetString(0));
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public createAccountDoctor()
        {
            InitializeComponent();

            createButton.Enabled = false;
            departmentCreationTextBox.Enabled = false;
            departmentCreationButton.Enabled = false;

            addDepartment();
        }

        doctorAccountModification dam;
        public createAccountDoctor(doctorAccountModification f)
        {
            InitializeComponent();

            createButton.Enabled = false;
            departmentCreationTextBox.Enabled = false;
            departmentCreationButton.Enabled = false;

            addDepartment();

            dam = f;
        }

        int doctorAccountNum;
        string newAccountEmployeeNumber;
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //在account数据库中创建医生用户的账号密码
                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "insert into idpwdoctor value('" + pyTextBox.Text + "','" + passwordTextBox.Text + "')";
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

                //修改表中账号数并返回,建立正确的职工号
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=accountcreationrecord";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "update acrdoctor set num=num+1";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    op = "select * from acrdoctor";
                    MySqlCommand myCommand = new MySqlCommand(op, conn);
                    MySqlDataReader myReader = myCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        doctorAccountNum = myReader.GetInt16(0);
                        if (doctorAccountNum < 10)
                        {
                            newAccountEmployeeNumber = "doc"+"00" + doctorAccountNum.ToString();
                        }
                        else if (doctorAccountNum > 10 && doctorAccountNum < 100)
                        {
                            newAccountEmployeeNumber = "doc" + "0" + doctorAccountNum.ToString();
                        }
                        else    //大于100
                        {
                            newAccountEmployeeNumber = "doc" + doctorAccountNum.ToString();
                        }
                    }
                    myReader.Close();
                    myReader.Dispose();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //创建information信息
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "insert into informationofdoctor value('" + pyTextBox.Text + "','" + nameTextBox.Text + "','" + newAccountEmployeeNumber + "','" + departmentComboBox.Text + "')";
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

                //为医生在预约库中添加表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "create table " + nameTextBox.Text + " like format";
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

                //在出诊库（appointment）中添加医生信息
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointment;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "create table " + nameTextBox.Text + " like format";
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


                //将医生添加到科室名录下
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=departmentanddoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "insert into "+departmentComboBox.Text+" value('"+ nameTextBox.Text +"')";
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

                //重置信息，方便下一次操作
                pyTextBox.Text = "";
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                nameTextBox.Text = "";
                departmentComboBox.Text = "";
                doctorAccountNum = 0;
                newAccountEmployeeNumber = null;

                createButton.Enabled = false;
                checkBox1.Checked = false;

                MessageBox.Show("New Account Successfully Created!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bool finished = true;

                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("密码不一致，请重新输入");
                    finished = false;
                    checkBox1.Checked = false;
                }

                if (pyTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == "" || nameTextBox.Text == "" || departmentComboBox.Text=="")
                {
                    MessageBox.Show("信息未填写完成");
                    finished = false;
                    checkBox1.Checked=false;
                }

                if (finished)
                {
                    createButton.Enabled = true;
                }
            }
            else
            {
                createButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dam.Show();
            this.Hide();
        }

        private void departmentCreationButton_Click(object sender, EventArgs e)
        {
            //在alldepartment中插入此科室
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=alldepartment;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "insert into departmentlist value('"+ departmentCreationTextBox.Text +"')";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(op, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("科室创建成功");
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

            //在departmentanddoctor中为此科室创建表格
            connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=departmentanddoctor;";
            conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "create table "+ departmentCreationTextBox.Text +" like format";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(op, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("科室添加成功");
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

            departmentCreationTextBox.Text = "";
            departmentCreationButton.Enabled = false;
            departmentCreationTextBox.Enabled = false;
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            departmentCreationTextBox.Enabled = true;
            departmentCreationButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDepartment();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        bool formMove = false;
        Point formPoint;
        private void createAccountDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void createAccountDoctor_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void createAccountDoctor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
