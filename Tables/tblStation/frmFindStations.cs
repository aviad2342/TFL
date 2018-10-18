using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblStation
{
    public partial class frmFindStations : Form
    {
        private BindingSource bs = new BindingSource();
        private Form mainWindow { get; set; }


        public frmFindStations()
        {
            InitializeComponent();
        }

        public frmFindStations(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmDisplayStations_Load(object sender, EventArgs e)
        { 
            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridStations, "tblStation");
            this.Size = new Size(dataGridStations.Size.Width, dataGridStations.Size.Height);
            foreach (DataGridViewColumn column in dataGridStations.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        private void frmFindStations_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

    }
}
