using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Utilities;
using DVLD.WinForms.MainForms;
using DVLD.WinForms.Utils;

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
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            clsActivityLog.Initialize();
            Application.Run(new frmLogin());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            clsEventLogger.LogErrorToWindowsEventLog("خطأ غير مُعالج في واجهة المستخدم.", e.Exception);
            clsFormMessages.ShowError("نعتذر، حدث خطأ غير متوقع. تم تسجيل تفاصيل الخطأ في سجل أحداث النظام.", "خطأ نظام حرج");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            clsEventLogger.LogErrorToWindowsEventLog("خطأ نظام غير مُعالج في الخلفية.", (Exception)e.ExceptionObject);
        }

        static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            clsEventLogger.LogErrorToWindowsEventLog("خطأ غير مُعالج في Task (Async).", e.Exception);

            // هذا السطر يخبر النظام بأننا تعاملنا مع الخطأ لمنع إنهيار التطبيق
            e.SetObserved();
        }

    }
}
