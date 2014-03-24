using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftTrans.Service.Common.UI
{
    public class GridViewHelper
    {
        private static string FloderName = Application.StartupPath + "\\GridViewStyle";

        public static void SaveViewStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            string fullPath = System.IO.Path.Combine(FloderName,
                string.Format("{0}.{1}.xml", gridView.GridControl.FindForm().GetType().FullName, gridView.Name));

            if (!System.IO.Directory.Exists(FloderName))
            {
                System.IO.Directory.CreateDirectory(FloderName);
            }
            gridView.SaveLayoutToXml(fullPath);
            MessageTips.ShowTips("网格设置成功.");

        }

        public static void InitViewStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            Form parentForm = gridView.GridControl.FindForm();
            string fullPath = System.IO.Path.Combine(FloderName, string.Format("{0}.{1}.xml", parentForm.GetType().FullName, gridView.Name));

            if (!System.IO.File.Exists(fullPath)) return;
            gridView.RestoreLayoutFromXml(fullPath);

        }

        public static void ExportView(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fileName)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "导出Excel (*.xls)|*.xls";
                dialog.FileName = fileName + ".xls";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    gridView.ExportToXls(dialog.FileName);
                }
            }

        }


        public static void SetViewRowNumber(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.IndicatorWidth = 45;
            gridView.CustomDrawRowIndicator += gridView_CustomDrawRowIndicator;

        }

        private static void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        public static void SetViewReadOnly(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.OptionsBehavior.Editable = true;
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.ReadOnly = true;
            }
        }
    }
}
