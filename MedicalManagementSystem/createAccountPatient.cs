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
using static System.Net.WebRequestMethods;

namespace MedicalMenagementSystem
{
    public partial class createAccountPatient : Form
    {
        frmLoginPatient flp;
        patientAccountModification pam;
        public createAccountPatient()
        {
            InitializeComponent();

            createButton.Enabled = false;
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
        }

        public createAccountPatient(frmLoginPatient f)
        {
            InitializeComponent();

            createButton.Enabled = false;
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
            flp = f;
        }
        public createAccountPatient(patientAccountModification f)
        {
            InitializeComponent();

            createButton.Enabled = false;
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
            pam = f;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                bool finished = true;

                if(passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("密码不一致，请重新输入");
                    finished = false;
                    checkBox1.Checked = false;
                }

                if( pnTextBox.Text==""||passwordTextBox.Text==""||confirmPasswordTextBox.Text==""||nameTextBox.Text == "" || ageTextBox.Text=="" || SexComboBox.Text =="")
                {
                    MessageBox.Show("信息未填写完成");
                    finished=false;
                    checkBox1.Checked = false;
                }

                //

                if(finished)
                {
                    createButton.Enabled = true;
                }
            }
            else
            {
                createButton.Enabled=false;
            }
        }

        int patientAccountNum;
        string newAccountCaseNumber;
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //在account数据库中创建用户的账号密码
                string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "insert into idpwpatient value('" + pnTextBox.Text + "','" + passwordTextBox.Text + "')";
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

                //修改表中账号数并返回,建立正确的病历号
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=accountcreationrecord";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "update acrpatient set num=num+1";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(op, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    op = "select * from acrpatient";
                    MySqlCommand myCommand = new MySqlCommand(op, conn);
                    MySqlDataReader myReader = myCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        patientAccountNum = myReader.GetInt16(0);
                        if (patientAccountNum < 10)
                        {
                            newAccountCaseNumber = "00" + patientAccountNum.ToString();
                        }
                        else if (patientAccountNum > 10 && patientAccountNum < 100)
                        {
                            newAccountCaseNumber = "0" + patientAccountNum.ToString();
                        }
                        else    //大于100
                        {
                            newAccountCaseNumber = patientAccountNum.ToString();
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
                    string op = "insert into informationofpatient value('" + pnTextBox.Text + "','" + nameTextBox.Text + "','" + birthDateTimePicker.Text + "','" + ageTextBox.Text + "','" + SexComboBox.Text + "','" + newAccountCaseNumber + "')";
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

                //为患者在预约库中添加表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "create table " + "patient" + newAccountCaseNumber + " like format";
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

                //为患者在病历库中添加表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=medicalrecords;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "create table " + "patient" + newAccountCaseNumber + " like format";
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
                pnTextBox.Text = "";
                passwordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                nameTextBox.Text = "";
                ageTextBox.Text = "";
                SexComboBox.Text = "";
                patientAccountNum = 0;
                newAccountCaseNumber = null;

                checkBox1.Checked = false;
                createButton.Enabled = false;

                MessageBox.Show("New Account Successfully Created!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SexComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flp != null)
            {
                flp.Show();
                this.Hide();
            }

            if (pam != null)
            {
                pam.Show();
                this.Hide();
            }
        }

        bool formMove = false;
        Point formPoint;
        private void createAccountPatient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void createAccountPatient_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void createAccountPatient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
