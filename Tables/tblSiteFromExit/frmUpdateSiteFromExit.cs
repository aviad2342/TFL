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
    public partial class frmUpdateSiteFromExit : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmUpdateSiteFromExit()
        {
            InitializeComponent();
        }
        public frmUpdateSiteFromExit(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmUpdateSiteFromExit_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbStationId;
            txtStationName.Visible = false;
            txtSiteName.Visible = false;
            Utils.Services.fillComboBoxI(cbStationId, "select distinct stationID from tblSiteFromExit", "stationID");
        }

        private void cbStationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStationName.Visible = true;
            cbLineName.Items.Clear();
            cbSiteID.Items.Clear();
            txtStationName.Text = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.ID == int.Parse(cbStationId.Text)).FirstOrDefault().name;
            Utils.Services.fillComboBoxI(cbLineName, "select distinct lineName from tblSiteFromExit where stationID = " + cbStationId.Text, "lineName");
        }

        private void cbLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSiteID.Items.Clear();
            Utils.Services.fillComboBoxI(cbSiteID, "select siteID from tblSiteFromExit where stationID = " + cbStationId.Text + "and lineName = '" + cbLineName.Text+"'", "siteID");
        }

        private void cbSiteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSiteName.Visible = true;
            txtSiteName.Text = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == int.Parse(cbSiteID.Text)).FirstOrDefault().name;
            upDistance.Text = SQLConnection.GetDataContextInstance().tblSiteFromExits.Where(u => u.siteID == int.Parse(cbSiteID.Text) && u.stationID == int.Parse(cbStationId.Text) && u.lineName == cbLineName.Text).FirstOrDefault().distance.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (upDistance.Value == 0)
            {
                Utils.Alerts.errorMessage("Distance must be bigger than 0!");
                return;
            }
            if (cbStationId.Text != "" && cbLineName.Text != "" && cbSiteID.Text != "" && upDistance.Value != 0)
            {

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("update tblSiteFromExit set distance=@DISTANCE where siteID=@SITEID and stationID=@STATIONID and lineName=@LINENAME");
                dataCommand.Parameters.AddWithValue("@SITEID", int.Parse(cbSiteID.Text));
                dataCommand.Parameters.AddWithValue("@STATIONID", int.Parse(cbStationId.Text));
                dataCommand.Parameters.AddWithValue("@LINENAME", cbLineName.Text);
                dataCommand.Parameters.AddWithValue("@DISTANCE", double.Parse(upDistance.Text));

                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    Utils.Alerts.dataSavedSuccessfully();
                    mainWindow.Enabled = true;
                    this.Dispose();
                }
                catch (Exception)
                {
                    Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
                }
                finally { SQLConnection.con.Close(); }
            }
            else Utils.Alerts.errorMessage("You Must Fill All Fields!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmUpdateSiteFromExit_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
