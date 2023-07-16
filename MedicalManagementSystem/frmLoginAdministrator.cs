using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalMenagementSystem
{
    public partial class frmLoginAdministrator : Form
    {

        [DllImport("cppDLL.dll")]
        static extern IntPtr returnPasswordAdministrator(IntPtr s);
        public frmLoginAdministrator()
        {
            InitializeComponent();
        }

        frmStart fs;
        public frmLoginAdministrator(frmStart f)
        {
            InitializeComponent();

            fs = f;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            //获取密码
            IntPtr ptrIn = Marshal.StringToHGlobalAnsi(AccountBox.Text);
            try
            {
                IntPtr ptrRet = returnPasswordAdministrator(ptrIn);
                string retlust = Marshal.PtrToStringAnsi(ptrRet);

                //判断是否存在此账号
                if (retlust == "-1")
                {
                    MessageBox.Show("Sorry,the account does not exist");
                    return;
                }

                if (retlust != PasswordBox.Text)
                {
                    MessageBox.Show("Passwords wrong, Please Re_enter", "Log in Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordBox.Text = "";
                    PasswordBox.Focus();
                }
                else
                {
                    //登录成功
                    MessageBox.Show("Welcome to medical system!", "Log in sucssfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new navigatorAdministrator(this).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fs != null)
            {
                fs.Show();
                this.Hide();
            }
            else
            {
                new frmStart().Show();
                this.Hide();
            }
        }

        bool formMove = false;
        Point formPoint;
        private void frmLoginAdministrator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void frmLoginAdministrator_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void frmLoginAdministrator_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
