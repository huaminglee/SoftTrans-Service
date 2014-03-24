using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoftTrans.Service.Common;
using DevExpress.XtraSplashScreen;
using SoftTrans.Service.Common.UI;

namespace SoftTrans.Service.UI
{
    public partial class FrmLogin : FormBase
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.bgLogin.DoWork += new DoWorkEventHandler(bgLoign_DoWork);
            this.bgLogin.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgLoign_RunWorkerCompleted);

        }


        private void bgLoign_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //成功标识
            bool result = (bool)e.Result;

            //TODO:执行完成  判断验证是否成功

            if (result)
            {
                //TODO: 成功 公共变量赋值
                CommonVariable.USER_CODE = txtUserCode.Text;
                CommonVariable.USER_PASSWORD = txtUserPassword.Text;
                CommonVariable.REMEMBER_PASSWORD = chkRemember.Checked;
                CommonVariable.EMPLOYEE_NAME = "管理员";
                CommonVariable.OPERATE_COMPANY = "深圳软通物流";
                CommonVariable.OPERATE_COMPANY_CODE = "SZX";
                CommonVariable.USER_DEPT = "IT DEPT";
                InitUserConfig.SetCustomerSettings();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageTips.ShowErrorMsg("用户验证失败！");
            }
            SplashScreenManager.CloseForm();

        }

        private void bgLoign_DoWork(object sender, DoWorkEventArgs e)
        {
            bool result = false;
            SplashScreenManager.ShowForm(typeof(Loading));
            SplashScreenManager.Default.SendCommand(Loading.WaitFormCommand.LOGIN, null);

            //TODO:登陆验证
            if (txtUserPassword.Text == "admin")
            {
                result = true;
            }
            //验证 成功 失败
            e.Result = result;
        }




        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.lblCopyRight.Text = AssemblyManager.AssemblyCopyright;

            InitUserConfig.Init();


            txtUserCode.Text = CommonVariable.USER_CODE;
            txtUserPassword.Text = CommonVariable.USER_PASSWORD;
            chkRemember.Checked = CommonVariable.REMEMBER_PASSWORD;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (bgLogin.IsBusy) return;

                //TODO:验证是有输入
                if (txtUserCode.Text.Length < 1)
                {
                    txtUserCode.Focus();
                    return;
                }
                if (txtUserPassword.Text.Length < 1)
                {
                    txtUserPassword.Focus();
                    return;
                }

                //TODO:后台验证用户
                bgLogin.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}