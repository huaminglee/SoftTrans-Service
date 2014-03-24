namespace SoftTrans.Service.UI
{
    partial class Settings
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
            this.xtraTabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabUser = new DevExpress.XtraTab.XtraTabPage();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.AUTO_BEST_FITCOLUMNS = new DevExpress.XtraEditors.CheckEdit();
            this.SKIN_NAME = new DevExpress.XtraEditors.ComboBoxEdit();
            this.AUTO_OPEN_FILE = new DevExpress.XtraEditors.CheckEdit();
            this.SEND_ERROR = new DevExpress.XtraEditors.CheckEdit();
            this.WRITE_LOG = new DevExpress.XtraEditors.CheckEdit();
            this.PAGE_SIZE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).BeginInit();
            this.xtraTabMain.SuspendLayout();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUTO_BEST_FITCOLUMNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKIN_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUTO_OPEN_FILE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEND_ERROR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRITE_LOG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGE_SIZE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabMain
            // 
            this.xtraTabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabMain.Name = "xtraTabMain";
            this.xtraTabMain.SelectedTabPage = this.tabUser;
            this.xtraTabMain.Size = new System.Drawing.Size(456, 220);
            this.xtraTabMain.TabIndex = 0;
            this.xtraTabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabUser});
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.PAGE_SIZE);
            this.tabUser.Controls.Add(this.btnSave);
            this.tabUser.Controls.Add(this.labelControl2);
            this.tabUser.Controls.Add(this.labelControl1);
            this.tabUser.Controls.Add(this.AUTO_BEST_FITCOLUMNS);
            this.tabUser.Controls.Add(this.SKIN_NAME);
            this.tabUser.Controls.Add(this.AUTO_OPEN_FILE);
            this.tabUser.Controls.Add(this.SEND_ERROR);
            this.tabUser.Controls.Add(this.WRITE_LOG);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(450, 191);
            this.tabUser.Text = "个性设置";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(356, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存设置(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "每页显示数据条数";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "系统风格";
            // 
            // AUTO_BEST_FITCOLUMNS
            // 
            this.AUTO_BEST_FITCOLUMNS.Location = new System.Drawing.Point(25, 12);
            this.AUTO_BEST_FITCOLUMNS.Name = "AUTO_BEST_FITCOLUMNS";
            this.AUTO_BEST_FITCOLUMNS.Properties.Caption = "自动适应数据列宽";
            this.AUTO_BEST_FITCOLUMNS.Size = new System.Drawing.Size(143, 19);
            this.AUTO_BEST_FITCOLUMNS.TabIndex = 6;
            // 
            // SKIN_NAME
            // 
            this.SKIN_NAME.EditValue = "系统皮肤样式";
            this.SKIN_NAME.Location = new System.Drawing.Point(129, 65);
            this.SKIN_NAME.Name = "SKIN_NAME";
            this.SKIN_NAME.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SKIN_NAME.Size = new System.Drawing.Size(176, 20);
            this.SKIN_NAME.TabIndex = 4;
            // 
            // AUTO_OPEN_FILE
            // 
            this.AUTO_OPEN_FILE.Location = new System.Drawing.Point(174, 12);
            this.AUTO_OPEN_FILE.Name = "AUTO_OPEN_FILE";
            this.AUTO_OPEN_FILE.Properties.Caption = "导出后自动开启文件";
            this.AUTO_OPEN_FILE.Size = new System.Drawing.Size(131, 19);
            this.AUTO_OPEN_FILE.TabIndex = 5;
            // 
            // SEND_ERROR
            // 
            this.SEND_ERROR.Location = new System.Drawing.Point(25, 37);
            this.SEND_ERROR.Name = "SEND_ERROR";
            this.SEND_ERROR.Properties.Caption = "自动发送错误报告";
            this.SEND_ERROR.Size = new System.Drawing.Size(143, 19);
            this.SEND_ERROR.TabIndex = 8;
            // 
            // WRITE_LOG
            // 
            this.WRITE_LOG.Location = new System.Drawing.Point(174, 37);
            this.WRITE_LOG.Name = "WRITE_LOG";
            this.WRITE_LOG.Properties.Caption = "记录操作日志";
            this.WRITE_LOG.Size = new System.Drawing.Size(143, 19);
            this.WRITE_LOG.TabIndex = 9;
            // 
            // PAGE_SIZE
            // 
            this.PAGE_SIZE.Location = new System.Drawing.Point(129, 91);
            this.PAGE_SIZE.Name = "PAGE_SIZE";
            this.PAGE_SIZE.Properties.Mask.EditMask = "([1-9]\\d*)";
            this.PAGE_SIZE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.PAGE_SIZE.Size = new System.Drawing.Size(176, 20);
            this.PAGE_SIZE.TabIndex = 12;
            // 
            // Settings
            // 
            this.ActiveGlowColor = System.Drawing.Color.Empty;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 220);
            this.Controls.Add(this.xtraTabMain);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.InactiveGlowColor = System.Drawing.Color.Empty;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).EndInit();
            this.xtraTabMain.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUTO_BEST_FITCOLUMNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKIN_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUTO_OPEN_FILE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEND_ERROR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRITE_LOG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAGE_SIZE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabMain;
        private DevExpress.XtraTab.XtraTabPage tabUser;
        private DevExpress.XtraEditors.ComboBoxEdit SKIN_NAME;
        private DevExpress.XtraEditors.CheckEdit AUTO_BEST_FITCOLUMNS;
        private DevExpress.XtraEditors.CheckEdit AUTO_OPEN_FILE;
        private DevExpress.XtraEditors.CheckEdit SEND_ERROR;
        private DevExpress.XtraEditors.CheckEdit WRITE_LOG;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit PAGE_SIZE;
    }
}