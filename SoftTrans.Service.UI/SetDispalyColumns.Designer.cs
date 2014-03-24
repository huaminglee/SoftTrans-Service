namespace SoftTrans.Service.Common.UI
{
    partial class SetDispalyColumns
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
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnReSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.grpColumns = new System.Windows.Forms.GroupBox();
            this.chkColumnsList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.grpButtons.SuspendLayout();
            this.grpColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkColumnsList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnReSelect);
            this.grpButtons.Controls.Add(this.btnExport);
            this.grpButtons.Controls.Add(this.btnUnSelect);
            this.grpButtons.Controls.Add(this.btnConfirm);
            this.grpButtons.Controls.Add(this.btnSelectAll);
            this.grpButtons.Location = new System.Drawing.Point(15, 397);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(415, 53);
            this.grpButtons.TabIndex = 0;
            this.grpButtons.TabStop = false;
            // 
            // btnReSelect
            // 
            this.btnReSelect.Location = new System.Drawing.Point(168, 24);
            this.btnReSelect.Name = "btnReSelect";
            this.btnReSelect.Size = new System.Drawing.Size(75, 23);
            this.btnReSelect.TabIndex = 2;
            this.btnReSelect.Text = "反选(&R)";
            this.btnReSelect.Click += new System.EventHandler(this.btnReSelect_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(249, 24);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出(&E)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Location = new System.Drawing.Point(87, 24);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnUnSelect.TabIndex = 2;
            this.btnUnSelect.Text = "全不选(&U)";
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(330, 24);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认(&O)";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(6, 24);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "全选(&A)";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_CheckedChanged);
            // 
            // grpColumns
            // 
            this.grpColumns.Controls.Add(this.chkColumnsList);
            this.grpColumns.Location = new System.Drawing.Point(12, 12);
            this.grpColumns.Name = "grpColumns";
            this.grpColumns.Size = new System.Drawing.Size(418, 382);
            this.grpColumns.TabIndex = 1;
            this.grpColumns.TabStop = false;
            this.grpColumns.Text = "列名";
            // 
            // chkColumnsList
            // 
            this.chkColumnsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkColumnsList.Location = new System.Drawing.Point(3, 18);
            this.chkColumnsList.Name = "chkColumnsList";
            this.chkColumnsList.Size = new System.Drawing.Size(412, 361);
            this.chkColumnsList.TabIndex = 0;
            // 
            // SetDispalyColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 462);
            this.Controls.Add(this.grpColumns);
            this.Controls.Add(this.grpButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetDispalyColumns";
            this.Text = "设置网格列可见性";
            this.Load += new System.EventHandler(this.SetDispalyColumns_Load);
            this.grpButtons.ResumeLayout(false);
            this.grpColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkColumnsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButtons;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private System.Windows.Forms.GroupBox grpColumns;
        private DevExpress.XtraEditors.CheckedListBoxControl chkColumnsList;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnUnSelect;
        private DevExpress.XtraEditors.SimpleButton btnReSelect;
    }
}