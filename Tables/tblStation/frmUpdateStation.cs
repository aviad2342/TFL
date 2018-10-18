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
    public partial class frmUpdateStation : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
      
        public frmUpdateStation()
        {
            InitializeComponent();
        }

        public frmUpdateStation(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void frmUpdateStation_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbStationId;
            Utils.Services.fillComboBoxI(cbStationId, "select ID from tblStation", "ID");
            groupBox.Visible = false;
        }

        private void cbStationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            cbZoneNumber.Items.Clear();
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
            if (cbZoneNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no zones available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }

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
                      platformNumber.Text = sdr["platformNum"].ToString();
                      cbZoneNumber.SelectedIndex = cbZoneNumber.Items.IndexOf(sdr["zoneNumber"].ToString());
                      checkKiosk.Checked = Convert.ToBoolean(sdr["kiosk"].ToString());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (cbStationId.Text != "")
            {

                if (txtStationName.Text != "" && cbZoneNumber.Text != "" && platformNumber.Text != "")
                {

                    if (!Utils.InputValidation.isLetters(txtStationName))
                    {
                        Utils.Alerts.errorMessage("Station Name can contains only english letters!");
                        return;
                    }
                    if (!Utils.InputValidation.checkLength(20, txtStationName))
                    {
                        Utils.Alerts.errorMessage("Station Name is to long!");
                        return;
                    }

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("update tblStation set name=@NAME, platformNum=@PN, kiosk=@K, zoneNumber=@ZN where ID=@ID");
                    dataCommand.Parameters.AddWithValue("@ID", cbStationId.Text);
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
            else Utils.Alerts.errorMessage("You Must choose station ID first!!");
        }
            private void frmUpdateStation_FormClosing(object sender, FormClosingEventArgs e)
            {
                mainWindow.Enabled = true;
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                mainWindow.Enabled = true;
                this.Dispose();
            }

            private void frmUpdateStation_MouseEnter(object sender, EventArgs e)
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

