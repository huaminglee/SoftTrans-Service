using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using SoftTrans.Service.Common;
using SoftTrans.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{
    public class InitProgram
    {
        /// <summary>
        /// 初始化公共变量
        /// </summary>
        public static void InitCommonVarable()
        {
            if (System.IO.File.Exists("Settings.db"))
            {
                InitUserConfig.Init();
            }
            else
            {
                InitUserConfig.SetDefaultConfig();
            }
        }

        public static void IninSystem()
        {
            #region 显示初始化
            //显示初始化
            SplashScreenManager.ShowForm(typeof(InitSplash));
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "系统正在初始化...");
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetProgress, 20);
            System.Threading.Thread.Sleep(1000);
            #endregion

            #region 加载用户配置
            //加载用户配置
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "系统正在加载用户设置..");
            InitProgram.InitCommonVarable();
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetProgress, 30);
            System.Threading.Thread.Sleep(1000);
            #endregion

            #region 测试网络连通性
            //测试网络连通性
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetPicture, 1);
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "正在检测与服务器连接是否异常..");
            System.Threading.Thread.Sleep(1000);
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send("219.133.34.103");
                    if (reply.Status == IPStatus.Success)
                    {
                        System.Threading.Thread.Sleep(1000);
                        SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetProgress, 40);
                        SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "服务器连接成功..");
                    }
                    else
                    {
                        int times = 1;
                        int progressValue = 30;

                        SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "服务器连接失败，5秒后重新尝试连接...");
                        //重新连接次数;
                        do
                        {
                            if (times >= 5)
                            {
                                SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "尝试连接超过5次,连接失败程序即将终止..");
                                System.Threading.Thread.Sleep(2000);
                                System.Diagnostics.Process.GetCurrentProcess().Kill();
                            }

                            Thread.Sleep(5000);//等待5秒
                            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, string.Format("第{0}次尝试与服务器取得连接...", times));
                            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetProgress, progressValue + 10);
                            reply = ping.Send("219.133.34.103");
                            times++;
                            progressValue = progressValue + 10;
                        }
                        while (reply.Status != IPStatus.Success);
                    }
                }
                catch (Exception ex)
                {
                    FrmErrorHandle.ErrorLogShow(ex);
                }
            }
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetPicture, 2);
            System.Threading.Thread.Sleep(1000);
            #endregion

            #region 加载基础数据
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "正在加载基础数据..");
            InitBaesData.LoadBaseData();
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetStatus, "加载完成,正在启动..");
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetProgress, 60);
            #endregion

            #region 跳转
            SplashScreenManager.Default.SendCommand(SoftTrans.Service.UI.InitSplash.SplashScreenCommand.SetProgress, 100);
            SplashScreenManager.CloseForm();
            Application.Run(new FrmMain());
            #endregion
        }


    }
}
