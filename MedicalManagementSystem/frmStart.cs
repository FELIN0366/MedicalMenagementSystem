using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalMenagementSystem
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// jump to patient login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new frmLoginPatient(this).Show();
            this.Hide();
        }

        /// <summary>
        /// jump to doctor login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new frmLoginDoctor(this).Show();
            this.Hide();
        }

        /// <summary>
        /// jump to administrator login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            new frmLoginAdministrator().Show();
            this.Hide();
        }

        /// <summary>
        /// stop the programe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        /// <summary>
        /// code that make form movable
        /// </summary>
        bool formMove = false;
        Point formPoint;
        private void frmStart_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void frmStart_MouseMove(object sender, MouseEventArgs e)
        {
            if(formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void frmStart_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
