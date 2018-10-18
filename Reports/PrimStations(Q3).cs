using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Reports
{
    public partial class PrimStations : Form
    {
        private Form mainWindow;

        public PrimStations()
        {
            InitializeComponent();
        }

        public PrimStations(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void PrimStations_Load(object sender, EventArgs e)
        {

            string qry ="select SE.lineName,SE.stationID, COUNT(SE.siteID) as numOfSitesForLine"
                       + " FROM tblSiteFromExit SE"
                       + " WHERE SE.distance<0.5 and not exists("
                            + "select SE1.siteID"
                            + " FROM tblSiteFromExit SE1"
                            + " WHERE SE1.stationID!=SE.stationID and SE1.distance<0.5 and SE1.siteID=SE.siteID)"
                       + " GROUP BY SE.lineName, SE.stationID"
                       + " HAVING COUNT(SE.siteID)>=3"
                       + " ORDER BY SE.lineName,numOfSitesForLine desc";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, SQLConnection.con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dataGridView.AutoGenerateColumns = true;
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = ds.Tables[0];
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Utils.Alerts.errorMessage("Something is wrong, couldn't show this data!");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrimStations_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }


    }
}
