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
    public partial class frmAddZone : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmAddZone()
        {
            InitializeComponent();
        }
        public frmAddZone(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmAddZone_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                cbZoneNumber.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (cbZoneNumber.Text != "")
            {

                if (SQLConnection.GetDataContextInstance().tblZones.Where(u => u.number == char.Parse(cbZoneNumber.Text)).Any())
                {
                    Utils.Alerts.errorMessage("Sorry zone number: " + cbZoneNumber.Text + " already exists in system! please try again");
                    return;
                }

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblZone (number) values (@NUMBER)");
                dataCommand.Parameters.AddWithValue("@NUMBER", char.Parse(cbZoneNumber.Text));

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmAddZone_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
