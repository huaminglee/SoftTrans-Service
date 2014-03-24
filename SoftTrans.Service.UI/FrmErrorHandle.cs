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
using SoftTrans.Service.UI;
using SoftTrans.Service.Common.UI;

namespace SoftTrans.Service.UI
{
    /// <summary>
    /// 异常捕获窗体
    /// </summary>
    public partial class FrmErrorHandle : FormBase
    {
        #region 声明变量
        /// <summary>
        /// 异常
        /// </summary>
        private Exception ex;
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_ex">异常</param>
        public FrmErrorHandle(Exception _ex)
        {
            InitializeComponent();
            this.ex = _ex;
            this.Height = 180;
            this.TopMost = true;
            txtErrorTips.Text = ex.Message;
            txtErrorMsg.Text = FormatErrorMsg(ex);
            //记录异常
            LogHelper.ErrorLog(string.Empty, ex);

        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 格式化异常信息
        /// </summary>
        /// <param name="ex">异常</param>
        /// <returns></returns>
        private string FormatErrorMsg(Exception ex)
        {
            var strError = new StringBuilder();
            strError.Append(System.Environment.NewLine);
            strError.Append("**************************** 异常文本 ****************************" + System.Environment.NewLine);
            strError.Append(string.Format("【异常类型】：{0}", ex.GetType().Name) + System.Environment.NewLine);
            strError.Append(string.Format("【异常信息】：{0}", ex.Message) + System.Environment.NewLine);
            strError.Append(string.Format("【堆栈调用】：{0}", ex.StackTrace) + System.Environment.NewLine);

            strError.Append("**************************** 运行平台 ****************************" + System.Environment.NewLine);
            strError.Append(string.Format("【平台标识】：{0}", System.Environment.OSVersion.VersionString) + System.Environment.NewLine);
            strError.Append(string.Format("【系统位数】：{0}", System.Environment.Is64BitOperatingSystem ? "64位" : "32位") + System.Environment.NewLine);
            strError.Append(string.Format("【类库版本】：{0}", System.Environment.Version.ToString()) + System.Environment.NewLine);

            strError.Append("**************************** 系统信息 ****************************" + System.Environment.NewLine);
            strError.Append(string.Format("【系统名称】：{0}", AssemblyManager.AssemblyTitle) + System.Environment.NewLine);
            strError.Append(string.Format("【系统版本】：{0}", AssemblyManager.AssemblyVersion) + System.Environment.NewLine);

            strError.Append("**************************** 用户信息 ****************************" + System.Environment.NewLine);
            strError.Append(string.Format("【操作用户】：{0}", CommonVariable.USER_CODE) + System.Environment.NewLine);
            strError.Append(string.Format("【所属部门】：{0}", CommonVariable.USER_DEPT) + System.Environment.NewLine);
            strError.Append(string.Format("【操作公司】：{0}", CommonVariable.OPERATE_COMPANY) + System.Environment.NewLine);

            return strError.ToString();
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 显示异常
        /// </summary>
        /// <param name="ex">异常</param>
        public static void ErrorLogShow(Exception ex)
        {

            FrmErrorHandle frm = new FrmErrorHandle(ex);
            frm.ShowDialog();

        }
        #endregion

        #region 事件处理
        //详细信息
        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Height <= 180)
                {
                    this.Height = 500;
                    this.btnDetails.Text = "▲详细信息(&D)";
                }
                else
                {
                    this.Height = 180;
                    this.btnDetails.Text = "▼详细信息(&D)";
                }
            }
            catch
            {
                return;
            }
        }
        //继续
        private void btnContiune_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            //以对话框形式确认是否退出
            DialogResult result = MessageTips.ShowYesOrNo("您确认立即关闭当前系统吗？");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //发送错误报告
        private void btnSendErrorMsg_Click(object sender, EventArgs e)
        {
            try
            {
                Email erroLog = new Email(ex.Message, txtErrorMsg.Text);
                erroLog.Send();
            }
            catch (Exception)
            {

                return;
            }
        }
        #endregion
    }
}