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
    public partial class doctorAccountModification : Form
    {
        [DllImport("cppDLL.dll")]
        static extern IntPtr getDoctorEmployeeNumber(IntPtr s);

        [DllImport("cppDLL.dll")] 
        static extern IntPtr getDoctorDepartment(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getDoctorName(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr IDToDoctorName(IntPtr s);

        //用来判断是否有改动
        string originalName;
        string originalDepartment;
        string originalEmployeeNumber;


        ////////////////////////////////////////////////////////
        List<string> departmentList;
        List<string> doctorList;
        private void addDepartment()
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=alldepartment";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "select * from departmentlist";
                MySqlCommand myCommand = new MySqlCommand(op, conn);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                while(myReader.Read())
                {
                    departmentComboBox.Items.Add(myReader.GetString(0));
                    //Console.WriteLine(myReader.GetString(0));
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// ////////////////////////////////////////////////

        public doctorAccountModification()
        {
            InitializeComponent();

            passwordTextBox.Enabled = false;
            saveButton.Enabled = false;

            nameContentLabel.Text = "";
            enTextbox.Enabled = false;
            departmentComboBox.Enabled = false;

            addDepartment();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = true;
            saveButton.Enabled = true;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String op = "select * from idpwdoctor";
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

        private void saveButton_Click(object sender, EventArgs e)
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
                    String op = "update idpwdoctor set password =" + passwordTextBox.Text + " where id=" + "'" + id + "'";
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
                        MySqlDataAdapter sqlDa = new MySqlDataAdapter("select * from idpwdoctor", conn);
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

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passwordTextBox.Text = dgv1.CurrentRow.Cells[1].Value.ToString();

            nameContentLabel.Text = "";
            enTextbox.Text = "";
            departmentComboBox.Text = "";
        }

        private void infoEditButton_Click(object sender, EventArgs e)
        {
            enTextbox.Enabled = true;
            departmentComboBox.Enabled = true;
        }


        private bool departmentInSQL()  //待优化。。
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=alldepartment;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                String op = "select * from departmentlist where department='"+ departmentComboBox.Text +"'";

                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(op, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void infoSaveButton_Click(object sender, EventArgs e)
        { 
            if ( isLoad && departmentInSQL())  //如果输入了正确的科室名
            {
                if(enTextbox.Text != originalEmployeeNumber)    //如果工号有变动
                {
                    //修改信息中的 Employee Number 的数值
                    string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
                    MySqlConnection conn = new MySqlConnection(connectionStr);
                    try
                    {
                        conn.Open();

                        String op = "update informationofdoctor set employeenumber ='" + enTextbox.Text + "' where name='"+nameContentLabel.Text + "'";
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
                }

                if (departmentComboBox.Text != originalDepartment)
                {
                    //科室有变动

                    //将医生添加到新的科室,删除原科室中的该医生
                    string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=departmentanddoctor;";
                    MySqlConnection conn = new MySqlConnection(connectionStr);
                    try
                    {
                        conn.Open();

                        String op = "insert into " + departmentComboBox.Text + " value('"+nameContentLabel.Text+"')";
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand(op, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        op = "delete from " + originalDepartment + " where doctorname='" + originalName + "'";
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

                    //更新information-informationofdoctor表中的数据
                    connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
                    conn = new MySqlConnection(connectionStr);
                    try
                    {
                        conn.Open();

                        String op = "update informationofdoctor set department ='" + departmentComboBox.Text + "' where name='" + nameContentLabel.Text + "'";
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
                }

                enTextbox.Enabled = false;
                departmentComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Department Not Found. Please type the correct one！");
            }


        }

        bool isLoad = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                IntPtr ptrIn = Marshal.StringToHGlobalAnsi(dgv1.CurrentRow.Cells[0].Value.ToString());
                IntPtr ptrRet;

                ptrRet = getDoctorName(ptrIn);
                nameContentLabel.Text = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getDoctorEmployeeNumber(ptrIn);
                enTextbox.Text = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getDoctorDepartment(ptrIn);
                departmentComboBox.Text = Marshal.PtrToStringAnsi(ptrRet);

                originalName = nameContentLabel.Text;
                originalDepartment = departmentComboBox.Text;
                originalEmployeeNumber = enTextbox.Text;

                isLoad = true;
            }
            else
            {
                MessageBox.Show("Please Click [Load Doctors' Accounts] Button And Then Choose A Doctor.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new createAccountDoctor(this).Show();
            this.Hide();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteInfoFromDoctorAndPatientAppointment(MySqlDataReader myReader,string currentDoctor)
        {
            //保存好患者信息
            string patientNameString = myReader.GetString(0);
            string patientCaseNumber = myReader.GetString(1);
            string dateString = myReader.GetString(2);
            string timeString = myReader.GetString(3);

            //在医生数据库中删除此信息
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "delete from " + currentDoctor + " where patient_name='" + patientNameString + "' and date='" + dateString + "' and time='" + timeString + "'";
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

            //在患者预约库中删除此数据
            connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfopatient;";
            conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                string op = "delete from patient" + patientCaseNumber + " where doctorName='" + currentDoctor + "' and date='" + dateString + "' and time='" + timeString + "'";
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
        }

        string currentDoctor;
        string currentDoctorDepartment;
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                //删除账号库中该用户的账号和密码
                string selectID = dgv1.CurrentRow.Cells[0].Value.ToString();
                //通过id求出医生名字用于后边操作
                IntPtr ptrIn = Marshal.StringToHGlobalAnsi(selectID);
                IntPtr ptrRet = IDToDoctorName(ptrIn);  //这一步要在information的删除前做。不然information删除了这里就找不到了
                currentDoctor = Marshal.PtrToStringAnsi(ptrRet);

                ptrRet = getDoctorDepartment(ptrIn);
                currentDoctorDepartment = Marshal.PtrToStringAnsi(ptrRet);

                String connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account;";
                MySqlConnection conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from idpwdoctor where id='" + selectID + "'";

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

                //删除information中该医生信息
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=information;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from informationofdoctor where id='" + selectID+"'";
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

                //删除预约库中该医生的信息和对应患者的信息
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    string op = "select * from " + currentDoctor;
                    MySqlCommand myCommand = new MySqlCommand(op, conn);
                    MySqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        //用循环删除预约库中该医生的信息和对应患者预约库的信息
                        deleteInfoFromDoctorAndPatientAppointment(myReader, currentDoctor);
                    }
                    myReader.Close();
                    myReader.Dispose();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //删除出诊日中该医生表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointment;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "drop table " + currentDoctor;
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

                //删除预约库中该医生表
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "drop table " + currentDoctor;
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

                //删除科室表中该医生
                connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=departmentanddoctor;";
                conn = new MySqlConnection(connectionStr);
                try
                {
                    conn.Open();
                    String op = "delete from "+ currentDoctorDepartment +" where doctorname ='"+ currentDoctor  +"'"; 
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
                MessageBox.Show("Please load the account and then select one.");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool formMove = false;
        Point formPoint;
        private void doctorAccountModification_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void doctorAccountModification_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void doctorAccountModification_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
