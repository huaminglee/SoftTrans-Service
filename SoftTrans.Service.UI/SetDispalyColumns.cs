using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoftTrans.Service.UI;

namespace SoftTrans.Service.Common.UI
{
    public partial class SetDispalyColumns : FormBase
    {
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private Dictionary<string, string> columns;

        public SetDispalyColumns(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            InitializeComponent();
            this.columns = new Dictionary<string, string>();
            this.gridView = gridView;
        }

        private void BuildColumnsList()
        {
            columns.Clear();
            chkColumnsList.Items.Clear();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].FieldName == string.Empty) continue;

                chkColumnsList.Items.Add(gridView.Columns[i].Caption, gridView.Columns[i].Visible);
                columns.Add(gridView.Columns[i].Caption, gridView.Columns[i].FieldName);
            }
        }

        private void SetDispalyColumns_Load(object sender, EventArgs e)
        {
            try
            {
                BuildColumnsList();
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }



        private void btnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < chkColumnsList.ItemCount; i++)
                {
                    chkColumnsList.Items[i].CheckState = CheckState.Checked;
                }
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }

        private void btnReSelect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < chkColumnsList.ItemCount; i++)
                {
                    chkColumnsList.Items[i].CheckState = chkColumnsList.Items[i].CheckState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked;
                }
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            gridView.ExportToXls(@"D:\1.xls");
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < chkColumnsList.ItemCount; i++)
                {
                    chkColumnsList.Items[i].CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                FrmErrorHandle.ErrorLogShow(ex);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkColumnsList.ItemCount; i++)
            {
                gridView.Columns[columns[chkColumnsList.Items[i].ToString()]].Visible = chkColumnsList.Items[i].CheckState == CheckState.Checked ? true : false;
            }
        }
    }
}