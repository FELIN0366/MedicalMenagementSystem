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

namespace MedicalMenagementSystem
{
    public partial class frmLoginDoctor : Form
    {
        /// <summary>
        /// import dll
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("cppDLL.dll")]
        static extern IntPtr returnPasswordDoctor(IntPtr s);
        public frmLoginDoctor()
        {
            InitializeComponent();
        }

        frmStart fs;
        public frmLoginDoctor(frmStart f)
        {
            InitializeComponent();

            fs = f;
        }

        /// <summary>
        /// login judgement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInButton_Click(object sender, EventArgs e)
        {
            //获取密码
            IntPtr ptrIn = Marshal.StringToHGlobalAnsi(AccountBox.Text);
            try
            {
                IntPtr ptrRet = returnPasswordDoctor(ptrIn);
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
                    new navigatorDoctor(ptrIn).Show();
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

        /// <summary>
        /// make form movable
        /// </summary>
        bool formMove = false;
        Point formPoint;
        private void frmLoginDoctor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void frmLoginDoctor_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void frmLoginDoctor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
