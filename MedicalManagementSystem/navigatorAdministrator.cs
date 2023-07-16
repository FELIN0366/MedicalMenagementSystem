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
    public partial class navigatorAdministrator : Form
    {
        frmLoginAdministrator fla;
        public navigatorAdministrator()
        {
            InitializeComponent();
        }
        public navigatorAdministrator(frmLoginAdministrator f)
        {
            InitializeComponent();

            fla = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new patientAccountModification().Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fla.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dam_Click(object sender, EventArgs e)
        {
            new doctorAccountModification().Show();
        }

        private void am_Click(object sender, EventArgs e)
        {
            new appointmentModification().Show();
        }

        private void mrm_Click(object sender, EventArgs e)
        {
            new medicalRecordsModyfication().Show();
        }

        bool formMove = false;
        Point formPoint;
        private void navigatorAdministrator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void navigatorAdministrator_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void navigatorAdministrator_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
