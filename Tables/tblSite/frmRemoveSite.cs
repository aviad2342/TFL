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
    public partial class frmRemoveSite : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmRemoveSite()
        {
            InitializeComponent();
        }
        public frmRemoveSite(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmRemoveSite_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbSiteID;
            Utils.Services.fillComboBox(cbSiteID, "select ID from tblSite", "ID", mainWindow, this);
            groupBox.Visible = false;
        }

        private void cbSiteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;

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
                    txtFoundedYear.Text = sdr["foundedYear"].ToString();
                    txtSiteType.Text = sdr["siteType"].ToString();
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
            if (cbSiteID.Text != "")
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("delete from tblSite where ID=@ID");
                    dataCommand.Parameters.AddWithValue("@ID", cbSiteID.Text);

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
            else Utils.Alerts.errorMessage("You Must choose Site ID first!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmRemoveSite_MouseEnter(object sender, EventArgs e)
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
