namespace SoftTrans.Service.UI
{
    partial class FrmErrorHandle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErrorHandle));
            this.grpTips = new System.Windows.Forms.GroupBox();
            this.grpErrorBox = new System.Windows.Forms.GroupBox();
            this.txtErrorTips = new DevExpress.XtraEditors.MemoEdit();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnContiune = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetails = new DevExpress.XtraEditors.SimpleButton();
            this.lblDefaultMsg = new DevExpress.XtraEditors.LabelControl();
            this.txtErrorMsg = new DevExpress.XtraEditors.MemoEdit();
            this.btnSendErrorMsg = new DevExpress.XtraEditors.SimpleButton();
            this.grpTips.SuspendLayout();
            this.grpErrorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorTips.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorMsg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTips
            // 
            this.grpTips.Controls.Add(this.grpErrorBox);
            this.grpTips.Controls.Add(this.picLogo);
            this.grpTips.Controls.Add(this.btnExit);
            this.grpTips.Controls.Add(this.btnContiune);
            this.grpTips.Controls.Add(this.btnDetails);
            this.grpTips.Controls.Add(this.lblDefaultMsg);
            this.grpTips.Location = new System.Drawing.Point(4, -4);
            this.grpTips.Name = "grpTips";
            this.grpTips.Size = new System.Drawing.Size(492, 144);
            this.grpTips.TabIndex = 0;
            this.grpTips.TabStop = false;
            // 
            // grpErrorBox
            // 
            this.grpErrorBox.Controls.Add(this.txtErrorTips);
            this.grpErrorBox.Location = new System.Drawing.Point(102, 28);
            this.grpErrorBox.Name = "grpErrorBox";
            this.grpErrorBox.Size = new System.Drawing.Size(381, 81);
            this.grpErrorBox.TabIndex = 3;
            this.grpErrorBox.TabStop = false;
            // 
            // txtErrorTips
            // 
            this.txtErrorTips.Location = new System.Drawing.Point(1, 10);
            this.txtErrorTips.Name = "txtErrorTips";
            this.txtErrorTips.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtErrorTips.Properties.Appearance.Options.UseForeColor = true;
            this.txtErrorTips.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtErrorTips.Properties.ReadOnly = true;
            this.txtErrorTips.Size = new System.Drawing.Size(380, 68);
            this.txtErrorTips.TabIndex = 1;
            this.txtErrorTips.UseOptimizedRendering = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(6, 21);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(88, 88);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出(&Q)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnContiune
            // 
            this.btnContiune.Location = new System.Drawing.Point(302, 115);
            this.btnContiune.Name = "btnContiune";
            this.btnContiune.Size = new System.Drawing.Size(88, 23);
            this.btnContiune.TabIndex = 1;
            this.btnContiune.Text = "继续(&C)";
            this.btnContiune.Click += new System.EventHandler(this.btnContiune_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(6, 115);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(88, 23);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "▲详细信息(&D)";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblDefaultMsg
            // 
            this.lblDefaultMsg.Location = new System.Drawing.Point(103, 15);
            this.lblDefaultMsg.Name = "lblDefaultMsg";
            this.lblDefaultMsg.Size = new System.Drawing.Size(244, 14);
            this.lblDefaultMsg.TabIndex = 0;
            this.lblDefaultMsg.Text = "非常抱歉，应用程序发生了无法处理的异常....";
            // 
            // txtErrorMsg
            // 
            this.txtErrorMsg.Location = new System.Drawing.Point(4, 146);
            this.txtErrorMsg.Name = "txtErrorMsg";
            this.txtErrorMsg.Properties.ReadOnly = true;
            this.txtErrorMsg.Size = new System.Drawing.Size(492, 284);
            this.txtErrorMsg.TabIndex = 1;
            this.txtErrorMsg.UseOptimizedRendering = true;
            // 
            // btnSendErrorMsg
            // 
            this.btnSendErrorMsg.Location = new System.Drawing.Point(399, 436);
            this.btnSendErrorMsg.Name = "btnSendErrorMsg";
            this.btnSendErrorMsg.Size = new System.Drawing.Size(97, 23);
            this.btnSendErrorMsg.TabIndex = 0;
            this.btnSendErrorMsg.Text = "发送错误报告(&S)";
            this.btnSendErrorMsg.Click += new System.EventHandler(this.btnSendErrorMsg_Click);
            // 
            // FrmErrorHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 462);
            this.Controls.Add(this.txtErrorMsg);
            this.Controls.Add(this.grpTips);
            this.Controls.Add(this.btnSendErrorMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmErrorHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统异常";
            this.grpTips.ResumeLayout(false);
            this.grpTips.PerformLayout();
            this.grpErrorBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorTips.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorMsg.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTips;
        private DevExpress.XtraEditors.MemoEdit txtErrorMsg;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnContiune;
        private DevExpress.XtraEditors.SimpleButton btnDetails;
        private DevExpress.XtraEditors.LabelControl lblDefaultMsg;
        private DevExpress.XtraEditors.SimpleButton btnSendErrorMsg;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpErrorBox;
        private DevExpress.XtraEditors.MemoEdit txtErrorTips;
    }
}