namespace SoftTrans.Service.UI
{
    partial class Frm_HrmCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HrmCity));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.bdsCity = new System.Windows.Forms.BindingSource(this.components);
            this.bgSelectCity = new System.ComponentModel.BackgroundWorker();
            this.barTools = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabMain = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageView = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridCity = new DevExpress.XtraGrid.GridControl();
            this.gvCity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcityname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvinceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pager = new SoftTrans.Service.Controls.Pager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TabPageEdit = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lupProvinceId = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcityname = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).BeginInit();
            this.xtraTabMain.SuspendLayout();
            this.TabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.TabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupProvinceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcityname.Properties)).BeginInit();
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
            // bdsCity
            // 
            this.bdsCity.DataSource = typeof(SoftTrans.Service.Entity.Hrm_City);
            // 
            // bgSelectCity
            // 
            this.bgSelectCity.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSelectCity_DoWork);
            this.bgSelectCity.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgSelectCity_RunWorkerCompleted);
            // 
            // barTools
            // 
            this.barTools.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barTools.DockControls.Add(this.barDockControlTop);
            this.barTools.DockControls.Add(this.barDockControlBottom);
            this.barTools.DockControls.Add(this.barDockControlLeft);
            this.barTools.DockControls.Add(this.barDockControlRight);
            this.barTools.Form = this;
            this.barTools.Images = this.imgToolBar;
            this.barTools.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnClose,
            this.btnSelect});
            this.barTools.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "自定义3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSelect, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "自定义3";
            // 
            // btnSelect
            // 
            this.btnSelect.Caption = "查询";
            this.btnSelect.Id = 7;
            this.btnSelect.ImageIndex = 39;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelect_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "退回";
            this.btnClose.Id = 5;
            this.btnClose.ImageIndex = 2;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(730, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
            this.barDockControlBottom.Size = new System.Drawing.Size(730, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(730, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // xtraTabMain
            // 
            this.xtraTabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabMain.Location = new System.Drawing.Point(0, 31);
            this.xtraTabMain.Name = "xtraTabMain";
            this.xtraTabMain.SelectedTabPage = this.TabPageView;
            this.xtraTabMain.Size = new System.Drawing.Size(730, 480);
            this.xtraTabMain.TabIndex = 14;
            this.xtraTabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageView,
            this.TabPageEdit});
            this.xtraTabMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabMain_SelectedPageChanged);
            // 
            // TabPageView
            // 
            this.TabPageView.Controls.Add(this.groupControl2);
            this.TabPageView.Controls.Add(this.groupControl1);
            this.TabPageView.Name = "TabPageView";
            this.TabPageView.Size = new System.Drawing.Size(724, 451);
            this.TabPageView.Text = "列表";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridCity);
            this.groupControl2.Controls.Add(this.pager);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(724, 382);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "列表明细";
            // 
            // gridCity
            // 
            this.gridCity.DataSource = this.bdsCity;
            this.gridCity.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridCity.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCity.Location = new System.Drawing.Point(2, 22);
            this.gridCity.MainView = this.gvCity;
            this.gridCity.Name = "gridCity";
            this.gridCity.Size = new System.Drawing.Size(720, 327);
            this.gridCity.TabIndex = 2;
            this.gridCity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCity});
            this.gridCity.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCity_MouseDoubleClick);
            // 
            // gvCity
            // 
            this.gvCity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcityname,
            this.colProvinceId,
            this.colCountryId});
            this.gvCity.GridControl = this.gridCity;
            this.gvCity.Name = "gvCity";
            this.gvCity.OptionsView.ColumnAutoWidth = false;
            this.gvCity.OptionsView.ShowGroupPanel = false;
            // 
            // colcityname
            // 
            this.colcityname.Caption = "城市名称";
            this.colcityname.FieldName = "cityname";
            this.colcityname.Name = "colcityname";
            this.colcityname.Visible = true;
            this.colcityname.VisibleIndex = 0;
            // 
            // colProvinceId
            // 
            this.colProvinceId.Caption = "省份编号";
            this.colProvinceId.FieldName = "ProvinceId";
            this.colProvinceId.Name = "colProvinceId";
            this.colProvinceId.Visible = true;
            this.colProvinceId.VisibleIndex = 1;
            // 
            // colCountryId
            // 
            this.colCountryId.Caption = "国家编号";
            this.colCountryId.FieldName = "CountryId";
            this.colCountryId.Name = "colCountryId";
            this.colCountryId.Visible = true;
            this.colCountryId.VisibleIndex = 2;
            // 
            // pager
            // 
            this.pager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager.JumpText = "Go";
            this.pager.Location = new System.Drawing.Point(2, 349);
            this.pager.Name = "pager";
            this.pager.PageIndex = 1;
            this.pager.PageSize = 100;
            this.pager.RecordCount = 0;
            this.pager.Size = new System.Drawing.Size(720, 31);
            this.pager.TabIndex = 2;
            this.pager.OnPageChanged += new System.EventHandler(this.pager_OnPageChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(724, 69);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "筛选条件";
            // 
            // TabPageEdit
            // 
            this.TabPageEdit.Controls.Add(this.groupControl3);
            this.TabPageEdit.Name = "TabPageEdit";
            this.TabPageEdit.Size = new System.Drawing.Size(724, 451);
            this.TabPageEdit.Text = "编辑";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lupProvinceId);
            this.groupControl3.Controls.Add(this.btnCancel);
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnUpdate);
            this.groupControl3.Controls.Add(this.btnAdd);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.txtcityname);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(724, 451);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "国家编辑";
            // 
            // lupProvinceId
            // 
            this.lupProvinceId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCity, "ProvinceId", true));
            this.lupProvinceId.Location = new System.Drawing.Point(75, 28);
            this.lupProvinceId.MenuManager = this.barTools;
            this.lupProvinceId.Name = "lupProvinceId";
            this.lupProvinceId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupProvinceId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProvinceName", "省份列表")});
            this.lupProvinceId.Properties.NullText = "[请选择所属国别]";
            this.lupProvinceId.Size = new System.Drawing.Size(399, 20);
            this.lupProvinceId.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消(&Z)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(318, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(237, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增(&N)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "城市名称";
            // 
            // txtcityname
            // 
            this.txtcityname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCity, "cityname", true));
            this.txtcityname.Location = new System.Drawing.Point(75, 54);
            this.txtcityname.Name = "txtcityname";
            this.txtcityname.Size = new System.Drawing.Size(399, 20);
            this.txtcityname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "所属省份";
            // 
            // Frm_HrmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 511);
            this.Controls.Add(this.xtraTabMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_HrmCity";
            this.Text = "城市设置";
            this.Load += new System.EventHandler(this.Frm_HrmCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).EndInit();
            this.xtraTabMain.ResumeLayout(false);
            this.TabPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.TabPageEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupProvinceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcityname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsCity;
        private System.ComponentModel.BackgroundWorker bgSelectCity;
        private DevExpress.XtraBars.BarManager barTools;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTab.XtraTabControl xtraTabMain;
        private DevExpress.XtraTab.XtraTabPage TabPageView;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridCity;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCity;
        private Controls.Pager pager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabPage TabPageEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LookUpEdit lupProvinceId;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtcityname;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colcityname;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceId;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryId;
    }
}