using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblSite
{
    public partial class frmUpdateSite : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmUpdateSite()
        {
            InitializeComponent();
        }
        public frmUpdateSite(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmUpdateSite_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbSiteID;
            Utils.Services.fillComboBoxI(cbSiteID, "select ID from tblSite", "ID");
            groupBox.Visible = false;
        }

        private void cbSiteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            cbSiteType.Items.Clear();
            Utils.Services.fillComboBoxI(cbSiteType, "select siteType from tblSiteType", "siteType");
            if (cbSiteType.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Site Types available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
            UpFoundedYear.Maximum = DateTime.Now.Year;

            dataCommand = new SqlCommand("SELECT * FROM tblSite WHERE ID=@siteID", SQLConnection.con);

            dataCommand.Parameters.Add("@siteID", SqlDbType.VarChar).Value = cbSiteID.Text;
            dataCommand.Connection = SQLConnection.con;
            SQLConnection.con.Open();
            try
            {
                SqlDataReader sdr = dataCommand.ExecuteReader();

                if (sdr.Read())
                {
                    txtSiteName.Text = sdr["name"].ToString();
                    UpFoundedYear.Text = sdr["foundedYear"].ToString();
                    cbSiteType.SelectedIndex = cbSiteType.Items.IndexOf(sdr["siteType"].ToString());
                    rtxtDescription.Text = sdr["siteDescription"].ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid item barcode");
                }

            }
            catch (Exception)
            {
                Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
            }
            finally { SQLConnection.con.Close(); }
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            // input checks
            if (cbSiteID.Text == "")
            {
                Utils.Alerts.errorMessage("You Must choose Site ID first!!");
                return;
            }
            if (cbSiteID.Text != "" && txtSiteName.Text != "" && rtxtDescription.Text != "" && cbSiteType.Text != "")
            {

                if (!Utils.InputValidation.isLetters(txtSiteName))
                {
                    Utils.Alerts.errorMessage("Site Name can contains only english letters!");
                    return;
                }
                if (!Utils.InputValidation.checkLength(20, txtSiteName))
                {
                    Utils.Alerts.errorMessage("Site Name is to long!");
                    return;
                }

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("update tblSite set name=@NAME, siteDescription=@D, foundedYear=@FY, siteType=@ST where ID=@ID");
                dataCommand.Parameters.AddWithValue("@ID", cbSiteID.Text);
                dataCommand.Parameters.AddWithValue("@NAME", txtSiteName.Text);
                dataCommand.Parameters.AddWithValue("@D", rtxtDescription.Text);
                dataCommand.Parameters.AddWithValue("@FY", UpFoundedYear.Value.ToString());
                dataCommand.Parameters.AddWithValue("@ST", cbSiteType.Text);

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

        private void frmUpdateSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmUpdateSite_MouseEnter(object sender, EventArgs e)
        {
            if (cbSiteID.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Sites available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }
    }
}
