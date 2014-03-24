namespace SoftTrans.Service.UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pager1 = new SoftTrans.Service.Controls.Pager();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtFatherMenuID = new System.Windows.Forms.TextBox();
            this.txtMenuCaption = new System.Windows.Forms.TextBox();
            this.txtMenuTag = new System.Windows.Forms.TextBox();
            this.txtSystemID = new System.Windows.Forms.TextBox();
            this.txtMenuEnabled = new System.Windows.Forms.TextBox();
            this.txtTargetForm = new System.Windows.Forms.TextBox();
            this.txtMenuID = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(10, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 27);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 206);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(981, 224);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // pager1
            // 
            this.pager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager1.JumpText = "Go";
            this.pager1.Location = new System.Drawing.Point(0, 431);
            this.pager1.Name = "pager1";
            this.pager1.PageIndex = 1;
            this.pager1.PageSize = 100;
            this.pager1.RecordCount = 0;
            this.pager1.Size = new System.Drawing.Size(981, 34);
            this.pager1.TabIndex = 3;
            this.pager1.Load += new System.EventHandler(this.pager1_Load);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(119, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 27);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "新增";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(231, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(93, 27);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "修改";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(347, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(93, 27);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "删除";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtFatherMenuID
            // 
            this.txtFatherMenuID.Location = new System.Drawing.Point(67, 124);
            this.txtFatherMenuID.Name = "txtFatherMenuID";
            this.txtFatherMenuID.Size = new System.Drawing.Size(100, 22);
            this.txtFatherMenuID.TabIndex = 4;
            // 
            // txtMenuCaption
            // 
            this.txtMenuCaption.Location = new System.Drawing.Point(67, 152);
            this.txtMenuCaption.Name = "txtMenuCaption";
            this.txtMenuCaption.Size = new System.Drawing.Size(100, 22);
            this.txtMenuCaption.TabIndex = 4;
            // 
            // txtMenuTag
            // 
            this.txtMenuTag.Location = new System.Drawing.Point(182, 96);
            this.txtMenuTag.Name = "txtMenuTag";
            this.txtMenuTag.Size = new System.Drawing.Size(100, 22);
            this.txtMenuTag.TabIndex = 4;
            // 
            // txtSystemID
            // 
            this.txtSystemID.Location = new System.Drawing.Point(182, 124);
            this.txtSystemID.Name = "txtSystemID";
            this.txtSystemID.Size = new System.Drawing.Size(100, 22);
            this.txtSystemID.TabIndex = 4;
            // 
            // txtMenuEnabled
            // 
            this.txtMenuEnabled.Location = new System.Drawing.Point(182, 152);
            this.txtMenuEnabled.Name = "txtMenuEnabled";
            this.txtMenuEnabled.Size = new System.Drawing.Size(100, 22);
            this.txtMenuEnabled.TabIndex = 4;
            // 
            // txtTargetForm
            // 
            this.txtTargetForm.Location = new System.Drawing.Point(300, 94);
            this.txtTargetForm.Name = "txtTargetForm";
            this.txtTargetForm.Size = new System.Drawing.Size(100, 22);
            this.txtTargetForm.TabIndex = 4;
            // 
            // txtMenuID
            // 
            this.txtMenuID.Location = new System.Drawing.Point(67, 96);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.Size = new System.Drawing.Size(100, 20);
            this.txtMenuID.TabIndex = 5;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(469, 12);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(93, 27);
            this.simpleButton5.TabIndex = 1;
            this.simpleButton5.Text = "更新网格";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(674, 29);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(246, 66);
            this.progressPanel1.TabIndex = 6;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(469, 119);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(93, 27);
            this.simpleButton6.TabIndex = 1;
            this.simpleButton6.Text = "抛异常";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 465);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.txtMenuID);
            this.Controls.Add(this.txtTargetForm);
            this.Controls.Add(this.txtMenuEnabled);
            this.Controls.Add(this.txtSystemID);
            this.Controls.Add(this.txtMenuTag);
            this.Controls.Add(this.txtMenuCaption);
            this.Controls.Add(this.txtFatherMenuID);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Controls.Pager pager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtFatherMenuID;
        private System.Windows.Forms.TextBox txtMenuCaption;
        private System.Windows.Forms.TextBox txtMenuTag;
        private System.Windows.Forms.TextBox txtSystemID;
        private System.Windows.Forms.TextBox txtMenuEnabled;
        private System.Windows.Forms.TextBox txtTargetForm;
        private DevExpress.XtraEditors.TextEdit txtMenuID;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}

