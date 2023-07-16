using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MedicalMenagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        //[STAThread]

        //[DllImport("cpp调用try1.dll")]

        //static extern int display();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new doctorVisitPatient());
            //Application.Run(new frmLoginDoctor());
            //Application.Run(new registrationPatient());
            //Application.Run(new frmLoginPatient());
            //Application.Run(new navigatorDoctor());
            //Application.Run(new patientAccountModification());
            //Application.Run(new navigatorAdministrator());
            //Application.Run(new doctorAccountModification());
            //Application.Run(new medicalRecordsModyfication());
            //Application.Run(new appointmentModification());
            //Application.Run(new createAccountPatient());
            //Application.Run(new createAccountDoctor());
            Application.Run(new frmStart());
            //Application.Run(new frmLoginAdministrator());
            //Application.Run(new navigatorPatient());
        }
    }
}
