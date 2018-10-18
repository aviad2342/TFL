using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblStationInLine
{
    public partial class frmFindStationLines : Form
    {
        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; }

        public frmFindStationLines()
        {
            InitializeComponent();
        }
        public frmFindStationLines(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmFindStationLines_Load(object sender, EventArgs e)
        {
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridStationLine, "tblStationInLine");
            this.Size = new Size(dataGridStationLine.Size.Width, dataGridStationLine.Size.Height);
            foreach (DataGridViewColumn column in dataGridStationLine.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void frmFindStationLines_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
