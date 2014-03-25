namespace SoftTrans.Service.UI
{
    partial class Frm_HrmCountry
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HrmCountry));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridCountry = new DevExpress.XtraGrid.GridControl();
            this.bdsCountry = new System.Windows.Forms.BindingSource(this.components);
            this.gvCountry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pagerCountry = new SoftTrans.Service.Controls.Pager();
            this.bgSelectCountry = new System.ComponentModel.BackgroundWorker();
            this.barTools = new DevExpress.XtraBars.BarManager(this.components);
            this.MainTools = new DevExpress.XtraBars.Bar();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveGridStyle = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountryDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtCountryName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabMain = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageView = new DevExpress.XtraTab.XtraTabPage();
            this.TabPageEdit = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).BeginInit();
            this.xtraTabMain.SuspendLayout();
            this.TabPageView.SuspendLayout();
            this.TabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1093, 75);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "筛选条件";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridCountry);
            this.groupControl2.Controls.Add(this.pagerCountry);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 75);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1093, 363);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "列表明细";
            // 
            // gridCountry
            // 
            this.gridCountry.DataSource = this.bdsCountry;
            this.gridCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridCountry.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCountry.Location = new System.Drawing.Point(2, 22);
            this.gridCountry.MainView = this.gvCountry;
            this.gridCountry.Name = "gridCountry";
            this.gridCountry.Size = new System.Drawing.Size(1089, 309);
            this.gridCountry.TabIndex = 2;
            this.gridCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCountry});
            this.gridCountry.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCountry_MouseDoubleClick);
            // 
            // bdsCountry
            // 
            this.bdsCountry.DataSource = typeof(SoftTrans.Service.Entity.Hrm_Country);
            // 
            // gvCountry
            // 
            this.gvCountry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCountryName,
            this.colCountryDesc});
            this.gvCountry.GridControl = this.gridCountry;
            this.gvCountry.Name = "gvCountry";
            this.gvCountry.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.Caption = "国家编号";
            this.colID.FieldName = "ID";
            this.colID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "国家名称";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 1;
            // 
            // colCountryDesc
            // 
            this.colCountryDesc.Caption = "备注";
            this.colCountryDesc.FieldName = "CountryDesc";
            this.colCountryDesc.Name = "colCountryDesc";
            this.colCountryDesc.Visible = true;
            this.colCountryDesc.VisibleIndex = 2;
            // 
            // pagerCountry
            // 
            this.pagerCountry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerCountry.JumpText = "Go";
            this.pagerCountry.Location = new System.Drawing.Point(2, 331);
            this.pagerCountry.Name = "pagerCountry";
            this.pagerCountry.PageIndex = 1;
            this.pagerCountry.PageSize = 100;
            this.pagerCountry.RecordCount = 0;
            this.pagerCountry.Size = new System.Drawing.Size(1089, 30);
            this.pagerCountry.TabIndex = 2;
            this.pagerCountry.OnPageChanged += new System.EventHandler(this.pagerCountry_OnPageChanged);
            // 
            // bgSelectCountry
            // 
            this.bgSelectCountry.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSelectCountry_DoWork);
            this.bgSelectCountry.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgSelectCountry_RunWorkerCompleted);
            // 
            // barTools
            // 
            this.barTools.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainTools,
            this.bar3});
            this.barTools.DockControls.Add(this.barDockControlTop);
            this.barTools.DockControls.Add(this.barDockControlBottom);
            this.barTools.DockControls.Add(this.barDockControlLeft);
            this.barTools.DockControls.Add(this.barDockControlRight);
            this.barTools.Form = this;
            this.barTools.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnRemove,
            this.btnRefresh,
            this.btnSaveGridStyle,
            this.btnClose,
            this.btnExport,
            this.btnSelect,
            this.btnSave});
            this.barTools.MainMenu = this.MainTools;
            this.barTools.MaxItemId = 9;
            this.barTools.StatusBar = this.bar3;
            // 
            // MainTools
            // 
            this.MainTools.BarName = "主菜单";
            this.MainTools.DockCol = 0;
            this.MainTools.DockRow = 0;
            this.MainTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSelect, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRemove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExport, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaveGridStyle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.MainTools.OptionsBar.MultiLine = true;
            this.MainTools.OptionsBar.UseWholeRow = true;
            this.MainTools.Text = "主菜单";
            // 
            // btnSelect
            // 
            this.btnSelect.Caption = "查询";
            this.btnSelect.Id = 7;
            this.btnSelect.ImageIndex = 39;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelect_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "新增";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "修改";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageIndex = 35;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Caption = "删除";
            this.btnRemove.Id = 2;
            this.btnRemove.ImageIndex = 6;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemove_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "刷新";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageIndex = 34;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "导出";
            this.btnExport.Id = 6;
            this.btnExport.ImageIndex = 14;
            this.btnExport.Name = "btnExport";
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport_ItemClick);
            // 
            // btnSaveGridStyle
            // 
            this.btnSaveGridStyle.Caption = "保存网格设置";
            this.btnSaveGridStyle.Id = 4;
            this.btnSaveGridStyle.ImageIndex = 38;
            this.btnSaveGridStyle.Name = "btnSaveGridStyle";
            this.btnSaveGridStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveGridStyle_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "退回";
            this.btnClose.Id = 5;
            this.btnClose.ImageIndex = 2;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "状态栏";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "状态栏";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1099, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Size = new System.Drawing.Size(1099, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 467);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1099, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 467);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "备注";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "国家名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "国家编号";
            // 
            // txtCountryDesc
            // 
            this.txtCountryDesc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCountry, "CountryDesc", true));
            this.txtCountryDesc.Location = new System.Drawing.Point(75, 77);
            this.txtCountryDesc.Name = "txtCountryDesc";
            this.txtCountryDesc.Size = new System.Drawing.Size(100, 20);
            this.txtCountryDesc.TabIndex = 0;
            // 
            // txtCountryName
            // 
            this.txtCountryName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCountry, "CountryName", true));
            this.txtCountryName.Location = new System.Drawing.Point(75, 51);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCountry, "ID", true));
            this.txtID.Location = new System.Drawing.Point(75, 25);
            this.txtID.MenuManager = this.barTools;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // xtraTabMain
            // 
            this.xtraTabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabMain.Location = new System.Drawing.Point(0, 24);
            this.xtraTabMain.Name = "xtraTabMain";
            this.xtraTabMain.SelectedTabPage = this.TabPageView;
            this.xtraTabMain.Size = new System.Drawing.Size(1099, 467);
            this.xtraTabMain.TabIndex = 12;
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
            this.TabPageView.Size = new System.Drawing.Size(1093, 438);
            this.TabPageView.Text = "列表";
            // 
            // TabPageEdit
            // 
            this.TabPageEdit.Controls.Add(this.groupControl3);
            this.TabPageEdit.Name = "TabPageEdit";
            this.TabPageEdit.Size = new System.Drawing.Size(1093, 438);
            this.TabPageEdit.Text = "编辑";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtID);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.txtCountryName);
            this.groupControl3.Controls.Add(this.txtCountryDesc);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1093, 438);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "国家编辑";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "保存";
            this.btnSave.Id = 8;
            this.btnSave.ImageIndex = 37;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // Frm_HrmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 514);
            this.Controls.Add(this.xtraTabMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_HrmCountry";
            this.Text = "国家设置";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).EndInit();
            this.xtraTabMain.ResumeLayout(false);
            this.TabPageView.ResumeLayout(false);
            this.TabPageEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridCountry;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCountry;
        private System.ComponentModel.BackgroundWorker bgSelectCountry;
        private Controls.Pager pagerCountry;
        private System.Windows.Forms.BindingSource bdsCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryDesc;
        private DevExpress.XtraBars.BarManager barTools;
        private DevExpress.XtraBars.Bar MainTools;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnRemove;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnSaveGridStyle;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCountryDesc;
        private DevExpress.XtraEditors.TextEdit txtCountryName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraTab.XtraTabControl xtraTabMain;
        private DevExpress.XtraTab.XtraTabPage TabPageView;
        private DevExpress.XtraTab.XtraTabPage TabPageEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.BarButtonItem btnSave;
    }
}