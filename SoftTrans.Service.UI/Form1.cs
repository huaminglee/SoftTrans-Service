using CYQ.Data;
using CYQ.Data.Table;
using DevExpress.XtraEditors;
using SoftTrans.Service.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftTrans.Service.Common;
using CYQ.Data.Tool;
using System.ServiceModel;
using SoftTrans.Service.UI.CommonService;
using SoftTrans.Service.Entity.Enum;

namespace SoftTrans.Service.UI
{
    public partial class Form1 : XtraForm
    {

        private MDataTable dtSource = new MDataTable();

        public Form1()
        {
            InitializeComponent();
            pager1.OnPageChanged += pager1_OnPageChanged;


        }

        void pager1_OnPageChanged(object sender, EventArgs e)
        {
            LoadData();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {




            try
            {
                progressPanel1.Visible = true;
                LoadData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                progressPanel1.Visible = false;
            }
        }

        private void LoadData()
        {
            try
            {
                int rowCount;

                using (ChannelFactory<ICommonServiceChannel> channelFactory = new ChannelFactory<ICommonServiceChannel>("BasicHttpBinding_ICommonService"))
                {
                    string result = channelFactory.CreateChannel().SelectPage(out rowCount, TableNames.T_SystemMenus, pager1.PageIndex, pager1.PageSize, string.Empty, null);
                    dtSource = MDataTable.LoadFromJson(result);
                    dtSource.Bind(bindingSource1);
                }
                pager1.DrawControl(rowCount);

                /*
                using (MAction action = new MAction(TableNames.T_SystemMenus))
                {
                    action.SetNoAop();
                    action.SetSelectColumns();
                    dtSource = action.Select(pager1.PageIndex, pager1.PageSize, string.Empty, out rowCount);
                    dtSource.Bind(bindingSource1);
                }
                pager1.DrawControl(rowCount);*/

            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex);
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void pager1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommonVariable.OPERATE_COMPANY = "深圳软通物流";
            CommonVariable.USER_CODE = "刘智权";
            CommonVariable.USER_DEPT = "IT信息部";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            try
            {
                //using (MAction action = new MAction(TableNames.T_SystemMenus))
                //{
                //    action.SetAop(aop);
                //    action.Set(T_SystemMenus.MenuID, Guid.NewGuid());
                //    action.Set(T_SystemMenus.MenuEnabled, false);
                //    action.Set(T_SystemMenus.MenuTag, "wdw");
                //    action.Set(T_SystemMenus.SystemID, "wwdw");
                //    action.Set(T_SystemMenus.MenuCaption, "wdw");
                //    action.Insert(InsertOp.None, "系统表单", string.Format("表单名称='{0}'", action.Data[T_SystemMenus.MenuTag]));
                //}
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex);
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CheckCurrnetIsNull();

            using (MAction action = new MAction(TableNames.T_SystemMenus))
            {
                action.Fill((bindingSource1.Current as MDataRow)["ID"].Value);

                action.SetAutoParentControl(this);
                action.SetAutoPrefix("txt");
                action.Update(true);
            }
        }

        private void CheckCurrnetIsNull()
        {
            if (bindingSource1.Current == null)
            {
                MessageBox.Show("NULL");
                return;
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            CheckCurrnetIsNull();

            //int id = Convert.ToInt32((bindingSource1.Current as MDataRow)["ID"].Value);
            var menuTag = (bindingSource1.Current as MDataRow)["MenuTag"].Value.ToString();


            using (ChannelFactory<ICommonServiceChannel> channelFactory = new ChannelFactory<ICommonServiceChannel>("BasicHttpBinding_ICommonService"))
            {
                bool b = channelFactory.CreateChannel().Delete(TableNames.T_SystemMenus, string.Format("MenuTag='{0}'", menuTag), new string[] { "系统表单", string.Format("表单名称='{0}'", menuTag) });
            }


            //using (MAction action = new MAction(TableNames.T_SystemMenus))
            //{

            //    action.SetAop(aop);
            //    action.Set(T_SystemMenus.MenuTag, menuTag);
            //    action.Delete(string.Format("MenuTag='{0}'", menuTag), "系统表单", string.Format("表单名称='{0}'", action.Data[T_SystemMenus.MenuTag]));
            //    string str = buidData(action.Data);
            //}
        }

        private string buidData(MDataRow dr)
        {
            string condition = string.Empty;
            foreach (var item in dr)
            {
                if (item.Value != null && item.Value.ToString() != string.Empty)
                {
                    condition += string.Format("AND {0} = {1} ", item.ColumnName, item.Value.ToString());
                }
            }
            return condition;
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();





            bool result = false;
            using (ChannelFactory<ICommonServiceChannel> factory = new ChannelFactory<ICommonServiceChannel>("BasicHttpBinding_ICommonService"))
            {
                result = factory.CreateChannel().Update(TableNames.T_SystemMenus, dtSource.ToJson(true, true));
            }
            if (result)
            {
                XtraMessageBox.Show("成功！");
            }


        }


        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("测试用户自定义异常");
            }
            catch (Exception ex)
            {

                FrmErrorHandle.ErrorLogShow(ex);


            }

        }
    }



}
