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
    public partial class MostActive : Form
    {
        private Form mainWindow;

        public MostActive()
        {
            InitializeComponent();
        }

        public MostActive(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void MostActive_Load(object sender, EventArgs e)
        {
	       string qry = "select S.ID, S.name, MIN(SFE.distance)as 'minDistance' "
               + " from dbo.tblStation as S inner join dbo.tblSiteFromExit SFE on S.ID ="
               + " SFE.stationID join dbo.tblSite as SI1 on SI1.ID=SFE.siteID "
               + " where S.platformNum > 4 and S.ID in"
               + " (select SIL1.stationID"
               + " from dbo.tblStationInLine as SIL1"
               + " where S.ID = SIL1.stationID"
               + " group by SIL1.stationID"
               + " having COUNT (SIL1.lineName) > 2 "

               + " intersect"

               + " select SFX.stationID "
               + " from dbo.tblSiteFromExit as SFX"
               + " where S.ID = SFX.stationID and SFX.distance <= 1.5"
               + " group by SFX.stationID"
               + " having COUNT (SFX.siteID) >= 5) "
               + " group by S.ID, S.name";




            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, SQLConnection.con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);


                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void MostActive_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }


    }
}
