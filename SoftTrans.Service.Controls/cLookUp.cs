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
    public partial class cLookUp : DevExpress.XtraEditors.LookUpEdit, CYQ.Data.Extension.IUIValue
    {
        public cLookUp()
        {
            InitializeComponent();
        }

        public bool MEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string MID
        {
            get { throw new NotImplementedException(); }
        }

        public object MValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
