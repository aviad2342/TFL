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
    public partial class frmAddSite : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmAddSite()
        {
            InitializeComponent();
        }
        public frmAddSite(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmAddSite_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSiteName;
            Utils.Services.fillComboBoxI(cbSiteType, "select siteType from tblSiteType", "siteType");
            UpFoundedYear.Maximum = DateTime.Now.Year;
            UpFoundedYear.Value = DateTime.Now.Year;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmAddSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            // input checks
            if (txtSiteName.Text != "" && rtxtDescription.Text != "" && cbSiteType.Text != "")
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
                if (SQLConnection.GetDataContextInstance().tblSites.Where(u => u.name == txtSiteName.Text).Any())
                {
                    Utils.Alerts.errorMessage("The Site name: \"" + txtSiteName.Text + "\" already exists in system! please try again.");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblSites.Where(u => u.name == txtSiteName.Text && u.foundedYear == UpFoundedYear.Value && u.siteType == cbSiteType.Text).Any())
                {
                    Utils.Alerts.errorMessage("The record already exists in system!");
                    return;
                }


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblSite (name, siteDescription, foundedYear, siteType)  values (@NAME, @D, @FY, @ST)");
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

        private void frmAddSite_MouseEnter(object sender, EventArgs e)
        {
            if (cbSiteType.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Site Types available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }
    }
}
