using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftTrans.Service.Controls
{
    public partial class MonthEdit : UserControl
    {
        public MonthEdit()
        {
            InitializeComponent();
            CreateMonth();
        }


        public string EditValue
        {
            get { return cboMonth.Text; }
            set { cboMonth.EditValue = value; }
        }

        private void CreateMonth()
        {
            if (DateTime.Now.Month == 12)
            {
                string year = (DateTime.Now.Year + 1).ToString();
                this.cboMonth.Properties.Items.Add(string.Format("{0}-{1}", year, "02"));
                this.cboMonth.Properties.Items.Add(string.Format("{0}-{1}", year, "01"));
            }

            for (int year = DateTime.Now.Year; year > 2008; year--)
            {
                for (int month = 12; month > 0; month--)
                {
                    this.cboMonth.Properties.Items.Add(string.Format("{0}-{1}", year, month < 10 ? "0" + month.ToString() : month.ToString()));
                }
            }
        }
    }
}
