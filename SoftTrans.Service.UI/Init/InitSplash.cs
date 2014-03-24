using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using SoftTrans.Service.Common;
using SoftTrans.Service.Common.UI;

namespace SoftTrans.Service.UI
{
    public partial class InitSplash : SplashScreen
    {
        public InitSplash()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        #region Overrides


        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);

            SplashScreenCommand command = (SplashScreenCommand)cmd;

            switch (command)
            {
                case SplashScreenCommand.SetStatus:
                    SetStatus(arg.ToString());
                    break;
                case SplashScreenCommand.SetProgress:
                    SetProgress(Convert.ToInt32(arg));
                    break;
                case SplashScreenCommand.SetPicture:
                    SetPictuer(Convert.ToInt32(arg));
                    break;
                default:
                    break;
            }

        }


        private void SetStatus(string status)
        {
            this.lblStatus.Text = status;
        }

        private void SetProgress(int value)
        {
            this.prsStatus.Position = value;
        }

        private void SetPictuer(int imgIndex)
        {
            this.picSlider.Image = imgList.Images[imgIndex];
        }








        #endregion

        public enum SplashScreenCommand
        {
            /// <summary>
            /// 设置状态
            /// </summary>
            SetStatus,
            /// <summary>
            /// 设置进度条
            /// </summary>
            SetProgress,
            /// <summary>
            /// 设置图片
            /// </summary>
            SetPicture

        }

        private void InitSplash_Load(object sender, EventArgs e)
        {
            this.lblCopyRight.Text = AssemblyManager.AssemblyCopyright;
            this.picSlider.Image = imgList.Images[0];

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void btnExit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}