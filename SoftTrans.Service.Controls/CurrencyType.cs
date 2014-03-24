using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SoftTrans.Service.Controls
{
    public partial class CurrencyType : DevExpress.XtraEditors.XtraUserControl
    {
        public CurrencyType()
        {
            InitializeComponent();
        }

        public string EditValue
        {
            get { return lkpCurrencyType.Text; }
            set { lkpCurrencyType.EditValue = value; }
        }


        public object DataSource
        {
            get { return lkpCurrencyType.Properties.DataSource; }
            set { lkpCurrencyType.Properties.DataSource = value; }
        }

        private void lkpCurrencyType_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lkpCurrencyType.EditValue = string.Empty;
            }
        }
    }
}
