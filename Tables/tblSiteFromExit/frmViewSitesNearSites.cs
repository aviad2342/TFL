using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblSiteFromExit
{
    public partial class frmViewSitesNearSites : Form
    {
        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; }

        public frmViewSitesNearSites()
        {
            InitializeComponent();
        }
        public frmViewSitesNearSites(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewSitesNearSites_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmViewSitesNearSites_Load(object sender, EventArgs e)
        {
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridView, "tblSiteFromExit");
            this.Size = new Size(dataGridView.Size.Width, dataGridView.Size.Height);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
