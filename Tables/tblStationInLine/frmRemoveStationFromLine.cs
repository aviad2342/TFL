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
    public partial class frmRemoveStationFromLine : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmRemoveStationFromLine()
        {
            InitializeComponent();
        }
        public frmRemoveStationFromLine(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmRemoveStationFromLine_Load(object sender, EventArgs e)
        {
            Utils.Services.fillComboBoxI(cbStationId, "select ID from tblStation", "ID");
        }

        private void cbStationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbxLineName.Items.Clear();
            this.groupBox.Visible = true;
            if (SQLConnection.GetDataContextInstance().tblStationInLines.Where(u => u.stationID == int.Parse(cbStationId.Text)).Max(u => u.lineName) != null)
            {
                this.lbxLineName.Enabled = true;
                Utils.Services.fillListBox(lbxLineName, "select lineName from tblStationInLine where stationID = " + cbStationId.Text, "lineName", mainWindow, this);
            }
            else
            {
                lbxLineName.Items.Add("No Lines found");
                this.lbxLineName.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveStationFromLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbStationId.Text != "")
            {
                if (lbxLineName.SelectedIndex == -1)
                {
                    Utils.Alerts.errorMessage("You Must choose a line first!!");
                    return;
                }
                DialogResult check = MessageBox.Show("Are you sure you want to remove the station: " + cbStationId.Text + " from line: " + lbxLineName.Text, "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("delete from tblStationInLine where stationID=@ID and lineName=@Name");
                    dataCommand.Parameters.AddWithValue("@ID", cbStationId.Text);
                    dataCommand.Parameters.AddWithValue("@Name", lbxLineName.Text);

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
            else Utils.Alerts.errorMessage("You Must choose station number first!!");
        }

        private void frmRemoveStationFromLine_MouseEnter(object sender, EventArgs e)
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
