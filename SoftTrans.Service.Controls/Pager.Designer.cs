namespace SoftTrans.Service.Controls
{
    partial class Pager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pager));
            this.txtPageNum = new DevExpress.XtraEditors.SpinEdit();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.lblPageInfo = new DevExpress.XtraEditors.LabelControl();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.txtPageSize = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPageNum
            // 
            this.txtPageNum.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPageNum.Location = new System.Drawing.Point(549, 4);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPageNum.Properties.IsFloatValue = false;
            this.txtPageNum.Properties.Mask.EditMask = "(0|[1-9]\\d*)";
            this.txtPageNum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPageNum.Size = new System.Drawing.Size(58, 20);
            this.txtPageNum.TabIndex = 11;
            this.txtPageNum.TextChanged += new System.EventHandler(this.txtPageNum_TextChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFirst.Location = new System.Drawing.Point(326, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.ShowToolTips = false;
            this.btnFirst.Size = new System.Drawing.Size(46, 20);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.ToolTip = "首页";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(303, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "条";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(613, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(52, 20);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "跳转";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(208, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "每页";
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(380, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(46, 20);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.ToolTip = "上一页";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Location = new System.Drawing.Point(10, 7);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(177, 14);
            this.lblPageInfo.TabIndex = 10;
            this.lblPageInfo.Text = "共 0 条记录，共 0 页，当前 0 页";
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(434, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 20);
            this.btnNext.TabIndex = 6;
            this.btnNext.ToolTip = "下一页";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLast.Location = new System.Drawing.Point(488, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(46, 20);
            this.btnLast.TabIndex = 7;
            this.btnLast.ToolTip = "尾页";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtPageSize
            // 
            this.txtPageSize.EditValue = "100";
            this.txtPageSize.Location = new System.Drawing.Point(239, 4);
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Properties.Mask.EditMask = "([1-9]\\d*)";
            this.txtPageSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPageSize.Size = new System.Drawing.Size(58, 20);
            this.txtPageSize.TabIndex = 13;
            this.txtPageSize.TextChanged += new System.EventHandler(this.txtPageSize_TextChanged);
            this.txtPageSize.Leave += new System.EventHandler(this.txtPageSize_Leave);
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.txtPageNum);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(697, 30);
            ((System.ComponentModel.ISupportInitialize)(this.txtPageNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit txtPageNum;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.LabelControl lblPageInfo;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.TextEdit txtPageSize;

    }
}
