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
    public partial class frmNewTrainRide : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();
        DateTime ticketPurchaseDate;
        DateTime ticketExpirationDate;
        string OriginStationID;
        string DestinationStationID;
        string ticketProgramDays;
        char ticketMaxZone;
        char ticketLength;

        public frmNewTrainRide()
        {
            InitializeComponent();
        }
        public frmNewTrainRide(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmNewTrainRide_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbUserTickets;

            OrigintimePicker.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString() + " 05:00:00");
            DestinationtimePicker.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString() + " 05:00:00");

            OrigintimePicker.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString() + " 23:00:00");
            DestinationtimePicker.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString() + " 23:59:00");

            OrigintimePicker.Value = DateTime.Now;
            DestinationtimePicker.Value = DateTime.Now;

            cbOriginStstion.Enabled = false;
            cbDestinationSation.Enabled = false;
            OrigintimePicker.Enabled = false;
            DestinationtimePicker.Enabled = false;
            cbLins.Enabled = false;

            Utils.Services.fillComboBoxI(cbUserTickets, "select distinct number from tblUserCard where UserID = " + globals.getGlobals().GetLogedInUserID(), "number");
        }

        private void frmNewTrainRide_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void cbUserTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLins.Items.Clear();
            cbDestinationSation.Items.Clear();
            cbOriginStstion.Items.Clear();
            cbOriginStstion.Enabled = true;
            OrigintimePicker.Enabled = true;
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
            cbDestinationSation.Enabled = true;
            DestinationtimePicker.Enabled = true;

            OriginStationID = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.name == cbOriginStstion.Text).FirstOrDefault().ID.ToString();
            cbLins.Items.Clear();
            cbDestinationSation.Items.Clear();
            string qry = "select distinct name from tblStationInLine join tblStation on stationID = ID  where lineName in(select lineName from tblStationInLine join tblStation on stationID = ID where name = '" + cbOriginStstion.Text + "')";
            Utils.Services.fillComboBoxI(cbDestinationSation, qry, "name");
            cbDestinationSation.Items.Remove(cbOriginStstion.Text);
        }

        private void cbDestinationSation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLins.Enabled = true;
            DestinationStationID = SQLConnection.GetDataContextInstance().tblStations.Where(u => u.name == cbDestinationSation.Text).FirstOrDefault().ID.ToString();
            cbLins.Items.Clear();
            string qry1 = "select lineName from tblStationInLine  where stationID = " + OriginStationID + " intersect select lineName from tblStationInLine where stationID = " + DestinationStationID;
            Utils.Services.fillComboBoxI(cbLins, qry1, "lineName");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (OrigintimePicker.Value > DestinationtimePicker.Value)
            {
                Utils.Alerts.errorMessage("Sorry the Destination arrival time must be after Origin time! ");
                return;
            }

            if (cbUserTickets.Text != "" && cbOriginStstion.Text != "" && cbDestinationSation.Text != "" && cbLins.Text != "")
            {

                if (SQLConnection.GetDataContextInstance().tblActivities.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text) && u.cardPurchaseDate == ticketPurchaseDate
                    && u.activityDate == OrigintimePicker.Value).Any())
                {
                    Utils.Alerts.errorMessage("This Ticket have an order for this time!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblActivities.Where(u => u.cardNumber == long.Parse(cbUserTickets.Text) && u.cardPurchaseDate == ticketPurchaseDate
                    && u.activityDate == DestinationtimePicker.Value).Any())
                {
                    Utils.Alerts.errorMessage("This Ticket have an order for this time!");
                    return;
                }


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblActivity  (cardNumber, cardPurchaseDate, activityDate, activityType, stationID, lineName) values (@TNUMBER, @PDATE, @ADATE, @ATYPE, @SID, @LN)");
                dataCommand.Parameters.AddWithValue("@TNUMBER", long.Parse(cbUserTickets.Text));
                dataCommand.Parameters.AddWithValue("@PDATE", ticketPurchaseDate);
                dataCommand.Parameters.AddWithValue("@ADATE", OrigintimePicker.Value);
                dataCommand.Parameters.AddWithValue("@ATYPE", 'I');
                dataCommand.Parameters.AddWithValue("@SID", int.Parse(OriginStationID));
                dataCommand.Parameters.AddWithValue("@LN", cbLins.Text);

                dataCommand1.Connection = SQLConnection.con;
                dataCommand1.CommandText = ("insert tblActivity  (cardNumber, cardPurchaseDate, activityDate, activityType, stationID, lineName) values (@TNUMBER1, @PDATE1, @ADATE1, @ATYPE1, @SID1, @LN1)");
                dataCommand1.Parameters.AddWithValue("@TNUMBER1", long.Parse(cbUserTickets.Text));
                dataCommand1.Parameters.AddWithValue("@PDATE1", ticketPurchaseDate);
                dataCommand1.Parameters.AddWithValue("@ADATE1", DestinationtimePicker.Value);
                dataCommand1.Parameters.AddWithValue("@ATYPE1", 'O');
                dataCommand1.Parameters.AddWithValue("@SID1", int.Parse(DestinationStationID));
                dataCommand1.Parameters.AddWithValue("@LN1", cbLins.Text);


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand1.ExecuteNonQuery();
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
    }
}
