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
    public partial class GridMenuItems : System.Windows.Forms.ContextMenuStrip
    {

        public delegate void OnAdd(object sender, EventArgs e);
        public event OnAdd OnAddClick;


        public delegate void OnUpdate(object sender, EventArgs e);
        public event OnUpdate OnUpdateClick;

        public delegate void OnDelete(object sender, EventArgs e);
        public event OnDelete OnDeleteClick;



        public GridMenuItems()
        {
            InitializeComponent();
            CreateMenuItems();
        }

        [Category("菜单项"), Description("显示新增")]
        public bool ShowAddMenu
        {
            get { return this.Items["ADD"].Visible; }
            set { this.Items["ADD"].Visible = value; }

        }
        [Category("菜单项"), Description("显示更新")]
        public bool ShowUpdateMenu
        {
            get { return this.Items["UPDATE"].Visible; }
            set { this.Items["UPDATE"].Visible = value; }
        }
        [Category("菜单项"), Description("显示删除")]
        public bool ShowDeleteMenu
        {
            get { return this.Items["DELETE"].Visible; }
            set { this.Items["DELETE"].Visible = value; }
        }

        [Category("菜单项"), Description("显示复制")]
        public bool ShowCopyMenu
        {
            get { return this.Items["COPY"].Visible; }
            set { this.Items["COPY"].Visible = value; }
        }
        [Category("菜单项"), Description("显示审核")]
        public bool ShowAuditMenu
        {
            get { return this.Items["AUDIT"].Visible; }
            set { this.Items["AUDIT"].Visible = value; }
        }
        [Category("菜单项"), Description("显示反审")]
        public bool ShowUnAuditMenu
        {
            get { return this.Items["UNAUDIT"].Visible; }
            set { this.Items["UNAUDIT"].Visible = value; }
        }
        [Category("菜单项"), Description("显示刷新")]
        public bool ShowRefreshMenu
        {
            get { return this.Items["REFRESH"].Visible; }
            set { this.Items["REFRESH"].Visible = value; }
        }
        [Category("菜单项"), Description("显示导出")]
        public bool ShowExportMenu
        {
            get { return this.Items["EXPORT"].Visible; }
            set { this.Items["EXPORT"].Visible = value; }
        }
        [Category("菜单项"), Description("显示复制数据")]
        public bool ShowCopyRowMenu
        {
            get { return this.Items["COPYROW"].Visible; }
            set { this.Items["COPYROW"].Visible = value; }
        }
        [Category("菜单项"), Description("显示网格列显示")]
        public bool ShowSetDisplayRowMenu
        {
            get { return this.Items["SETDISPLAY"].Visible; }
            set { this.Items["SETDISPLAY"].Visible = value; }
        }


        private void CreateMenuItems()
        {
            ToolStripMenuItem addItem = new System.Windows.Forms.ToolStripMenuItem("新增", null, new System.EventHandler(this.OnAdd_Click));
            addItem.Name = "ADD";

            ToolStripMenuItem copyItem = new System.Windows.Forms.ToolStripMenuItem("复制", null, new System.EventHandler(this.OnDelete_Click));
            copyItem.Name = "COPY";

            ToolStripMenuItem updateItem = new System.Windows.Forms.ToolStripMenuItem("修改", null, new System.EventHandler(this.OnUpdate_Click));
            updateItem.Name = "UPDATE";

            ToolStripMenuItem deleteItem = new System.Windows.Forms.ToolStripMenuItem("删除", null, new System.EventHandler(this.OnDelete_Click));
            deleteItem.Name = "DELETE";

            ToolStripMenuItem auditItem = new System.Windows.Forms.ToolStripMenuItem("审核", null, new System.EventHandler(this.OnDelete_Click));
            auditItem.Name = "AUDIT";

            ToolStripMenuItem unAuditItem = new System.Windows.Forms.ToolStripMenuItem("反审", null, new System.EventHandler(this.OnDelete_Click));
            unAuditItem.Name = "UNAUDIT";

            ToolStripSeparator line = new ToolStripSeparator();


            ToolStripMenuItem refreshItem = new System.Windows.Forms.ToolStripMenuItem("刷新", null, new System.EventHandler(this.OnDelete_Click));
            refreshItem.Name = "REFRESH";

            ToolStripMenuItem exportItem = new System.Windows.Forms.ToolStripMenuItem("导出", null, new System.EventHandler(this.OnDelete_Click));
            exportItem.Name = "EXPORT";

            ToolStripMenuItem copyRowItem = new System.Windows.Forms.ToolStripMenuItem("复制数据", null, new System.EventHandler(this.OnDelete_Click));
            copyRowItem.Name = "COPYROW";

            ToolStripMenuItem setDisplayItem = new System.Windows.Forms.ToolStripMenuItem("设置显示列", null, new System.EventHandler(this.OnDelete_Click));
            setDisplayItem.Name = "SETDISPLAY";





            this.Items.AddRange(new ToolStripItem[] { addItem, copyItem, updateItem, deleteItem, auditItem, unAuditItem, line, refreshItem, exportItem, copyRowItem, setDisplayItem });
        }


        private void OnAdd_Click(object sender, EventArgs e)
        {
            OnAddClick(sender, e);
        }
        private void OnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateClick(sender, e);
        }
        private void OnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteClick(sender, e);
        }

    }
}
