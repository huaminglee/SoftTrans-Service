using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using SoftTrans.Service.Common.UI;
using SoftTrans.Service.Entity;
using SoftTrans.Service.Entity.Enum;
using SoftTrans.Service.UI.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{
    public partial class Frm_HrmProvince : FormBase
    {
        #region 属性变量
        /// <summary>
        /// 当前操作数据源
        /// </summary>
        private List<Hrm_Province> mActiveDataSource = null;
        /// <summary>
        /// 当前选中选项卡
        /// </summary>
        private string mCurrentTabPage = string.Empty;
        /// <summary>
        /// 当前操作类型
        /// </summary>
        private OperateType mOperateType = OperateType.DEFAULT;
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public Frm_HrmProvince()
        {
            InitializeComponent();

            mActiveDataSource = new List<Hrm_Province>();
            this.bdsProvince.DataSource = mActiveDataSource;
            GridViewHelper.SetViewRowNumber(gvProvince);
        }
        #endregion

        #region 后台查询线程
        private void bgSelectProvince_DoWork(object sender, DoWorkEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Loading), true, true);
            SplashScreenManager.Default.SendCommand(Loading.WaitFormCommand.SELECT, null);

            int rowCount;

            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                var obj = proxy.LoadPage_Hrm_Province(out rowCount,
                      pager.PageIndex, pager.PageSize, e.Argument.ToString(), null);

                e.Result = rowCount;
                mActiveDataSource = obj;
            }
        }

        private void bgSelectProvince_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //TODO:查询完成
            pager.DrawControl(Convert.ToInt32(e.Result));
            bdsProvince.DataSource = mActiveDataSource;
            SplashScreenManager.CloseForm();
            SetFormState();
        }
        #endregion
        #region 窗体加载事件
        private void Frm_HrmProvince_Load(object sender, EventArgs e)
        {
            TabChanged();
            SetFormState();
            LoadCountries();
        }
        #endregion
        #region 查询事件
        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bgSelectProvince.IsBusy) return;
            bgSelectProvince.RunWorkerAsync(BuilderQueryCondition());
            
        }
        #endregion
        #region 分页控件事件
        private void pager_OnPageChanged(object sender, EventArgs e)
        {
            if (bgSelectProvince.IsBusy) return;
            bgSelectProvince.RunWorkerAsync(BuilderQueryCondition());
        }
        #endregion
        #region 选项卡切换事件
        private void xtraTabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            TabChanged();
        }
        #endregion
        #region 网格双击跳转编辑选项卡
        private void gridCountry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridHitInfo hInfo = this.gvProvince.CalcHitInfo(new Point(e.X, e.Y));
            if (hInfo.InRow)
            {
                this.xtraTabMain.SelectedTabPage = TabPageEdit;
            }
        }
        #endregion

        #region 新增事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            mOperateType = OperateType.ADD;
            bdsProvince.AddNew();
            (bdsProvince.Current as Hrm_Province).ID = -1;
            SetFormState();
        }
        #endregion
        #region 修改事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mOperateType = OperateType.UPDATE;
            SetFormState();
        }
        #endregion
        #region 删除事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bdsProvince.Current == null) return;
            if (MessageTips.ShowYesOrNo("是否删除选中数据？") != DialogResult.Yes) return;

            bool deleted = false;
            object keyId = (bdsProvince.Current as Hrm_Province).ID;
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                deleted = proxy.Delete_Hrm_Province(keyId);
            }

            if (deleted)
            {
                bdsProvince.RemoveCurrent();
                bdsProvince.EndEdit();
                MessageTips.ShowTips("删除成功.");
            }

        }
        #endregion
        #region 保存事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                bdsProvince.EndEdit();

                switch (mOperateType)
                {
                    case OperateType.ADD:
                        SaveAdd();
                        break;
                    case OperateType.UPDATE:
                        SaveUpdate();
                        break;
                }

                mOperateType = OperateType.VIEW;
                SetFormState();
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
            finally
            {
                Cursor.Current = Cursors.WaitCursor;
            }

        }

        #endregion
        #region 取消事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mOperateType = OperateType.DEFAULT;
            bdsProvince.CancelEdit();
            SetFormState();
        }
        #endregion
        #region 关闭事件
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 自定义方法
        /// <summary>
        /// 拼接查询条件
        /// </summary>
        /// <returns></returns>
        private string BuilderQueryCondition()
        {
            return string.Empty; ;
        }
        /// <summary>
        /// 设置编辑控件可用性
        /// </summary>
        private void SetControlReadOnly(bool canDo)
        {
            gridProvince.Enabled = canDo;
            lupCountryId.Enabled = !canDo;
            txtProvinceName.Properties.ReadOnly = canDo;
            txtProvinceDesc.Properties.ReadOnly = canDo;
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
        /// <summary>
        /// 设置操作按钮可用状态
        /// </summary>
        private void SetFormState()
        {
            bool readOnly = false;

            switch (mOperateType)
            {
                case OperateType.ADD:
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    readOnly = false;
                    break;
                case OperateType.UPDATE:
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    readOnly = false;
                    break;
                case OperateType.VIEW:
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    readOnly = true;
                    break;
                default:
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = false;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                    if (bdsProvince.Current == null)
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    readOnly = true;
                    break;
            }
            SetControlReadOnly(readOnly);

        }
        /// <summary>
        /// 新增保存
        /// </summary>
        private void SaveAdd()
        {
            Hrm_Province current = (bdsProvince.Current as Hrm_Province);
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                current = proxy.Insert_Hrm_Province(current);
                (bdsProvince.Current as Hrm_Province).ID = current.ID;
                bdsProvince.ResetBindings(false);
            }
            MessageTips.ShowTips("添加成功.");
        }
        /// <summary>
        /// 修改保存
        /// </summary>
        private void SaveUpdate()
        {
            Hrm_Province current = (bdsProvince.Current as Hrm_Province);
            bool updated = false;
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                updated = proxy.Update_Hrm_Province(current);
            }
            MessageTips.ShowTips("修改成功.");
        }
        /// <summary>
        /// 加载国家列表
        /// </summary>
        private void LoadCountries()
        {
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                this.lupCountryId.Properties.DataSource = proxy.Load_Hrm_Country(null);
                this.lupCountryId.Properties.DisplayMember = "CountryName";
                this.lupCountryId.Properties.ValueMember = "ID";
            }
        }
        #endregion
    }
}