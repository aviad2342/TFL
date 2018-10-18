using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblStationInLine
{
    public partial class frmAddStationToLine : Form
    {

        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmAddStationToLine()
        {
            InitializeComponent();
        }
        public frmAddStationToLine(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmAddStationToLine_Load(object sender, EventArgs e)
        {
            txtStationName.Visible = false;
            Utils.Services.fillComboBoxI(cbStationId, "select ID from tblStation", "ID");
            Utils.Services.fillComboBoxI(cbLineName, "select name from tblLine", "name");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (cbStationId.Text != "" && cbLineName.Text != "")
            {

                if (SQLConnection.GetDataContextInstance().tblStationInLines.Where(u => u.stationID == int.Parse(cbStationId.Text) && u.lineName == cbLineName.Text).Any())
                {
                    Utils.Alerts.errorMessage("Sorry the station ID: " + cbStationId.Text + " is already assigned to: " + cbLineName.Text + " pleas try again.");
                    return;
                }

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblStationInLine (stationID, lineName) values (@SID, @LN)");
                dataCommand.Parameters.AddWithValue("@SID", cbStationId.Text);
                dataCommand.Parameters.AddWithValue("@LN", cbLineName.Text);

                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand.Parameters.Clear();
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

        private void frmAddStationToLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmAddStationToLine_MouseEnter(object sender, EventArgs e)
        {
            if (cbStationId.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Stations available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
            if (cbLineName.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Lines available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }

        private void cbStationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStationName.Visible = true;
            txtStationName.Text = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.ID == int.Parse(cbStationId.Text)).FirstOrDefault().name;
        }
    }
}
