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
    public partial class frmSiteFromExit : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmSiteFromExit()
        {
            InitializeComponent();
        }
        public frmSiteFromExit(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmSiteFromExit_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbStationId;
            txtStationName.Visible = false;
            txtSiteName.Visible = false;
            cbLineName.Enabled = false;
            Utils.Services.fillComboBoxI(cbStationId, "select ID from tblStation", "ID");
            Utils.Services.fillComboBoxI(cbSiteID, "select ID from tblSite", "ID"); 
        }

        private void cbStationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLineName.Enabled = true;
            cbLineName.Items.Clear();
            Utils.Services.fillComboBoxI(cbLineName, "select lineName from tblStationInLine where stationID = " + cbStationId.Text, "lineName");
            if (cbLineName.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry this station have no exies yet! try a different station");
                cbLineName.Items.Clear();
                cbLineName.Enabled = false;
            }
            txtStationName.Visible = true;
            txtStationName.Text = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.ID == int.Parse(cbStationId.Text)).FirstOrDefault().name;
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

                if (SQLConnection.GetDataContextInstance().tblSiteFromExits.Where(u => u.siteID == int.Parse(cbSiteID.Text) && u.stationID == int.Parse(cbStationId.Text) && u.lineName == cbLineName.Text).Any())
                {
                    Utils.Alerts.errorMessage("The record already exists in system!");
                    cbLineName.SelectedIndex = -1;
                    cbSiteID.SelectedIndex = -1;
                    upDistance.Value = 0;
                    return;
                }

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblSiteFromExit (siteID,stationID,lineName,distance) values (@SITEID, @STATIONID, @LINENAME, @DISTANCE)");
                dataCommand.Parameters.AddWithValue("@SITEID", cbSiteID.Text);
                dataCommand.Parameters.AddWithValue("@STATIONID", cbStationId.Text);
                dataCommand.Parameters.AddWithValue("@LINENAME", cbLineName.Text);
                dataCommand.Parameters.AddWithValue("@DISTANCE", upDistance.Text);

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

        private void frmSiteFromExit_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmSiteFromExit_MouseEnter(object sender, EventArgs e)
        {
            if (cbSiteID.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Sites available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }

        private void cbSiteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSiteName.Visible = true;
            txtSiteName.Text = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == int.Parse(cbSiteID.Text)).FirstOrDefault().name;
        }
    }
}
