namespace SoftTrans.Service.UI
{
    partial class InitSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitSplash));
            this.lblCopyRight = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.picSlider = new DevExpress.XtraEditors.PictureEdit();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.imgList = new DevExpress.Utils.ImageCollection(this.components);
            this.prsStatus = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnExit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlider.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblCopyRight.Location = new System.Drawing.Point(7, 365);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(99, 14);
            this.lblCopyRight.TabIndex = 6;
            this.lblCopyRight.Text = "Copyright © 2104";
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblStatus.Location = new System.Drawing.Point(7, 289);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "正在加载系统配置...";
            // 
            // picSlider
            // 
            this.picSlider.EditValue = ((object)(resources.GetObject("picSlider.EditValue")));
            this.picSlider.Location = new System.Drawing.Point(7, 27);
            this.picSlider.Name = "picSlider";
            this.picSlider.Properties.AllowFocused = false;
            this.picSlider.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picSlider.Properties.Appearance.Options.UseBackColor = true;
            this.picSlider.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.picSlider.Properties.ShowMenu = false;
            this.picSlider.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picSlider.Size = new System.Drawing.Size(576, 258);
            this.picSlider.TabIndex = 9;
            // 
            // picLogo
            // 
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(459, 333);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.AllowFocused = false;
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.ShowMenu = false;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picLogo.Size = new System.Drawing.Size(124, 54);
            this.picLogo.TabIndex = 8;
            // 
            // imgList
            // 
            this.imgList.ImageSize = new System.Drawing.Size(490, 220);
            this.imgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.Images.SetKeyName(0, "Splash001.jpg");
            this.imgList.Images.SetKeyName(1, "Splash002.jpg");
            this.imgList.Images.SetKeyName(2, "Splash003.jpg");
            // 
            // prsStatus
            // 
            this.prsStatus.Location = new System.Drawing.Point(7, 310);
            this.prsStatus.Name = "prsStatus";
            this.prsStatus.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.prsStatus.Properties.Step = 1;
            this.prsStatus.ShowProgressInTaskBar = true;
            this.prsStatus.Size = new System.Drawing.Size(576, 17);
            this.prsStatus.TabIndex = 10;
            this.prsStatus.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.EditValue = ((object)(resources.GetObject("btnExit.EditValue")));
            this.btnExit.Location = new System.Drawing.Point(560, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Properties.AllowFocused = false;
            this.btnExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Properties.Appearance.Options.UseBackColor = true;
            this.btnExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExit.Properties.ShowMenu = false;
            this.btnExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.btnExit.Size = new System.Drawing.Size(26, 26);
            this.btnExit.TabIndex = 8;
            this.btnExit.EditValueChanged += new System.EventHandler(this.btnExit_EditValueChanged);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // InitSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 384);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.prsStatus);
            this.Controls.Add(this.picSlider);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCopyRight);
            this.Name = "InitSplash";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InitSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCopyRight;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.PictureEdit picSlider;
        private DevExpress.Utils.ImageCollection imgList;
        private DevExpress.XtraEditors.ProgressBarControl prsStatus;
        private DevExpress.XtraEditors.PictureEdit btnExit;
    }
}
