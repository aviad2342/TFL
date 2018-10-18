using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblZone
{
    public partial class frmRemoveZone : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmRemoveZone()
        {
            InitializeComponent();
        }
        public frmRemoveZone(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmRemoveZone_Load(object sender, EventArgs e)
        {
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (cbZoneNumber.Text != "")
            {
              DialogResult check = MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if (check == DialogResult.Yes)
              {

                  dataCommand.Connection = SQLConnection.con;
                  dataCommand.CommandText = ("delete from tblZone where number=@NUMBER");
                  dataCommand.Parameters.AddWithValue("@NUMBER", char.Parse(cbZoneNumber.Text));

                  try
                  {
                      SQLConnection.con.Open();
                      dataCommand.ExecuteNonQuery();
                      dataCommand.Parameters.Clear();
                      Utils.Alerts.dataSavedSuccessfully();
                      mainWindow.Enabled = true;
                      this.Dispose();
                  }
                  catch (Exception )
                  {
                      Utils.Alerts.errorMessage("sorry you must delete related records first!");
                  }
                  finally { SQLConnection.con.Close(); }
              }
            }
            else Utils.Alerts.errorMessage("You Must Fill All Fields!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveZone_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
