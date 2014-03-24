namespace SoftTrans.Service.Controls
{
    partial class MonthEdit
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMonth
            // 
            this.cboMonth.EditValue = "";
            this.cboMonth.Location = new System.Drawing.Point(0, 0);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMonth.Size = new System.Drawing.Size(76, 20);
            this.cboMonth.TabIndex = 0;
            // 
            // MonthEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboMonth);
            this.Name = "MonthEdit";
            this.Size = new System.Drawing.Size(76, 20);
            ((System.ComponentModel.ISupportInitialize)(this.cboMonth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboMonth;
    }
}
