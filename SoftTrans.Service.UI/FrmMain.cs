using SoftTrans.Service.Common;
using SoftTrans.Service.Common.UI;
using SoftTrans.Service.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{
    public partial class FrmMain : FormBase
    {
        delegate void SetWaitDialogShow(bool visible);

        public FrmMain()
        {
            InitializeComponent();
            this.backgroundWorkerRefreshMenu.WorkerReportsProgress = true;
            this.backgroundWorkerRefreshMenu.DoWork += new DoWorkEventHandler(backgroundWorkerRefreshMenu_DoWork);
            this.backgroundWorkerRefreshMenu.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerRefreshMenu_RunWorkerCompleted);
            this.backgroundWorkerRefreshMenu.ProgressChanged += new ProgressChangedEventHandler(backgroundWorkerRefreshMenu_ProgressChanged);
        }

        private void backgroundWorkerRefreshMenu_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backgroundWorkerRefreshMenu_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backgroundWorkerRefreshMenu_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 子窗体显示方法
        /// </summary>
        /// <param name="formType">窗体类型</param>
        /// <param name="windowName">窗体名称</param>
        private void ShowForm(Type formType, string windowName)
        {
            foreach (System.Windows.Forms.Form form in this.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    if (form.WindowState == FormWindowState.Minimized || form.WindowState == FormWindowState.Maximized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.Activate();


                    return;
                }
            }

            Form target = (Form)System.Activator.CreateInstance(formType);
            target.WindowState = FormWindowState.Normal;
            target.MdiParent = this;
            target.Show();
        }

        private void MenuBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "barBaseRate":
                    ShowForm(typeof(Frm_baseBalanceExchange_Rate), "汇率档案");
                    break;
                case "barCountry":
                    ShowForm(typeof(Frm_HrmCountry), "国家设置");
                    break;
                case "barProvince":
                    ShowForm(typeof(Frm_HrmProvince), "省份设置");
                    break;
                case "barSettings":
                    new Settings().ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                showDateTimer.Enabled = true;
                this.barVersionInfo.Caption = string.Format("版本号：v{0}", AssemblyManager.AssemblyVersion);
                this.barCompany.Caption = string.Format("操作公司：{0}", CommonVariable.OPERATE_COMPANY); ;
                this.barUser.Caption = string.Format("用户：{0}", CommonVariable.EMPLOYEE_NAME);
                this.Text = string.Format("{0} - v{1}", AssemblyManager.AssemblyTitle, AssemblyManager.AssemblyVersion);
                AlertMessage.ShowAlertMessage(this, "提示", "系统更新了");
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void showDateTimer_Tick(object sender, EventArgs e)
        {
            barDateInfo.Caption = DateTime.Now.ToString("系统时间：yyyy-MM-dd hh:mm:ss");
        }

    }
}
