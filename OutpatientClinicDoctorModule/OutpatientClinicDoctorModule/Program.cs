using System;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_LogIn frm_LogIn = new frm_LogIn();
            frm_LogIn.ShowDialog();
            Application.Run();
        }
    }
}
