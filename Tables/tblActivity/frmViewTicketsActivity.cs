using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblActivity
{
    public partial class frmViewTicketsActivity : Form
    {
        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; }

        public frmViewTicketsActivity()
        {
            InitializeComponent();
        }
        public frmViewTicketsActivity(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmViewTicketsActivity_Load(object sender, EventArgs e)
        {
            
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridView, "tblActivity");
            this.Size = new Size(dataGridView.Size.Width, dataGridView.Size.Height);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void frmViewTicketsActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
