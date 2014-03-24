using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoftTrans.Service.Common.UI;
using DevExpress.XtraSplashScreen;
using SoftTrans.Service.Entity.Enum;
using SoftTrans.Service.UI.Proxy;
using SoftTrans.Service.Entity;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SoftTrans.Service.UI
{
    public partial class Frm_HrmCountry : FormBase
    {
        private List<Hrm_Country> ActiveDataSource = null;
        private string mCurrentTabPage = string.Empty;

        public Frm_HrmCountry()
        {
            InitializeComponent();
            ActiveDataSource = new List<Hrm_Country>();
            this.bdsCountry.DataSource = ActiveDataSource;
        }


        private string BuilderQueryCondition()
        {
            return string.Empty; ;
        }

        private void bgSelectCountry_DoWork(object sender, DoWorkEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Loading), true, true);
            SplashScreenManager.Default.SendCommand(Loading.WaitFormCommand.SELECT, null);

            int rowCount;

            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                var obj = proxy.LoadPage_Hrm_Country(out rowCount,
                      pagerCountry.PageIndex, pagerCountry.PageSize, e.Argument.ToString(), null);

                e.Result = rowCount;
                ActiveDataSource = obj;
            }
        }

        private void bgSelectCountry_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //TODO:查询完成
            pagerCountry.DrawControl(Convert.ToInt32(e.Result));
            bdsCountry.DataSource = ActiveDataSource;
            SplashScreenManager.CloseForm();
        }


        private void pagerCountry_OnPageChanged(object sender, EventArgs e)
        {
            if (bgSelectCountry.IsBusy) return;
            bgSelectCountry.RunWorkerAsync(BuilderQueryCondition());
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bgSelectCountry.IsBusy) return;
            bgSelectCountry.RunWorkerAsync(BuilderQueryCondition());
        }

        private void gridCountry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridHitInfo hInfo = this.gvCountry.CalcHitInfo(new Point(e.X, e.Y));
            if (hInfo.InRow)
            {
                this.xtraTabMain.SelectedTabPage = TabPageEdit;
            }
        }

        /// <summary>
        /// 设置编辑控件可用性
        /// </summary>
        private void SetEditControlEnable(bool canDo)
        {
            gridCountry.Enabled = !canDo;
            txtID.Properties.ReadOnly = !canDo;
            txtCountryName.Properties.ReadOnly = !canDo;
            txtCountryDesc.Properties.ReadOnly = !canDo;
        }

        private void xtraTabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            TabChanged();
        }
        /// <summary>
        /// Tab改变事件
        /// </summary>
        private void TabChanged()
        {
            //得到当前操作Tab
            this.mCurrentTabPage = xtraTabMain.SelectedTabPage.Name;

            switch (this.mCurrentTabPage)
            {
                case "TabPageView":
                    this.btnSelect.Enabled = true;
                    break;
                case "TabPageEdit":
                    this.btnSelect.Enabled = false;
                    break;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCountry.AddNew();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCountry.Current == null) return;
            bool deleted = false;
            object keyId = (bdsCountry.Current as Hrm_Country).ID;
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                deleted = proxy.Delete_Hrm_Country(keyId);
            }

            if (deleted)
            {
                bdsCountry.RemoveCurrent();
                bdsCountry.EndEdit();
                MessageTips.ShowTips("删除成功.");
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSaveGridStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCountry.EndEdit();
            Hrm_Country current = (bdsCountry.Current as Hrm_Country);
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                current = proxy.Insert_Hrm_Country(current);
            }
        }
    }
}