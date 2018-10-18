using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblSiteFromSite
{
    public partial class frmSiteFromSite : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();

        public frmSiteFromSite()
        {
            InitializeComponent();
        }
        public frmSiteFromSite(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmSiteFromSite_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbSiteID1;
            txtSite1.Enabled = false;
            txtSite2.Enabled = false;
            txtSite1.Visible = false;
            txtSite2.Visible = false;
            Utils.Services.fillComboBoxI(cbSiteID1, "select ID from tblSite", "ID");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void cbSiteID1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSiteID2.Items.Clear();
            txtSite1.Visible = true;
            txtSite1.Text = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == int.Parse(cbSiteID1.Text)).FirstOrDefault().name;
            cbSiteID2.Enabled = true;
            Utils.Services.fillComboBoxI(cbSiteID2, "select ID from tblSite", "ID");
            cbSiteID2.Items.Remove(cbSiteID1.SelectedItem);
        }

        private void frmSiteFromSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            // input checks
            if (cbSiteID1.Text != "" && cbSiteID2.Text != "")
            {
                if (upDistance.Value == 0)
                {
                    Utils.Alerts.errorMessage("Distance must be bigger than 0!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblSiteFromSites.Where(u => u.siteID1 == int.Parse(cbSiteID1.Text) && u.siteID2 == int.Parse(cbSiteID2.Text)).Any())
                {
                    Utils.Alerts.errorMessage("The record already exists in system! please try again");
                    return;
                }


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblSiteFromSite (siteID1, siteID2, distance) values (@ID1, @ID2, @D)");
                dataCommand.Parameters.AddWithValue("@ID1", cbSiteID1.Text);
                dataCommand.Parameters.AddWithValue("@ID2", cbSiteID2.Text);
                dataCommand.Parameters.AddWithValue("@D", upDistance.Value.ToString());

                dataCommand1.Connection = SQLConnection.con;
                dataCommand1.CommandText = ("insert tblSiteFromSite (siteID1, siteID2, distance) values (@ID1, @ID2, @D)");
                dataCommand1.Parameters.AddWithValue("@ID1", cbSiteID2.Text);
                dataCommand1.Parameters.AddWithValue("@ID2", cbSiteID1.Text);
                dataCommand1.Parameters.AddWithValue("@D", upDistance.Value.ToString());


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand1.ExecuteNonQuery();
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

        private void cbSiteID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSite2.Visible = true;
            txtSite2.Text = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == int.Parse(cbSiteID2.Text)).FirstOrDefault().name;
        }
    }
}
