using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblStation
{
    public partial class frmAddStation : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmAddStation()
        {
            InitializeComponent();
        }
        public frmAddStation(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmAddStation_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtStationName;
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
        }

        private void frmAddStation_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (txtStationName.Text != "" && cbZoneNumber.Text != "" && platformNumber.Text != "")
            {

                if (!Utils.InputValidation.isLetters(txtStationName))
                {
                    Utils.Alerts.errorMessage("Station Name can contains only english letters!");
                    return;
                }
                if (!Utils.InputValidation.checkLength(20,txtStationName))
                {
                    Utils.Alerts.errorMessage("Station Name is to long!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblStations.Where(u => u.name == txtStationName.Text).Any())
                {
                    Utils.Alerts.errorMessage("The station name: \"" + txtStationName.Text + "\" already exists in system! please try again.");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblStations.Where(u => u.name == txtStationName.Text && u.zoneNumber == char.Parse(cbZoneNumber.Text)).Any())
                {
                    Utils.Alerts.errorMessage("The record already exists in system!");
                    return;
                }


            dataCommand.Connection = SQLConnection.con;
            dataCommand.CommandText = ("insert tblStation (name, platformNum, kiosk, zoneNumber) values (@NAME, @PN, @K, @ZN)");
            dataCommand.Parameters.AddWithValue("@NAME", txtStationName.Text);
            dataCommand.Parameters.AddWithValue("@PN", platformNumber.Value.ToString());
            dataCommand.Parameters.AddWithValue("@K", checkKiosk.Checked);
            dataCommand.Parameters.AddWithValue("@ZN", cbZoneNumber.Text);

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

        private void frmAddStation_MouseEnter(object sender, EventArgs e)
        {
            if (cbZoneNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no zones available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }
    }
}
