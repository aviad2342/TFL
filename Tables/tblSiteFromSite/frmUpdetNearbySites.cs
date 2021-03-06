﻿using System;
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
    public partial class frmUpdetNearbySites : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();

        public frmUpdetNearbySites()
        {
            InitializeComponent();
        }
        public frmUpdetNearbySites(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmUpdetNearbySites_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbSiteID1;
            txtSite1.Enabled = false;
            txtSite2.Enabled = false;
            txtSite1.Visible = false;
            txtSite2.Visible = false;
            Utils.Services.fillComboBoxI(cbSiteID1, "select distinct siteID1 from tblSiteFromSite", "siteID1");
        }

        private void btnRemoveSite_Click(object sender, EventArgs e)
        {
            if (cbSiteID1.Text != "" && cbSiteID2.Text != "")
            {
                if (upDistance.Value == 0)
                {
                    Utils.Alerts.errorMessage("Distance must be bigger than 0!");
                    return;
                }

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("update tblSiteFromSite set distance=@D where siteID1=@ID1 and siteID2=@ID2");
                    dataCommand.Parameters.AddWithValue("@ID1", cbSiteID1.Text);
                    dataCommand.Parameters.AddWithValue("@ID2", cbSiteID2.Text);
                    dataCommand.Parameters.AddWithValue("@D", upDistance.Text);

                    dataCommand1.Connection = SQLConnection.con;
                    dataCommand1.CommandText = ("update tblSiteFromSite set distance=@D2 where siteID1=@SID1 and siteID2=@SID2");
                    dataCommand1.Parameters.AddWithValue("@SID1", cbSiteID2.Text);
                    dataCommand1.Parameters.AddWithValue("@SID2", cbSiteID1.Text);
                    dataCommand1.Parameters.AddWithValue("@D2", upDistance.Text);

                    try
                    {
                        SQLConnection.con.Open();
                        dataCommand.ExecuteNonQuery();
                        dataCommand1.ExecuteNonQuery();
                        dataCommand.Parameters.Clear();
                        dataCommand1.Parameters.Clear();
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
            else Utils.Alerts.errorMessage("You Must choose Site ID first!!");
        }

        private void cbSiteID1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSiteID2.Items.Clear();
            txtSite1.Visible = true;
            txtSite1.Text = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == int.Parse(cbSiteID1.Text)).FirstOrDefault().name;
            cbSiteID2.Enabled = true;
            Utils.Services.fillComboBoxI(cbSiteID2, "select siteID2 from tblSiteFromSite where siteID1 = " + cbSiteID1.Text, "siteID2");
        }

        private void cbSiteID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSite2.Visible = true;
            txtSite2.Text = SQLConnection.GetDataContextInstance().tblSites.Where(u => u.ID == int.Parse(cbSiteID2.Text)).FirstOrDefault().name;
            upDistance.Text = SQLConnection.GetDataContextInstance().tblSiteFromSites.Where(u => u.siteID1 == int.Parse(cbSiteID1.Text) && u.siteID2 == int.Parse(cbSiteID2.Text)).FirstOrDefault().distance.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmUpdetNearbySites_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
