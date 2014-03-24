using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace SoftTrans.Service.UI
{

    class AlertMessage
    {
        private static DevExpress.XtraBars.Alerter.AlertControl messageAlter;

        public AlertMessage()
        {
            messageAlter = new DevExpress.XtraBars.Alerter.AlertControl();
        }
        public static void ShowAlertMessage(Form form, string caption, string text)
        {
            messageAlter.Show(form, caption, text);
        }
    }
}
