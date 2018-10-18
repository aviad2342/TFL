using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblPaperCard
{
    public partial class frmNewPaperCard : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();
        private SqlCommand dataCommand2 = new SqlCommand();
        private SqlCommand dataCommand3 = new SqlCommand();

        public frmNewPaperCard()
        {
            InitializeComponent();
        }
        public frmNewPaperCard(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void newPaperCard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbZoneNumber;
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char Length = 'a';
            // input checks
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

                long cardNumber = SQLConnection.GetDataContextInstance().tblCards.Max(u => u.number) + 1;
                DateTime purchaseDate = DateTime.Now;


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblCard (number, purchaseDate) values (@NUMBER, @DATE)");
                dataCommand.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand.Parameters.AddWithValue("@DATE", purchaseDate);

                dataCommand3.Connection = SQLConnection.con;
                dataCommand3.CommandText = ("insert tblUserCard (UserID, number, purchaseDate) values (@UID, @NUMBER, @DATE)");
                dataCommand3.Parameters.AddWithValue("@UID", globals.getGlobals().GetLogedInUserID());
                dataCommand3.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand3.Parameters.AddWithValue("@DATE", purchaseDate);


                dataCommand1.Connection = SQLConnection.con;
                dataCommand1.CommandText = ("insert tblPaperCard (number,purchaseDate,isTourist) values (@NUMBER, @DATE, @IST)");
                dataCommand1.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand1.Parameters.AddWithValue("@DATE", purchaseDate);
                dataCommand1.Parameters.AddWithValue("@IST", checkIsTourist.Checked);

                
                dataCommand2.Connection = SQLConnection.con;
                dataCommand2.CommandText = ("insert tblPaperCardAreas (cardNumber,cardPurchaseDate, zoneNumber, cardLength) values (@NUMBER, @DATE, @ZONE, @L)");
                dataCommand2.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand2.Parameters.AddWithValue("@DATE", purchaseDate);
                dataCommand2.Parameters.AddWithValue("@ZONE", cbZoneNumber.Text);
                dataCommand2.Parameters.AddWithValue("@L", Length);


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand3.ExecuteNonQuery();
                    dataCommand1.ExecuteNonQuery();
                    dataCommand2.ExecuteNonQuery();
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

        private void frmNewPaperCard_MouseEnter(object sender, EventArgs e)
        {
            if (cbZoneNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no zones available in system yet");
                mainWindow.Enabled = true;
                this.Close();
            }
        }

        private void frmNewPaperCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }
    }
}
