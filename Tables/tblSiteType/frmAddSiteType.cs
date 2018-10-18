using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblSiteType
{
    public partial class frmAddSiteType : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmAddSiteType()
        {
            InitializeComponent();
        }
        public frmAddSiteType(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmAddSiteType_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtType;
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            // input checks
            if (txtType.Text != "")
            {

                if (!Utils.InputValidation.isLetters(txtType))
                {
                    Utils.Alerts.errorMessage("Type can contains only english letters!");
                    return;
                }
                if (!Utils.InputValidation.checkLength(15, txtType))
                {
                    Utils.Alerts.errorMessage("Type is to long!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblSiteTypes.Where(u => u.siteType == txtType.Text).Any())
                {
                    Utils.Alerts.errorMessage("The Type: \"" + txtType.Text + "\" already exists in system! please try different one");
                    return;
                }

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblSiteType (siteType) values (@TYPE)");
                dataCommand.Parameters.AddWithValue("@TYPE", txtType.Text);


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
            else Utils.Alerts.errorMessage("You Must Fill The Type Field!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmAddSiteType_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
