using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblLine
{
    public partial class frmFindLine : Form
    {

        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; }

        public frmFindLine()
        {
            InitializeComponent();
        }
        public frmFindLine(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmFindLine_Load(object sender, EventArgs e)
        {
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridLine, "tblLine");
            this.Size = new Size(dataGridLine.Size.Width, dataGridLine.Size.Height);
            foreach (DataGridViewColumn column in dataGridLine.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void frmFindLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void dataGridLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
