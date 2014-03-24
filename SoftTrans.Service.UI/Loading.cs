using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace SoftTrans.Service.UI
{
    public partial class Loading : WaitForm
    {
        public Loading()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);

            WaitFormCommand command = (WaitFormCommand)cmd;
            switch (command)
            {
                case WaitFormCommand.SAVE:
                    SetDescription("正在后台保存数据 ...");
                    break;
                case WaitFormCommand.SELECT:
                    SetDescription("正在后台查询数据 ...");
                    break;
                case WaitFormCommand.LOADING:
                    SetDescription("正在后台加载数据 ...");
                    break;
                case WaitFormCommand.EXPORT:
                    SetDescription("正在后台导出数据 ...");
                    break;
                case WaitFormCommand.IMPORT:
                    SetDescription("正在后台导入数据 ...");
                    break;
                case WaitFormCommand.LOGIN:
                    SetDescription("正在验证用户 ...");
                    break;
                default:
                    break;
            }
        }

        #endregion

        public enum WaitFormCommand
        {
            /// <summary>
            /// 保存
            /// </summary>
            SAVE,
            /// <summary>
            /// 查询
            /// </summary>
            SELECT,
            /// <summary>
            /// 加载
            /// </summary>
            LOADING,
            /// <summary>
            /// 导入
            /// </summary>
            IMPORT,
            /// <summary>
            /// 导出
            /// </summary>
            EXPORT,
            /// <summary>
            /// 登陆
            /// </summary>
            LOGIN
        }
    }
}