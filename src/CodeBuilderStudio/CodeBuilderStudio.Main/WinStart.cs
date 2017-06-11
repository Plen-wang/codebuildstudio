using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace CodeBuilderStudio.Main
{
    public static class WinStart
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isstart = false;
            Mutex mutex = new Mutex(false, "mycodebuilder", out isstart);
            if (!isstart)
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            FrmFlash flash = new FrmFlash();
            flash.Show();
            flash.Refresh();
            Application.Run(new FrmMain(flash));
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ComeCommonMethod.LogFunction.WritePrivateProfileString(
               "Application_ThreadException", e.Exception.ToString(), e.ToString(), Environment.CurrentDirectory + "\\Application.ini");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ComeCommonMethod.LogFunction.WritePrivateProfileString(
                "CurrentDomain_UnhandledException", e.ExceptionObject.ToString(), e.ToString(), Environment.CurrentDirectory + "\\AppDomain.ini");
        }
    }
}
