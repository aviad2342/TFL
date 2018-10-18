using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Linq;

namespace HW5.Tables.tblOysterCard
{
    public partial class frmRenewCard : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();
        private SqlCommand dataCommand2 = new SqlCommand();
        private SqlCommand dataCommand3 = new SqlCommand();

        public frmRenewCard()
        {
            InitializeComponent();
        }
        public frmRenewCard(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmRenewCard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbCardNumber;
            Utils.Services.fillComboBoxI(cbCardNumber, "select distinct tblUserCard.number from tblUserCard join tblOysterCard on tblUserCard.number = tblOysterCard.number where UserID = " + globals.getGlobals().GetLogedInUserID(), "tblUserCard.number");
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
            cbZoneNumber.Enabled = false;
            cbCardLength.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            char Length = 'a';
            // input checks
            if (cbCardNumber.Text == "")
            {
                Utils.Alerts.errorMessage("you must choose card numbre first!");
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

                DateTime purchaseDate = DateTime.Now;


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblCard (number, purchaseDate) values (@NUMBER, @DATE)");
                dataCommand.Parameters.AddWithValue("@NUMBER", cbCardNumber.Text);
                dataCommand.Parameters.AddWithValue("@DATE", purchaseDate);

                dataCommand3.Connection = SQLConnection.con;
                dataCommand3.CommandText = ("insert tblUserCard (UserID, number, purchaseDate) values (@UID, @NUMBER, @DATE)");
                dataCommand3.Parameters.AddWithValue("@UID", globals.getGlobals().GetLogedInUserID());
                dataCommand3.Parameters.AddWithValue("@NUMBER", cbCardNumber.Text);
                dataCommand3.Parameters.AddWithValue("@DATE", purchaseDate);

                DateTime pDate = SQLConnection.GetDataContextInstance().tblCards.Where(u => u.number == long.Parse(cbCardNumber.Text)).Max(u => u.purchaseDate);


                if (SQLConnection.GetDataContextInstance().tblOysterCards.Where(u => u.number == long.Parse(cbCardNumber.Text) && u.purchaseDate == pDate).FirstOrDefault().picture != null)
                {
                    Binary binary = SQLConnection.GetDataContextInstance().tblOysterCards.Where(u => u.number == long.Parse(cbCardNumber.Text) && u.purchaseDate == pDate).FirstOrDefault().picture;
                    img = binary.ToArray();
                    dataCommand1.Connection = SQLConnection.con;
                    dataCommand1.CommandText = ("insert tblOysterCard (number, purchaseDate, picture) values (@NUMBER, @DATE, @PIC)");
                    dataCommand1.Parameters.AddWithValue("@NUMBER", cbCardNumber.Text);
                    dataCommand1.Parameters.AddWithValue("@DATE", purchaseDate);
                    dataCommand1.Parameters.AddWithValue("@PIC", img);  
                }
                else
                {
                    dataCommand1.Connection = SQLConnection.con;
                    dataCommand1.CommandText = ("insert tblOysterCard (number, purchaseDate) values (@NUMBER, @DATE)");
                    dataCommand1.Parameters.AddWithValue("@NUMBER", cbCardNumber.Text);
                    dataCommand1.Parameters.AddWithValue("@DATE", purchaseDate);  
                }
                
                dataCommand2.Connection = SQLConnection.con;
                dataCommand2.CommandText = ("insert tblOysterCardAreas (cardNumber,cardPurchaseDate, zoneNumber, cardLength) values (@NUMBER, @DATE, @ZONE, @L)");
                dataCommand2.Parameters.AddWithValue("@NUMBER", cbCardNumber.Text);
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
                    dataCommand.Parameters.Clear();
                    dataCommand3.Parameters.Clear();
                    dataCommand1.Parameters.Clear();
                    dataCommand2.Parameters.Clear();
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

        private void cbCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime purchaseDate = SQLConnection.GetDataContextInstance().tblCards.Where(u => u.number == long.Parse(cbCardNumber.Text)).Max(u => u.purchaseDate);
            char length = SQLConnection.GetDataContextInstance().tblOysterCardAreas.Where(u => u.cardNumber == long.Parse(cbCardNumber.Text) && u.cardPurchaseDate == purchaseDate).FirstOrDefault().cardLength;
            string days = SQLConnection.GetDataContextInstance().tblCardLengths.Where(u => u.cardLength == length).FirstOrDefault().lengthDescription;

            if (purchaseDate.AddDays(double.Parse(days)) > DateTime.Now)
            {
                Utils.Alerts.errorMessage("this card is still effective, can you try different one!");
                cbCardNumber.Text = "";
                return;
            }
            else
            {
                cbZoneNumber.Enabled = true;
                cbCardLength.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRenewCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmRenewCard_MouseEnter(object sender, EventArgs e)
        {
            if (cbCardNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry you must purchase a card first");
                mainWindow.Enabled = true;
                this.Dispose();
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
