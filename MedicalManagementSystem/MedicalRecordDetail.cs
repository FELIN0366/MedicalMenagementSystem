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
    public partial class MedicalRecordDetail : Form
    {
        public MedicalRecordDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// get the info from last form
        /// </summary>
        /// <param name="date"></param>
        /// <param name="timePeriod"></param>
        /// <param name="department"></param>
        /// <param name="doctorName"></param>
        /// <param name="result"></param>
        public MedicalRecordDetail(string date, string timePeriod, string department, string doctorName, string result)
        {
            InitializeComponent();
            resultTextbox.Enabled = false;
            dateLabel.Text = date;
            timeLabel.Text = timePeriod;
            depLabel.Text = department;
            docLabel.Text = doctorName;
            resultTextbox.Text = result;
        }

        /// <summary>
        /// make form movable
        /// </summary>
        bool formMove = false;
        Point formPoint;
        private void MedicalRecordDetail_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int x = -e.X;
                int y = -e.Y;
                formPoint = new Point(x, y);
                formMove = true;
            }
        }

        private void MedicalRecordDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if(formMove)
            {
                Point mosPoint = Control.MousePosition;
                mosPoint.Offset(formPoint.X, formPoint.Y);
                Location = mosPoint;
            }
        }

        private void MedicalRecordDetail_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
