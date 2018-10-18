using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblActivity
{
    public partial class frmBoardingAtrain : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        DateTime ticketPurchaseDate;
        DateTime ticketExpirationDate;
        int OriginStationID;
        string ticketProgramDays;
        char ticketMaxZone;
        char ticketLength;

        public frmBoardingAtrain()
        {
            InitializeComponent();
        }
        public frmBoardingAtrain(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmBoardingAtrain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbUserTickets;
            cbOriginStstion.Enabled = false;
            cbLins.Enabled = false;
            Utils.Services.fillComboBoxI(cbUserTickets, "select distinct number from tblUserCard where UserID = " + globals.getGlobals().GetLogedInUserID(), "number");
            rbIn.Checked = true;
        }

        private void cbUserTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLins.Items.Clear();
            cbOriginStstion.Items.Clear();
            cbOriginStstion.Enabled = true;
            // checks
            if (SQLConnection.GetDataContextInstance().tblOysterCards.Where(u => u.number == long.Parse(cbUserTickets.Text)).Any())
            {
                ticketPurchaseDate = SQLConnection.GetDataContextInstance().tblOysterCardAreas.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text)).Max(u => u.cardPurchaseDate);
                ticketMaxZone = SQLConnection.GetDataContextInstance().tblOysterCardAreas.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text) && u.cardPurchaseDate == ticketPurchaseDate).FirstOrDefault().zoneNumber;
                ticketLength = SQLConnection.GetDataContextInstance().tblOysterCardAreas.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text) && u.cardPurchaseDate == ticketPurchaseDate).FirstOrDefault().cardLength;
                ticketProgramDays = SQLConnection.GetDataContextInstance().tblCardLengths.Where(u => u.cardLength == ticketLength).FirstOrDefault().lengthDescription;
                ticketExpirationDate = ticketPurchaseDate.AddDays(double.Parse(ticketProgramDays));

                if (ticketExpirationDate < DateTime.Now)
                {
                    if (cbUserTickets.Items.Count > 1)
                    {
                        Utils.Alerts.errorMessage("Sorry this ticket program has exited! please try a different ticket");
                        return;
                    }
                    else
                    {
                        Utils.Alerts.errorMessage("Sorry your ticket program has exited! please purchase a new one or renew your ticket");
                        mainWindow.Enabled = true;
                        this.Dispose();
                    }

                }
            }
            else if (SQLConnection.GetDataContextInstance().tblPaperCards.Where(u => u.number == long.Parse(cbUserTickets.Text)).Any())
            {
                ticketPurchaseDate = SQLConnection.GetDataContextInstance().tblPaperCardAreas.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text)).FirstOrDefault().cardPurchaseDate;
                ticketMaxZone = SQLConnection.GetDataContextInstance().tblPaperCardAreas.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text)).FirstOrDefault().zoneNumber;
                ticketLength = SQLConnection.GetDataContextInstance().tblPaperCardAreas.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text)).FirstOrDefault().cardLength;
                ticketProgramDays = SQLConnection.GetDataContextInstance().tblCardLengths.Where(u => u.cardLength == ticketLength).FirstOrDefault().lengthDescription;
                ticketExpirationDate = ticketPurchaseDate.AddDays(double.Parse(ticketProgramDays));

                if (ticketExpirationDate < DateTime.Now)
                {
                    if (cbUserTickets.Items.Count > 1)
                    {
                        Utils.Alerts.errorMessage("Sorry this ticket program has exited! please try a different ticket");
                        return;
                    }
                    else
                    {
                        Utils.Alerts.errorMessage("Sorry your ticket has exited!");
                        mainWindow.Enabled = true;
                        this.Dispose();
                    }

                }
            } // end of checks

            Utils.Services.fillComboBoxI(cbOriginStstion, "select name from tblStation where zoneNumber <= " + ticketMaxZone, "name");
        }

        private void cbOriginStstion_SelectedIndexChanged(object sender, EventArgs e)
        {
            OriginStationID = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.name == cbOriginStstion.Text).FirstOrDefault().ID;
            cbLins.Enabled = true;
            cbLins.Items.Clear();
            Utils.Services.fillComboBoxI(cbLins, "select lineName from tblStationInLine where stationID = " + OriginStationID, "lineName");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char inOut;
            // input checks
            if (cbUserTickets.Text != "" && cbOriginStstion.Text != "" && cbLins.Text != "")
            {
                if(rbOut.Checked)
                {
                    inOut = 'O';
                }
                else inOut = 'I';

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblActivity  (cardNumber, cardPurchaseDate, activityDate, activityType, stationID, lineName) values (@TNUMBER, @PDATE, @ADATE, @ATYPE, @SID, @LN)");
                dataCommand.Parameters.AddWithValue("@TNUMBER", long.Parse(cbUserTickets.Text));
                dataCommand.Parameters.AddWithValue("@PDATE", ticketPurchaseDate);
                dataCommand.Parameters.AddWithValue("@ADATE", DateTime.Now);
                dataCommand.Parameters.AddWithValue("@ATYPE", inOut);
                dataCommand.Parameters.AddWithValue("@SID", OriginStationID);
                dataCommand.Parameters.AddWithValue("@LN", cbLins.Text);

                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    Utils.Alerts.dataSavedSuccessfully();
                    mainWindow.Enabled = true;
                    this.Dispose();
                }
                catch (Exception )
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
    }
}
