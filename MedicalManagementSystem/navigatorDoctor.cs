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


namespace MedicalMenagementSystem
{
    public partial class navigatorDoctor : Form
    {
        /// <summary>
        /// import dll
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("cppDLL.dll")]
        static extern IntPtr getDoctorEmployeeNumber(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getDoctorDepartment(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr getDoctorName(IntPtr s);

        [DllImport("cppDLL.dll")]
        static extern IntPtr caseNumberToID(IntPtr s);

        public navigatorDoctor()
        {
            InitializeComponent();
        }

        string doctorId;
        /// <summary>
        /// load the form and get basic info from dll function
        /// </summary>
        /// <param name="ptrIn"></param>
        public navigatorDoctor(IntPtr ptrIn)
        {
            InitializeComponent();

            doctorId = Marshal.PtrToStringAnsi(ptrIn);

            IntPtr ptrRet;

            ptrRet = getDoctorEmployeeNumber(ptrIn);
            enContent.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getDoctorDepartment(ptrIn);
            dpContent.Text = Marshal.PtrToStringAnsi(ptrRet);

            ptrRet = getDoctorName(ptrIn);
            nContent.Text = Marshal.PtrToStringAnsi(ptrRet);

            timePCBBOX.Items.Add("9:00-10:30");
            timePCBBOX.Items.Add("10:30-12:00");
            timePCBBOX.Items.Add("14:30-16:00");
            timePCBBOX.Items.Add("16:00-17:30");
            timePCBBOX.SelectedIndex = 0;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// connect to database and present appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointmentinfodoctor;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                String op = "select * from" + " " + nContent.Text ;
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

        public void resetDataGredView()
        {
            dgv1.DataSource = null;
        }

        /// <summary>
        /// jump to consultation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null && (dgv1.SelectedRows.Count == 1 || dgv1.SelectedCells.Count == 1))
            {
                try
                {
                    IntPtr patient_id = caseNumberToID(Marshal.StringToHGlobalAnsi(dgv1.CurrentRow.Cells[1].Value.ToString()));
                    string date = dgv1.CurrentRow.Cells[2].Value.ToString();
                    string timeP = dgv1.CurrentRow.Cells[3].Value.ToString();
                    string doctorName = nContent.Text;
                    string department = dpContent.Text;
                    doctorVisitPatient form = new doctorVisitPatient(patient_id, this, doctorName, department, date, timeP);
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please load appointments and then choose one.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if not integer or back, make it invalid input
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// set the schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string selectDoctor = nContent.Text;
            string connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=appointment;";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            try
            {
                conn.Open();
                String op = "insert into" + " " + selectDoctor + " " + "value(" + "'" + dateTimePicker1.Text + "'" + "," + "'" + timePCBBOX.Text + "'" + "," + "'" + numberTxtbox.Text + "'" + ")";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(op, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Schedule successfully set.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter an integer to 'Access Number'");
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// make form movable
        /// </summary>
        bool formMove = false;
        Point formPoint;
        private void navigatorDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void navigatorDoctor_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void navigatorDoctor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new frmLoginDoctor().Show();
            this.Hide();
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            new chatroom(doctorId,"doctor").Show();
        }
    }
}
