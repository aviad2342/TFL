using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblOysterCard
{
    public partial class frmUpgradeProgram : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmUpgradeProgram()
        {
            InitializeComponent();
        }
        public frmUpgradeProgram(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmUpgradeProgram_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbCardNumber;
            groupBox.Visible = false;
            Utils.Services.fillComboBoxI(cbCardNumber, "select distinct tblUserCard.number from tblUserCard join tblOysterCard on tblUserCard.number = tblOysterCard.number where UserID = " + globals.getGlobals().GetLogedInUserID(), "tblUserCard.number");
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
        }

        private void cbCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            groupBox.Visible = true;
            string qry = "select cardPurchaseDate,zoneNumber,cardLength from tblOysterCardAreas where cardNumber = " + cbCardNumber.Text;

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, SQLConnection.con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView.AutoGenerateColumns = true;
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Utils.Alerts.errorMessage("Something is wrong, couldn't show this data!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char Length = 'a';
            // input checks
            if (cbCardNumber.Text == "")
            {
                Utils.Alerts.errorMessage("you must choose card number first!");
                return;
            }
            if (cbZoneNumber.Text != "" && cbCardLength.Text != "")
            {

                if (cbCardLength.Text == "Day")
                {
                    Length = 'D';
                }
                else if (cbCardLength.Text == "3 Days")
                {
                    Length = 'S';
                }
                else if (cbCardLength.Text == "Week")
                {
                    Length = 'W';
                }
                else if (cbCardLength.Text == "Month")
                {
                    Length = 'M';
                }
                else if (cbCardLength.Text == "3 Months")
                {
                    Length = 'T';
                }
                else if (cbCardLength.Text == "Year")
                {
                    Length = 'Y';
                }


                DateTime purchaseDate = SQLConnection.GetDataContextInstance().tblOysterCardAreas.Where(u => u.cardNumber == long.Parse(cbCardNumber.Text)).Max(u => u.cardPurchaseDate);

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblOysterCardAreas (cardNumber,cardPurchaseDate, zoneNumber, cardLength) values (@NUMBER, @DATE, @ZONE, @L)");
                dataCommand.Parameters.AddWithValue("@NUMBER", cbCardNumber.Text);
                dataCommand.Parameters.AddWithValue("@DATE", purchaseDate);
                dataCommand.Parameters.AddWithValue("@ZONE", cbZoneNumber.Text);
                dataCommand.Parameters.AddWithValue("@L", Length);


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand.Parameters.Clear();
                    Utils.Alerts.dataSavedSuccessfully();
                    mainWindow.Enabled = true;
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void frmUpgradeProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmUpgradeProgram_MouseEnter(object sender, EventArgs e)
        {
            if (cbCardNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry you must purchase a card first");
                mainWindow.Enabled = true;
                this.Close();
            }
            if (cbZoneNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no zones available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }
    }
}
