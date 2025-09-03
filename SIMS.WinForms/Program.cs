using System;
using System.Windows.Forms;
using DVLD.WinForms.MainForms;

namespace SIMS.WinForms
{
    public enum enMode { Add, Edit };

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
