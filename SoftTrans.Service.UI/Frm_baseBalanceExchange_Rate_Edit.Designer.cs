namespace SoftTrans.Service.UI
{
    partial class Frm_baseBalanceExchange_Rate_Edit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.layPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRecorder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sptExchange_Rate = new DevExpress.XtraEditors.SpinEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lkpContract_Currency = new SoftTrans.Service.Controls.CurrencyType();
            this.lkpBalance_Currency = new SoftTrans.Service.Controls.CurrencyType();
            this.cmbRate_Date = new SoftTrans.Service.Controls.MonthEdit();
            this.grpControls.SuspendLayout();
            this.layPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecorder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptExchange_Rate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.layPanel);
            this.grpControls.Location = new System.Drawing.Point(12, 12);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(629, 105);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "汇率录入";
            // 
            // layPanel
            // 
            this.layPanel.ColumnCount = 6;
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.layPanel.Controls.Add(this.lkpContract_Currency, 1, 0);
            this.layPanel.Controls.Add(this.lkpBalance_Currency, 1, 1);
            this.layPanel.Controls.Add(this.labelControl1, 0, 0);
            this.layPanel.Controls.Add(this.labelControl2, 0, 1);
            this.layPanel.Controls.Add(this.labelControl3, 2, 0);
            this.layPanel.Controls.Add(this.labelControl4, 2, 1);
            this.layPanel.Controls.Add(this.cmbRate_Date, 3, 0);
            this.layPanel.Controls.Add(this.txtRecorder, 3, 1);
            this.layPanel.Controls.Add(this.labelControl5, 4, 0);
            this.layPanel.Controls.Add(this.sptExchange_Rate, 5, 0);
            this.layPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layPanel.Location = new System.Drawing.Point(3, 18);
            this.layPanel.Name = "layPanel";
            this.layPanel.RowCount = 2;
            this.layPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.layPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.layPanel.Size = new System.Drawing.Size(623, 84);
            this.layPanel.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "合同币制";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "结算币制";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(243, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "汇率月份";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(243, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "录入人";
            // 
            // txtRecorder
            // 
            this.txtRecorder.Location = new System.Drawing.Point(303, 37);
            this.txtRecorder.Name = "txtRecorder";
            this.txtRecorder.Size = new System.Drawing.Size(92, 20);
            this.txtRecorder.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(421, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "汇率";
            // 
            // sptExchange_Rate
            // 
            this.sptExchange_Rate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sptExchange_Rate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sptExchange_Rate.Location = new System.Drawing.Point(481, 3);
            this.sptExchange_Rate.Name = "sptExchange_Rate";
            this.sptExchange_Rate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sptExchange_Rate.Size = new System.Drawing.Size(100, 20);
            this.sptExchange_Rate.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lkpContract_Currency
            // 
            this.lkpContract_Currency.DataSource = null;
            this.lkpContract_Currency.EditValue = "[请选择币制]";
            this.lkpContract_Currency.Location = new System.Drawing.Point(63, 3);
            this.lkpContract_Currency.Name = "lkpContract_Currency";
            this.lkpContract_Currency.Size = new System.Drawing.Size(150, 21);
            this.lkpContract_Currency.TabIndex = 0;
            // 
            // lkpBalance_Currency
            // 
            this.lkpBalance_Currency.DataSource = null;
            this.lkpBalance_Currency.EditValue = "[请选择币制]";
            this.lkpBalance_Currency.Location = new System.Drawing.Point(63, 37);
            this.lkpBalance_Currency.Name = "lkpBalance_Currency";
            this.lkpBalance_Currency.Size = new System.Drawing.Size(150, 21);
            this.lkpBalance_Currency.TabIndex = 1;
            // 
            // cmbRate_Date
            // 
            this.cmbRate_Date.EditValue = "";
            this.cmbRate_Date.Location = new System.Drawing.Point(303, 3);
            this.cmbRate_Date.Name = "cmbRate_Date";
            this.cmbRate_Date.Size = new System.Drawing.Size(107, 21);
            this.cmbRate_Date.TabIndex = 7;
            // 
            // Frm_baseBalanceExchange_Rate_Edit
            // 
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(648, 345);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_baseBalanceExchange_Rate_Edit";
            this.Text = "汇率档案";
            this.Load += new System.EventHandler(this.Frm_baseBalanceExchange_Rate_Edit_Load);
            this.grpControls.ResumeLayout(false);
            this.layPanel.ResumeLayout(false);
            this.layPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecorder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptExchange_Rate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.TableLayoutPanel layPanel;
        private Controls.CurrencyType lkpContract_Currency;
        private Controls.CurrencyType lkpBalance_Currency;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Controls.MonthEdit cmbRate_Date;
        private DevExpress.XtraEditors.TextEdit txtRecorder;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit sptExchange_Rate;
    }
}
