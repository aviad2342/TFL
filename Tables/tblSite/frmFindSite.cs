using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblSite
{
    public partial class frmFindSite : Form
    {
        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; } 

        public frmFindSite()
        {
            InitializeComponent();
        }
        public frmFindSite(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmFindSite_Load(object sender, EventArgs e)
        {
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridSite, "tblSite");
            this.Size = new Size(dataGridSite.Size.Width, dataGridSite.Size.Height);
            foreach (DataGridViewColumn column in dataGridSite.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void frmFindSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
