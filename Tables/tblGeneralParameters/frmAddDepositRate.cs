using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblGeneralParameters
{
    public partial class frmAddDepositRate : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        int EndYear;
        int NewStartYear;
        int OldStartYear;
        bool UpdadeOrInsert;
        bool CloseForm = false;

        public frmAddDepositRate()
        {
            InitializeComponent();
        }
        public frmAddDepositRate(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmAddDepositRate_Load(object sender, EventArgs e)
        {
            UpdadeOrInsert = false;
            EndYear = SQLConnection.GetDataContextInstance().tblGeneralParameters.Max(u => u.depositEndYear);
            NewStartYear = EndYear + 1;
            OldStartYear = SQLConnection.GetDataContextInstance().tblGeneralParameters.Max(u => u.depositStartYear);
            txtFromYear.Text = NewStartYear.ToString();
            UpEndYear.Value = NewStartYear;

            if (DateTime.Now.Year <= EndYear)
            {
                DialogResult check = MessageBox.Show("Note: the Deposit Rate for this year has already been set (up to the year of: " + EndYear + " ) would you like to update it?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {
                    txtFromYear.Text = OldStartYear.ToString();
                    UpEndYear.Value = EndYear;
                    UpdadeOrInsert = true;
                }
                else CloseForm = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (UpdadeOrInsert == false)
            {
                // input checks
                if (UpEndYear.Value >= NewStartYear)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("insert tblGeneralParameters (depositStartYear,depositEndYear,price) values (@FY, @TY, @P)");
                    dataCommand.Parameters.AddWithValue("@FY", NewStartYear);
                    dataCommand.Parameters.AddWithValue("@TY", UpEndYear.Value.ToString());
                    dataCommand.Parameters.AddWithValue("@P", upPrice.Value.ToString());

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
                else Utils.Alerts.errorMessage("End Year must be after the Start Year!");
            }
            else
            {
                // input checks
                if (UpEndYear.Value >= OldStartYear)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("update tblGeneralParameters set depositEndYear=@TY, price=@P where depositStartYear=@FY");
                    dataCommand.Parameters.AddWithValue("@FY", OldStartYear);
                    dataCommand.Parameters.AddWithValue("@TY", UpEndYear.Value.ToString());
                    dataCommand.Parameters.AddWithValue("@P", upPrice.Value.ToString());


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
                else Utils.Alerts.errorMessage("End Year must be after the Start Year!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmAddDepositRate_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmAddDepositRate_MouseEnter(object sender, EventArgs e)
        {
            if (CloseForm)
            {
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }
    }
}
