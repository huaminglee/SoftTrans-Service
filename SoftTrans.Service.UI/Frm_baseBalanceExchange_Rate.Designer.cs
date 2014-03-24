namespace SoftTrans.Service.UI
{
    partial class Frm_baseBalanceExchange_Rate
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
            this.pagerRate = new SoftTrans.Service.Controls.Pager();
            this.gridRate = new DevExpress.XtraGrid.GridControl();
            this.popupGirdRateMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.COPY = new System.Windows.Forms.ToolStripMenuItem();
            this.UPDATE = new System.Windows.Forms.ToolStripMenuItem();
            this.DELETE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.REFRESH = new System.Windows.Forms.ToolStripMenuItem();
            this.EXPORT = new System.Windows.Forms.ToolStripMenuItem();
            this.COPYROW = new System.Windows.Forms.ToolStripMenuItem();
            this.SETCOLUMNS = new System.Windows.Forms.ToolStripMenuItem();
            this.SAVESTYLE = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsRate = new System.Windows.Forms.BindingSource(this.components);
            this.gvRate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipRowInfo = new DevExpress.Utils.ToolTipController(this.components);
            this.grpList = new DevExpress.XtraEditors.GroupControl();
            this.grpCondition = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lupCurrency = new SoftTrans.Service.Controls.CurrencyType();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRecorder = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMonh = new SoftTrans.Service.Controls.MonthEdit();
            this.bgSelectRate = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridRate)).BeginInit();
            this.popupGirdRateMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpList)).BeginInit();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCondition)).BeginInit();
            this.grpCondition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecorder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pagerRate
            // 
            this.pagerRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagerRate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.pagerRate.JumpText = "跳转";
            this.pagerRate.Location = new System.Drawing.Point(0, 336);
            this.pagerRate.Name = "pagerRate";
            this.pagerRate.PageIndex = 1;
            this.pagerRate.PageSize = 50;
            this.pagerRate.RecordCount = 0;
            this.pagerRate.Size = new System.Drawing.Size(1014, 32);
            this.pagerRate.TabIndex = 0;
            this.pagerRate.OnPageChanged += new System.EventHandler(this.pagerRate_OnPageChanged);
            // 
            // gridRate
            // 
            this.gridRate.ContextMenuStrip = this.popupGirdRateMenu;
            this.gridRate.DataSource = this.bdsRate;
            this.gridRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRate.Location = new System.Drawing.Point(2, 22);
            this.gridRate.MainView = this.gvRate;
            this.gridRate.Name = "gridRate";
            this.gridRate.Size = new System.Drawing.Size(1010, 252);
            this.gridRate.TabIndex = 1;
            this.gridRate.ToolTipController = this.tipRowInfo;
            this.gridRate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRate});
            this.gridRate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridRate_MouseDoubleClick);
            // 
            // popupGirdRateMenu
            // 
            this.popupGirdRateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADD,
            this.COPY,
            this.UPDATE,
            this.DELETE,
            this.toolStripSeparator2,
            this.REFRESH,
            this.EXPORT,
            this.COPYROW,
            this.SETCOLUMNS,
            this.SAVESTYLE});
            this.popupGirdRateMenu.Name = "popupGirdRateMenu";
            this.popupGirdRateMenu.Size = new System.Drawing.Size(149, 208);
            this.popupGirdRateMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.popupGirdRateMenu_ItemClicked);
            // 
            // ADD
            // 
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(148, 22);
            this.ADD.Text = "新增";
            // 
            // COPY
            // 
            this.COPY.Name = "COPY";
            this.COPY.Size = new System.Drawing.Size(148, 22);
            this.COPY.Text = "复制";
            // 
            // UPDATE
            // 
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(148, 22);
            this.UPDATE.Text = "修改";
            // 
            // DELETE
            // 
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(148, 22);
            this.DELETE.Text = "删除";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // REFRESH
            // 
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(148, 22);
            this.REFRESH.Text = "刷新";
            // 
            // EXPORT
            // 
            this.EXPORT.Name = "EXPORT";
            this.EXPORT.Size = new System.Drawing.Size(148, 22);
            this.EXPORT.Text = "导出";
            // 
            // COPYROW
            // 
            this.COPYROW.Name = "COPYROW";
            this.COPYROW.Size = new System.Drawing.Size(148, 22);
            this.COPYROW.Text = "复制文本";
            // 
            // SETCOLUMNS
            // 
            this.SETCOLUMNS.Name = "SETCOLUMNS";
            this.SETCOLUMNS.Size = new System.Drawing.Size(148, 22);
            this.SETCOLUMNS.Text = "设置显示列";
            // 
            // SAVESTYLE
            // 
            this.SAVESTYLE.Name = "SAVESTYLE";
            this.SAVESTYLE.Size = new System.Drawing.Size(148, 22);
            this.SAVESTYLE.Text = "保存网格设置";
            // 
            // gvRate
            // 
            this.gvRate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvRate.GridControl = this.gridRate;
            this.gvRate.Name = "gvRate";
            this.gvRate.OptionsView.ColumnAutoWidth = false;
            this.gvRate.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvRate_PopupMenuShowing);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "汇率月份";
            this.gridColumn4.FieldName = "Rate_Date";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "合同币别";
            this.gridColumn1.FieldName = "Contract_Currency";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "结算币别";
            this.gridColumn2.FieldName = "Balance_Currency";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "汇率";
            this.gridColumn3.FieldName = "Exchange_Rate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "录入人";
            this.gridColumn5.FieldName = "Recorder";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "录入日期";
            this.gridColumn6.FieldName = "RecordDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "修改人";
            this.gridColumn7.FieldName = "Modifier";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "修改日期";
            this.gridColumn8.FieldName = "ModifyDate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // tipRowInfo
            // 
            this.tipRowInfo.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.tipRowInfo_GetActiveObjectInfo);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.gridRate);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Location = new System.Drawing.Point(0, 60);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(1014, 276);
            this.grpList.TabIndex = 2;
            this.grpList.Text = "列表明细";
            // 
            // grpCondition
            // 
            this.grpCondition.Controls.Add(this.tableLayoutPanel1);
            this.grpCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCondition.Location = new System.Drawing.Point(0, 0);
            this.grpCondition.Name = "grpCondition";
            this.grpCondition.Size = new System.Drawing.Size(1014, 60);
            this.grpCondition.TabIndex = 3;
            this.grpCondition.Text = "筛选条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lupCurrency, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelect, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRecorder, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMonh, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "币制";
            // 
            // lupCurrency
            // 
            this.lupCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lupCurrency.DataSource = null;
            this.lupCurrency.EditValue = "[请选择币制]";
            this.lupCurrency.Location = new System.Drawing.Point(40, 8);
            this.lupCurrency.Name = "lupCurrency";
            this.lupCurrency.Size = new System.Drawing.Size(150, 20);
            this.lupCurrency.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelect.Location = new System.Drawing.Point(516, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 20);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询(&F)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(196, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "汇率月份";
            // 
            // txtRecorder
            // 
            this.txtRecorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecorder.Location = new System.Drawing.Point(410, 8);
            this.txtRecorder.Name = "txtRecorder";
            this.txtRecorder.Size = new System.Drawing.Size(100, 20);
            this.txtRecorder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "录入人";
            // 
            // cboMonh
            // 
            this.cboMonh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMonh.EditValue = "";
            this.cboMonh.Location = new System.Drawing.Point(250, 6);
            this.cboMonh.Name = "cboMonh";
            this.cboMonh.Size = new System.Drawing.Size(105, 23);
            this.cboMonh.TabIndex = 6;
            // 
            // Frm_baseBalanceExchange_Rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1014, 368);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.pagerRate);
            this.Controls.Add(this.grpCondition);
            this.Name = "Frm_baseBalanceExchange_Rate";
            this.Text = "汇率档案";
            this.Load += new System.EventHandler(this.Frm_baseBalanceExchange_Rate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRate)).EndInit();
            this.popupGirdRateMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpList)).EndInit();
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCondition)).EndInit();
            this.grpCondition.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecorder.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Pager pagerRate;
        private DevExpress.XtraGrid.GridControl gridRate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRate;
        private DevExpress.XtraEditors.GroupControl grpList;
        private DevExpress.XtraEditors.GroupControl grpCondition;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.Utils.ToolTipController tipRowInfo;
        private System.Windows.Forms.ContextMenuStrip popupGirdRateMenu;
        private System.Windows.Forms.ToolStripMenuItem ADD;
        private System.Windows.Forms.ToolStripMenuItem UPDATE;
        private System.Windows.Forms.ToolStripMenuItem DELETE;
        private System.Windows.Forms.ToolStripMenuItem REFRESH;
        private System.Windows.Forms.ToolStripMenuItem EXPORT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem COPYROW;
        private System.Windows.Forms.ToolStripMenuItem SETCOLUMNS;
        private System.Windows.Forms.BindingSource bdsRate;
        private System.Windows.Forms.ToolStripMenuItem COPY;
        private System.Windows.Forms.ToolStripMenuItem SAVESTYLE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker bgSelectRate;
        private System.Windows.Forms.Label label2;
        private Controls.CurrencyType lupCurrency;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRecorder;
        private System.Windows.Forms.Label label1;
        private Controls.MonthEdit cboMonh;
    }
}
