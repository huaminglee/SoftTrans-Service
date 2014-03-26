﻿using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class Frm_HrmCity : FormBase
    {
        #region 属性变量
        /// <summary>
        /// 当前操作数据源
        /// </summary>
        private List<Hrm_City> mActiveDataSource = null;
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
        public Frm_HrmCity()
        {
            InitializeComponent();

            mActiveDataSource = new List<Hrm_City>();
            this.bdsCity.DataSource = mActiveDataSource;
            GridViewHelper.SetViewRowNumber(gvCity);
        }
        #endregion

        #region 后台查询线程
        private void bgSelectCity_DoWork(object sender, DoWorkEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(Loading), true, true);
            SplashScreenManager.Default.SendCommand(Loading.WaitFormCommand.SELECT, null);

            int rowCount;

            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                var obj = proxy.LoadPage_Hrm_City(out rowCount,
                      pager.PageIndex, pager.PageSize, e.Argument.ToString(), null);

                e.Result = rowCount;
                mActiveDataSource = obj;
            }
        }

        private void bgSelectCity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //TODO:查询完成
            pager.DrawControl(Convert.ToInt32(e.Result));
            bdsCity.DataSource = mActiveDataSource;
            SplashScreenManager.CloseForm();
            SetFormState();
        }
        #endregion
        #region 窗体加载事件
        private void Frm_HrmCity_Load(object sender, EventArgs e)
        {
            TabChanged();
            SetFormState();
            LoadProvince();
        }
        #endregion
        #region 查询事件
        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bgSelectCity.IsBusy) return;
            bgSelectCity.RunWorkerAsync(BuilderQueryCondition());
        }
        #endregion
        #region 分页控件事件
        private void pager_OnPageChanged(object sender, EventArgs e)
        {
            if (bgSelectCity.IsBusy) return;
            bgSelectCity.RunWorkerAsync(BuilderQueryCondition());
        }
        #endregion
        #region 选项卡切换事件
        private void xtraTabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            TabChanged();
        }
        #endregion
        #region 网格双击跳转编辑选项卡
        private void gridCity_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GridHitInfo hInfo = this.gvCity.CalcHitInfo(new Point(e.X, e.Y));
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
            bdsCity.AddNew();
            (bdsCity.Current as Hrm_City).ID = -1;
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
            if (bdsCity.Current == null) return;
            if (MessageTips.ShowYesOrNo("是否删除选中数据？") != DialogResult.Yes) return;

            bool deleted = false;
            object keyId = (bdsCity.Current as Hrm_City).ID;
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                deleted = proxy.Delete_Hrm_City(keyId);
            }

            if (deleted)
            {
                bdsCity.RemoveCurrent();
                bdsCity.EndEdit();
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
                bdsCity.EndEdit();

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
            bdsCity.CancelEdit();
            bdsCity.ResetCurrentItem();
            bdsCity.ResetBindings(false);
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
            gridCity.Enabled = canDo;
            lupProvinceId.Enabled = !canDo;
            txtcityname.Properties.ReadOnly = canDo;
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
                    if (bdsCity.Current == null)
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
            Hrm_City current = (bdsCity.Current as Hrm_City);
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                current = proxy.Insert_Hrm_City(current);
                (bdsCity.Current as Hrm_City).ID = current.ID;
                (bdsCity.Current as Hrm_City).CountryId = current.CountryId;
                bdsCity.ResetBindings(false);
            }
            MessageTips.ShowTips("添加成功.");
        }
        /// <summary>
        /// 修改保存
        /// </summary>
        private void SaveUpdate()
        {
            Hrm_City current = (bdsCity.Current as Hrm_City);
            bool updated = false;
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                updated = proxy.Update_Hrm_City(current);
            }
            MessageTips.ShowTips("修改成功.");
        }
        /// <summary>
        /// 加载省份列表
        /// </summary>
        private void LoadProvince()
        {
            using (BaseFileProxy proxy = new BaseFileProxy())
            {
                this.lupProvinceId.Properties.DataSource = proxy.Load_Hrm_Province(null);
                this.lupProvinceId.Properties.DisplayMember = "ProvinceName";
                this.lupProvinceId.Properties.ValueMember = "ID";
            }
        }
        #endregion



    }
}