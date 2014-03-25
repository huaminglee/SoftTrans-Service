namespace SoftTrans.Service.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MenuBar = new DevExpress.XtraBars.BarManager(this.components);
            this.MainMenu = new DevExpress.XtraBars.Bar();
            this.barTools = new DevExpress.XtraBars.BarSubItem();
            this.barSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barLoadBaseData = new DevExpress.XtraBars.BarButtonItem();
            this.barBase = new DevExpress.XtraBars.BarSubItem();
            this.barBaseRate = new DevExpress.XtraBars.BarButtonItem();
            this.MainStatuBar = new DevExpress.XtraBars.Bar();
            this.barUser = new DevExpress.XtraBars.BarStaticItem();
            this.barCompany = new DevExpress.XtraBars.BarStaticItem();
            this.barDateInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barVersionInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BarImgList = new DevExpress.Utils.ImageCollection(this.components);
            this.messageAlter = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.backgroundWorkerRefreshMenu = new System.ComponentModel.BackgroundWorker();
            this.xtraMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.showDateTimer = new System.Windows.Forms.Timer(this.components);
            this.barCountry = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarImgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // imgToolBar
            // 
            this.imgToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolBar.ImageStream")));
            this.imgToolBar.Images.SetKeyName(0, "Add.ico");
            this.imgToolBar.Images.SetKeyName(1, "AddUser.ico");
            this.imgToolBar.Images.SetKeyName(2, "Cancel.ico");
            this.imgToolBar.Images.SetKeyName(3, "Categories.ico");
            this.imgToolBar.Images.SetKeyName(4, "Chart.ico");
            this.imgToolBar.Images.SetKeyName(5, "Close.ico");
            this.imgToolBar.Images.SetKeyName(6, "Delete.ico");
            this.imgToolBar.Images.SetKeyName(7, "Delivery.ico");
            this.imgToolBar.Images.SetKeyName(8, "Download.ico");
            this.imgToolBar.Images.SetKeyName(9, "Edit.ico");
            this.imgToolBar.Images.SetKeyName(10, "Email.ico");
            this.imgToolBar.Images.SetKeyName(11, "Error.ico");
            this.imgToolBar.Images.SetKeyName(12, "Exit.ico");
            this.imgToolBar.Images.SetKeyName(13, "Expand.ico");
            this.imgToolBar.Images.SetKeyName(14, "ExportExcel.ico");
            this.imgToolBar.Images.SetKeyName(15, "ExportPDF.ico");
            this.imgToolBar.Images.SetKeyName(16, "Female.ico");
            this.imgToolBar.Images.SetKeyName(17, "First.ico");
            this.imgToolBar.Images.SetKeyName(18, "Flag.ico");
            this.imgToolBar.Images.SetKeyName(19, "Folder.ico");
            this.imgToolBar.Images.SetKeyName(20, "Help.ico");
            this.imgToolBar.Images.SetKeyName(21, "ImportFromExcel.ico");
            this.imgToolBar.Images.SetKeyName(22, "InStorage.ico");
            this.imgToolBar.Images.SetKeyName(23, "Last.ico");
            this.imgToolBar.Images.SetKeyName(24, "Lock.ico");
            this.imgToolBar.Images.SetKeyName(25, "Male.ico");
            this.imgToolBar.Images.SetKeyName(26, "Message.ico");
            this.imgToolBar.Images.SetKeyName(27, "Network.ico");
            this.imgToolBar.Images.SetKeyName(28, "Next.ico");
            this.imgToolBar.Images.SetKeyName(29, "OK.ico");
            this.imgToolBar.Images.SetKeyName(30, "OutStorage.ico");
            this.imgToolBar.Images.SetKeyName(31, "Previous.ico");
            this.imgToolBar.Images.SetKeyName(32, "Print.ico");
            this.imgToolBar.Images.SetKeyName(33, "Prohibit.ico");
            this.imgToolBar.Images.SetKeyName(34, "Refresh.ico");
            this.imgToolBar.Images.SetKeyName(35, "Report.ico");
            this.imgToolBar.Images.SetKeyName(36, "Return.ico");
            this.imgToolBar.Images.SetKeyName(37, "Save.ico");
            this.imgToolBar.Images.SetKeyName(38, "SaveGrid.ico");
            this.imgToolBar.Images.SetKeyName(39, "Search.ico");
            this.imgToolBar.Images.SetKeyName(40, "Setting.ico");
            this.imgToolBar.Images.SetKeyName(41, "Shrink.ico");
            this.imgToolBar.Images.SetKeyName(42, "Statistical.ico");
            this.imgToolBar.Images.SetKeyName(43, "Suspend.ico");
            this.imgToolBar.Images.SetKeyName(44, "Tag.ico");
            this.imgToolBar.Images.SetKeyName(45, "Unlock.ico");
            this.imgToolBar.Images.SetKeyName(46, "VehicleKind.ico");
            this.imgToolBar.Images.SetKeyName(47, "View.ico");
            this.imgToolBar.Images.SetKeyName(48, "Warning.ico");
            this.imgToolBar.Images.SetKeyName(49, "ZoomIn.ico");
            // 
            // MenuBar
            // 
            this.MenuBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainMenu,
            this.MainStatuBar});
            this.MenuBar.DockControls.Add(this.barDockControlTop);
            this.MenuBar.DockControls.Add(this.barDockControlBottom);
            this.MenuBar.DockControls.Add(this.barDockControlLeft);
            this.MenuBar.DockControls.Add(this.barDockControlRight);
            this.MenuBar.Form = this;
            this.MenuBar.Images = this.BarImgList;
            this.MenuBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDateInfo,
            this.barVersionInfo,
            this.barUser,
            this.barCompany,
            this.barTools,
            this.barLoadBaseData,
            this.barBase,
            this.barBaseRate,
            this.barSettings,
            this.barCountry});
            this.MenuBar.MainMenu = this.MainMenu;
            this.MenuBar.MaxItemId = 15;
            this.MenuBar.StatusBar = this.MainStatuBar;
            this.MenuBar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuBar_ItemClick);
            // 
            // MainMenu
            // 
            this.MainMenu.BarName = "主菜单";
            this.MainMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MainMenu.DockCol = 0;
            this.MainMenu.DockRow = 0;
            this.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTools),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBase)});
            this.MainMenu.OptionsBar.MultiLine = true;
            this.MainMenu.OptionsBar.UseWholeRow = true;
            this.MainMenu.Text = "主菜单";
            // 
            // barTools
            // 
            this.barTools.Caption = "工具(&T)";
            this.barTools.Id = 7;
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLoadBaseData)});
            this.barTools.Name = "barTools";
            // 
            // barSettings
            // 
            this.barSettings.Caption = "系统设置";
            this.barSettings.Id = 13;
            this.barSettings.Name = "barSettings";
            // 
            // barLoadBaseData
            // 
            this.barLoadBaseData.Caption = "刷新基础数据(&B)";
            this.barLoadBaseData.Id = 9;
            this.barLoadBaseData.Name = "barLoadBaseData";
            // 
            // barBase
            // 
            this.barBase.Caption = "基础档案(&B)";
            this.barBase.Id = 11;
            this.barBase.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBaseRate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCountry)});
            this.barBase.Name = "barBase";
            // 
            // barBaseRate
            // 
            this.barBaseRate.Caption = "汇率档案";
            this.barBaseRate.Id = 12;
            this.barBaseRate.Name = "barBaseRate";
            // 
            // MainStatuBar
            // 
            this.MainStatuBar.BarName = "状态栏";
            this.MainStatuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.MainStatuBar.DockCol = 0;
            this.MainStatuBar.DockRow = 0;
            this.MainStatuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MainStatuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCompany, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.barDateInfo, "", false, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(this.barVersionInfo, true)});
            this.MainStatuBar.OptionsBar.AllowQuickCustomization = false;
            this.MainStatuBar.OptionsBar.DrawDragBorder = false;
            this.MainStatuBar.OptionsBar.UseWholeRow = true;
            this.MainStatuBar.Text = "状态栏";
            // 
            // barUser
            // 
            this.barUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barUser.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barUser.Caption = "当前用户";
            this.barUser.Id = 4;
            this.barUser.Name = "barUser";
            this.barUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barCompany
            // 
            this.barCompany.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barCompany.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCompany.Caption = "操作公司";
            this.barCompany.Id = 5;
            this.barCompany.Name = "barCompany";
            this.barCompany.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDateInfo
            // 
            this.barDateInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barDateInfo.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barDateInfo.Caption = "显示日期";
            this.barDateInfo.Id = 2;
            this.barDateInfo.Name = "barDateInfo";
            this.barDateInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barVersionInfo
            // 
            this.barVersionInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barVersionInfo.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barVersionInfo.Caption = "系统版本号";
            this.barVersionInfo.Id = 3;
            this.barVersionInfo.Name = "barVersionInfo";
            this.barVersionInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1020, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 423);
            this.barDockControlBottom.Size = new System.Drawing.Size(1020, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 399);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1020, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 399);
            // 
            // BarImgList
            // 
            this.BarImgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("BarImgList.ImageStream")));
            // 
            // xtraMdiManager
            // 
            this.xtraMdiManager.MdiParent = this;
            // 
            // showDateTimer
            // 
            this.showDateTimer.Interval = 1000;
            this.showDateTimer.Tick += new System.EventHandler(this.showDateTimer_Tick);
            // 
            // barCountry
            // 
            this.barCountry.Caption = "国家设置";
            this.barCountry.Id = 14;
            this.barCountry.Name = "barCountry";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "客服子系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarImgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraMdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager MenuBar;
        private DevExpress.XtraBars.Bar MainMenu;
        private DevExpress.XtraBars.Bar MainStatuBar;
        private DevExpress.XtraBars.BarStaticItem barDateInfo;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection BarImgList;
        private DevExpress.XtraBars.Alerter.AlertControl messageAlter;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRefreshMenu;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraMdiManager;
        private DevExpress.XtraBars.BarStaticItem barVersionInfo;
        private DevExpress.XtraBars.BarStaticItem barUser;
        private DevExpress.XtraBars.BarStaticItem barCompany;
        private DevExpress.XtraBars.BarSubItem barTools;
        private DevExpress.XtraBars.BarButtonItem barLoadBaseData;
        private System.Windows.Forms.Timer showDateTimer;
        private DevExpress.XtraBars.BarSubItem barBase;
        private DevExpress.XtraBars.BarButtonItem barBaseRate;
        private DevExpress.XtraBars.BarButtonItem barSettings;
        private DevExpress.XtraBars.BarButtonItem barCountry;
    }
}
