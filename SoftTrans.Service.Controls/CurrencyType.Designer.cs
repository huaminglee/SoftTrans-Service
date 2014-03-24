namespace SoftTrans.Service.Controls
{
    partial class CurrencyType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lkpCurrencyType = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCurrencyType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkpCurrencyType
            // 
            this.lkpCurrencyType.Location = new System.Drawing.Point(0, 0);
            this.lkpCurrencyType.Name = "lkpCurrencyType";
            this.lkpCurrencyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lkpCurrencyType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Currency_Sign", "符号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Currency_Type_Name", "币制")});
            this.lkpCurrencyType.Properties.DisplayMember = "Currency_Type_Name";
            this.lkpCurrencyType.Properties.NullText = "[请选择币制]";
            this.lkpCurrencyType.Properties.ValueMember = "Currency_Type_Name";
            this.lkpCurrencyType.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lkpCurrencyType_Properties_ButtonClick);
            this.lkpCurrencyType.Size = new System.Drawing.Size(150, 20);
            this.lkpCurrencyType.TabIndex = 0;
            // 
            // CurrencyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lkpCurrencyType);
            this.Name = "CurrencyType";
            this.Size = new System.Drawing.Size(150, 20);
            ((System.ComponentModel.ISupportInitialize)(this.lkpCurrencyType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lkpCurrencyType;
    }
}
