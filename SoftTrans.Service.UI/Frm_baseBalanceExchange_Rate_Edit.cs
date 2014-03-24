using CYQ.Data;
using CYQ.Data.Table;
using SoftTrans.Service.Common;
using SoftTrans.Service.Common.UI;
using SoftTrans.Service.Entity;
using SoftTrans.Service.Entity.Enum;
using SoftTrans.Service.UI.CommonService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{
    public partial class Frm_baseBalanceExchange_Rate_Edit : FormBase
    {
        private OperateType _OperateType;
        private object _Key;

        public Frm_baseBalanceExchange_Rate_Edit()
        {
            InitializeComponent();
        }

        public Frm_baseBalanceExchange_Rate_Edit(OperateType opType, object key)
        {
            _OperateType = opType;
            _Key = key;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Frm_baseBalanceExchange_Rate_Edit_Load(object sender, EventArgs e)
        {

            if (_OperateType != OperateType.ADD)
            {
                string json = string.Empty;
                using (ChannelFactory<ICommonServiceChannel> channelFactory = new ChannelFactory<ICommonServiceChannel>("BasicHttpBinding_ICommonService"))
                {
                    ICommonServiceChannel chanel = channelFactory.CreateChannel();
                    json = chanel.Fill(TableNames.T_baseBalanceExchange_Rate, String.Format("RowID={0}", _Key));
                }
            }

            btnSave.Enabled = _OperateType != UI.OperateType.VIEW;
        }



    }
}
