using CYQ.Data.Table;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using SoftTrans.Service.Common.UI;
using SoftTrans.Service.Entity.Enum;
using SoftTrans.Service.UI.Proxy;
using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{
    public partial class Frm_baseBalanceExchange_Rate : FormBase
    {

        private MDataTable M_DataSource;

        public Frm_baseBalanceExchange_Rate()
        {
            InitializeComponent();
            M_DataSource = new MDataTable();

            this.bgSelectRate.DoWork += new DoWorkEventHandler(bgSelectRate_DoWork);
            this.bgSelectRate.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgSelectRate_RunWorkerCompleted);
            this.pagerRate.PageSize = Common.CommonVariable.PAGE_SIZE;

        }

        #region 后台操作
        private void bgSelectRate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //TODO:查询完成
            M_DataSource.Bind(bdsRate);
            pagerRate.DrawControl(M_DataSource.RecordsAffected);
            SplashScreenManager.CloseForm();

        }

        private void bgSelectRate_DoWork(object sender, DoWorkEventArgs e)
        {

            SplashScreenManager.ShowForm(this, typeof(Loading), true, true);
            SplashScreenManager.Default.SendCommand(Loading.WaitFormCommand.SELECT, null);

            int rowCount;

            using (CommonProxy proxy = new CommonProxy())
            {
                string result = proxy.SelectPage(out rowCount, TableNames.T_baseBalanceExchange_Rate,
                    pagerRate.PageIndex, pagerRate.PageSize, e.Argument.ToString(), null);
                M_DataSource = MDataTable.LoadFromJson(result);
            }

            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                var obj = proxy.LoadPageEntities(out rowCount,
                      pagerRate.PageIndex, pagerRate.PageSize, e.Argument.ToString(), null);
            }
        }

        #endregion


        private void tipRowInfo_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != gridRate) return;

            ToolTipControlInfo info = null;
            //Get the view at the current mouse position
            GridView view = gridRate.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;

            //Get the view's element information that resides at the current position
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            //Display a hint for row indicator cells
            if (hi.HitTest == GridHitTest.RowIndicator)
            {
                //An object that uniquely identifies a row indicator cell
                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("行数据基本信息：");
                foreach (GridColumn gridCol in view.Columns)
                {
                    if (gridCol.Visible)
                    {
                        sb.AppendFormat("    {0}：{1}\r\n", gridCol.Caption, view.GetRowCellDisplayText(hi.RowHandle, gridCol.FieldName));
                    }
                }
                info = new ToolTipControlInfo(o, sb.ToString());
            }

            //Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
            if (info != null)
            {
                e.Info = info;
            }
        }

        private void Frm_baseBalanceExchange_Rate_Load(object sender, EventArgs e)
        {
            //GridViewHelper.SetViewRowNumber(gvRate);
            //GridViewHelper.SetViewReadOnly(gvRate);
            //GridViewHelper.InitViewStyle(gvRate);


            //lupCurrency.DataSource = MDataTable.LoadFromJson(InitBaesData.GetCache(TableNames.T_baseBalance_CurrencyType).ToString()).ToDataTable();

        }

        private void gvRate_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType != GridMenuType.Column) return;

            e.Menu.Items.Add(AddFixCellMenuItem(e.HitInfo.Column.FieldName));
        }

        private DXMenuItem AddFixCellMenuItem(string fieldName)
        {
            DXMenuItem fixItem = new DXMenuItem("冻结选中列", new EventHandler(OnFixCellClick), null);
            fixItem.Tag = fieldName;
            return fixItem;
        }

        private void OnFixCellClick(object sender, EventArgs e)
        {
            if (gvRate.Columns[(sender as DXMenuItem).Tag.ToString()].Fixed == FixedStyle.Left)
            {
                gvRate.Columns[(sender as DXMenuItem).Tag.ToString()].Fixed = FixedStyle.None;
                return;
            }
            gvRate.Columns[(sender as DXMenuItem).Tag.ToString()].Fixed = FixedStyle.Left;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gridMenuItems1_OnAddClick(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void pagerRate_OnPageChanged(object sender, EventArgs e)
        {
            if (bgSelectRate.IsBusy) return;
            bgSelectRate.RunWorkerAsync(BuilderQueryCondition());
        }

        private void popupGirdRateMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "ADD":
                        OnAdd();
                        break;
                    case "COPY":
                        OnCopy();
                        break;
                    case "UPDATE":
                        OnUpdate();
                        break;
                    case "DELETE":
                        OnDelete();
                        break;
                    case "REFRESH":
                        OnSelect();
                        break;
                    case "EXPORT":
                        Common.UI.GridViewHelper.ExportView(gvRate, this.Text);
                        break;
                    case "COPYROW":
                        break;
                    case "SETCOLUMNS":
                        new Common.UI.SetDispalyColumns(gvRate).ShowDialog();
                        break;
                    case "SAVESTYLE":
                        Common.UI.GridViewHelper.SaveViewStyle(gvRate);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }




        private void OnDelete()
        {
            if (gvRate.SelectedRowsCount < 1) return;
            var id = gvRate.GetRowCellValue(gvRate.FocusedRowHandle, "RowID");
            new Frm_baseBalanceExchange_Rate_Edit(OperateType.REMOVE, id).ShowDialog();
        }

        private void OnUpdate()
        {
            if (gvRate.SelectedRowsCount < 1) return;

            var id = gvRate.GetRowCellValue(gvRate.FocusedRowHandle, "RowID");
            new Frm_baseBalanceExchange_Rate_Edit(OperateType.UPDATE, id).ShowDialog();
        }

        private void OnCopy()
        {
            if (gvRate.SelectedRowsCount < 1) return;

            var id = gvRate.GetRowCellValue(gvRate.FocusedRowHandle, "RowID");
            new Frm_baseBalanceExchange_Rate_Edit(OperateType.COPY, id).ShowDialog();
        }

        private void OnAdd()
        {
            new Frm_baseBalanceExchange_Rate_Edit().ShowDialog();
        }

        private void OnSelect()
        {
            if (bgSelectRate.IsBusy) return;
            bgSelectRate.RunWorkerAsync(BuilderQueryCondition());
        }







        private void btnSelect_Click(object sender, EventArgs e)
        {
            OnSelect();
        }



        private string BuilderQueryCondition()
        {
            var condition = new StringBuilder();
            if (txtRecorder.Text.Length > 0)
            {
                condition.Append(string.Format("[Recorder] LIKE '%{0}%'", txtRecorder.Text));
            }

            return condition.ToString();
        }

        private void gridRate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridHitInfo hit = gvRate.CalcHitInfo(e.X, e.Y);
            if (hit.InRow)
            {
                View(gvRate.GetRowCellValue(hit.RowHandle, "RowID"));
            }
        }

        private void View(object id)
        {
            new Frm_baseBalanceExchange_Rate_Edit(OperateType.VIEW, id).ShowDialog();
        }


    }
}
