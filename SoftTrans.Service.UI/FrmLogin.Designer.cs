namespace SoftTrans.Service.UI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserCode = new DevExpress.XtraEditors.TextEdit();
            this.txtUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.chkRemember = new DevExpress.XtraEditors.CheckEdit();
            this.picBanner = new DevExpress.XtraEditors.PictureEdit();
            this.lblCopyRight = new DevExpress.XtraEditors.LabelControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bgLogin = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRemember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(203, 265);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户编号：";
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(269, 262);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(167, 20);
            this.txtUserCode.TabIndex = 0;
            this.txtUserCode.ToolTip = "请输入用户编号.";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(269, 288);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Properties.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(167, 20);
            this.txtUserPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(459, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(71, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.Location = new System.Drawing.Point(361, 314);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Properties.Caption = "记住密码";
            this.chkRemember.Size = new System.Drawing.Size(75, 19);
            this.chkRemember.TabIndex = 2;
            this.chkRemember.CheckedChanged += new System.EventHandler(this.chkRemember_CheckedChanged);
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBanner.EditValue = ((object)(resources.GetObject("picBanner.EditValue")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal;
            this.picBanner.Size = new System.Drawing.Size(669, 242);
            this.picBanner.TabIndex = 5;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.Location = new System.Drawing.Point(0, 349);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(55, 14);
            this.lblCopyRight.TabIndex = 0;
            this.lblCopyRight.Text = "CopyRight";
            // 
            // picLogo
            // 
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(562, 319);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picLogo.Size = new System.Drawing.Size(100, 46);
            this.picLogo.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(203, 291);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "用户密码：";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 365);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRemember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserCode;
        private DevExpress.XtraEditors.TextEdit txtUserPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.CheckEdit chkRemember;
        private DevExpress.XtraEditors.PictureEdit picBanner;
        private DevExpress.XtraEditors.LabelControl lblCopyRight;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker bgLogin;
    }
}