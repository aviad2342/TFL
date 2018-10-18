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
    public partial class frmRemoveStation : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmRemoveStation()
        {
            InitializeComponent();
        }

        public frmRemoveStation(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void frmRemoveStation_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbStationId;
            Utils.Services.fillComboBoxI(cbStationId, "select ID from tblStation", "ID");
            groupBox.Visible = false;
        }

        private void cbStationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;

            dataCommand = new SqlCommand("SELECT * FROM tblStation WHERE ID=@stationID", SQLConnection.con);

            dataCommand.Parameters.Add("@stationID", SqlDbType.VarChar).Value = cbStationId.Text;
            dataCommand.Connection = SQLConnection.con;
            SQLConnection.con.Open();
            try
            {
                SqlDataReader sdr = dataCommand.ExecuteReader();

                if (sdr.Read())
                {
                    txtStationName.Text = sdr["name"].ToString();
                    txtNumOfPlatforms.Text = sdr["platformNum"].ToString();
                    txtZoneNumber.Text = sdr["zoneNumber"].ToString();
                    txtKiosk.Text = sdr["kiosk"].ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID");
                }
            }
            catch (Exception)
            {
                Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
            }
            finally { SQLConnection.con.Close(); }
             


        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (cbStationId.Text != "")
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("delete from tblStation where ID=@ID");
                    dataCommand.Parameters.AddWithValue("@ID", cbStationId.Text);

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
            else Utils.Alerts.errorMessage("You Must choose station ID first!!");
        }
        private void frmRemoveStation_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveStation_MouseEnter(object sender, EventArgs e)
        {
            if (cbStationId.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Stations available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }

    }
}
