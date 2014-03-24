using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using SoftTrans.Service.Common;
using SoftTrans.Service.Common.UI;

namespace SoftTrans.Service.UI
{
    public partial class Settings : FormBase
    {
        public Settings()
        {
            InitializeComponent();
            InitSkins();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //TODO:读取用户配置
            AUTO_BEST_FITCOLUMNS.Checked = CommonVariable.AUTO_BEST_FITCOLUMNS;
            AUTO_OPEN_FILE.Checked = CommonVariable.AUTO_OPEN_FILE;
            SEND_ERROR.Checked = CommonVariable.AUTO_OPEN_FILE;
            WRITE_LOG.Checked = CommonVariable.WRITE_LOG;
            SKIN_NAME.EditValue = CommonVariable.SKIN_NAME;
            PAGE_SIZE.EditValue = CommonVariable.PAGE_SIZE;
        }


        private void InitSkins()
        {
            foreach (SkinContainer item in SkinManager.Default.Skins)
            {
                SKIN_NAME.Properties.Items.Add(item.SkinName);
            }
            // DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = SKIN_NAME.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {





            //TODO:写入配置
            CommonVariable.AUTO_BEST_FITCOLUMNS = AUTO_BEST_FITCOLUMNS.Checked;
            CommonVariable.AUTO_OPEN_FILE = AUTO_OPEN_FILE.Checked;
            CommonVariable.SEND_ERROR = SEND_ERROR.Checked;
            CommonVariable.WRITE_LOG = WRITE_LOG.Checked;
            CommonVariable.SKIN_NAME = SKIN_NAME.Text;
            CommonVariable.PAGE_SIZE = Convert.ToInt32(PAGE_SIZE.Text);

            InitUserConfig.SetValue("AUTO_BEST_FITCOLUMNS", AUTO_BEST_FITCOLUMNS.Checked.ToString());
            InitUserConfig.SetValue("AUTO_OPEN_FILE", AUTO_OPEN_FILE.Checked.ToString());
            InitUserConfig.SetValue("SEND_ERROR", SEND_ERROR.Checked.ToString());
            InitUserConfig.SetValue("WRITE_LOG", WRITE_LOG.Checked.ToString());
            InitUserConfig.SetValue("SKIN_NAME", SKIN_NAME.Text);
            InitUserConfig.SetValue("PAGE_SIZE", PAGE_SIZE.Text);
        }
    }
}