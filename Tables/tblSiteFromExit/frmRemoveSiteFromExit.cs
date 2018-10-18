using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblSiteFromExit
{
    public partial class frmRemoveSiteFromExit : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        int siteID;
        int stationID;
        string lineName;
        double Distance;

        public frmRemoveSiteFromExit()
        {
            InitializeComponent();
        }
        public frmRemoveSiteFromExit(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveSiteFromExit_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtSiteName.Text != "" && txtStationName.Text != "" && txtLineName.Text != "" && txtDistance.Text != "")
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("delete from tblSiteFromExit where siteID=@SITEID and stationID=@STATIONID and lineName=@LINENAME");
                    dataCommand.Parameters.AddWithValue("@SITEID", siteID.ToString());
                    dataCommand.Parameters.AddWithValue("@STATIONID", stationID.ToString());
                    dataCommand.Parameters.AddWithValue("@LINENAME", lineName);

                    try
                    {
                        SQLConnection.con.Open();
                        dataCommand.ExecuteNonQuery();
                        dataCommand.Parameters.Clear();
                        Utils.Alerts.dataSavedSuccessfully();
                        SQLConnection.con.Close();
                        mainWindow.Enabled = true;
                        this.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        Utils.Alerts.errorMessage("Something is wrong, couldn't delete this record!");

                    }
                    finally { SQLConnection.con.Close(); }
                }
            }
            else Utils.Alerts.errorMessage("You Must choose a Record first!");
        }

        private void frmRemoveSiteFromExit_Load(object sender, EventArgs e)
        {
            this.groupBox.Visible = false;
            string qry = "select * from tblSiteFromExit";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, SQLConnection.con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView.AutoGenerateColumns = true;
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Utils.Alerts.errorMessage("No Records Found!");
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.groupBox.Visible = true;

            siteID = int.Parse(this.dataGridView.CurrentRow.Cells[0].Value.ToString());
            stationID = int.Parse(this.dataGridView.CurrentRow.Cells[1].Value.ToString());
            lineName = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            Distance = double.Parse(this.dataGridView.CurrentRow.Cells[3].Value.ToString()); 
            string siteName = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == siteID).FirstOrDefault().name;
            string stationName = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.ID == stationID).FirstOrDefault().name;

            txtSiteName.Text = siteName;
            txtStationName.Text = stationName;
            txtLineName.Text = lineName;
            txtDistance.Text = Distance.ToString();

        }

    }
}
