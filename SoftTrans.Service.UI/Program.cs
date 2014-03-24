
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using SoftTrans.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            BindExceptionHandler();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //注册皮肤
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");


            //显示登陆窗体
            FrmLogin loginView = new FrmLogin();
            loginView.ShowDialog();


            if (loginView.DialogResult == DialogResult.OK)
            {
                InitProgram.IninSystem();
            }
        }


        /// <summary>
        /// 绑定程序中的异常处理
        /// </summary>
        private static void BindExceptionHandler()
        {
            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //处理未捕获的异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        /// <summary>
        /// 处理UI线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            LogHelper.ErrorLog(null, e.Exception as Exception);
        }
        /// <summary>
        /// 处理未捕获的异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogHelper.ErrorLog(null, e.ExceptionObject as Exception);
        }
    }
}
