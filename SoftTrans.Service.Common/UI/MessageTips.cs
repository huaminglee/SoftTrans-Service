using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftTrans.Service.Common.UI
{
    /// <summary>
    /// 消息提示对话框
    /// </summary>
    public class MessageTips
    {
        private const string MSG_CAPTION = "系统提示";

        /// <summary>
        /// 普通消息提示
        /// </summary>
        /// <param name="msg">消息</param>
        public static void ShowTips(string msg)
        {
            XtraMessageBox.Show(msg, MSG_CAPTION);
        }
        /// <summary>
        /// 确认消息提示
        /// </summary>
        /// <param name="msg">消息</param>
        /// <returns>YesOrNo</returns>
        public static DialogResult ShowYesOrNo(string msg)
        {
            return XtraMessageBox.Show(msg, MSG_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        /// <summary>
        /// 重试提示
        /// </summary>
        /// <param name="msg">消息</param>
        /// <returns>RetryOrCancel</returns>
        public static DialogResult ShowReTry(string msg)
        {
            return XtraMessageBox.Show(msg, MSG_CAPTION, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 异常消息提示
        /// </summary>
        /// <param name="msg">消息</param>
        public static void ShowErrorMsg(string msg)
        {
            XtraMessageBox.Show(msg, MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
