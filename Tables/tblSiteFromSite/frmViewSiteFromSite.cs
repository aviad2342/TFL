using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblSiteFromSite
{
    public partial class frmViewSiteFromSite : Form
    {
        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; }

        public frmViewSiteFromSite()
        {
            InitializeComponent();
        }
        public frmViewSiteFromSite(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmViewSiteFromSite_Load(object sender, EventArgs e)
        {
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridView, "tblSiteFromSite");
            this.Size = new Size(dataGridView.Size.Width, dataGridView.Size.Height);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void frmViewSiteFromSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
