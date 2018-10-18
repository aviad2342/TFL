using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HW5.Tables.tblLine;
using HW5.Tables.tblStationInLine;
using HW5.Tables.tblOysterCard;
using HW5.Tables.tblSite;
using HW5.Tables.tblPaperCard;
using HW5.Tables.tblSiteFromExit;
using HW5.Tables.tblStation;
using HW5.Tables.tblSiteFromSite;
using HW5.Tables.tblActivity;
using HW5.Tables.tblGeneralParameters;
using HW5.Tables.tblZone;
using HW5.Tables.tblUser;
using HW5.Tables.tblSiteType;
using HW5.Reports;

namespace HW5
{ 
    public partial class frmMain : Form
    {
        
        private string type;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string type)
        {
            InitializeComponent();
            this.type = type;
            createForm(type);
        }

        private void createForm(string type)
        {
            switch (type)
            {
                case "A":
                    
                    break;
                 case "M":
                      cSVToolStripMenuItem.Visible = false;
                      transportToolStripMenuItem.Visible = false;
                      oysterCardToolStripMenuItem.Visible = false;
                      paperCardToolStripMenuItem.Visible = false;
                      sitesToolStripMenuItem.Visible = false;
                      userToolStripMenuItem.Visible = false;
                      siteTypeToolStripMenuItem.Visible = false;
                      break;
                 case "C":
                      reportsToolStripMenuItem.Visible = false;
                      cSVToolStripMenuItem.Visible = false;
                      addToolStripMenuItem.Visible = false;
                       break;
                 case "CE":
                       reportsToolStripMenuItem.Visible = false;
                       stationsToolStripMenuItem.Visible = false;
                       lineToolStripMenuItem.Visible = false;
                       stationLineToolStripMenuItem.Visible = false;
                       oysterCardToolStripMenuItem.Visible = false;
                       paperCardToolStripMenuItem.Visible = false;
                       sitesFromExitToolStripMenuItem.Visible = false;
                       siteNearSiteToolStripMenuItem.Visible = false;
                       oyserDepositRateToolStripMenuItem.Visible = false;
                       zoneToolStripMenuItem.Visible = false;
                       userToolStripMenuItem.Visible = false;
                       transportToolStripMenuItem.Visible = false;
                       break;
                  default:
                       //Do the Default
                     break;
            } 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;

            DateTime test = new DateTime(1 / 1 / 1111);
            if (globals.getGlobals().GetLogedInUser() == null)
            {
                lbUser.Text = "Hi ";
            }
            else if (globals.getGlobals().GetUserLastVisit() == test)
            {
                lbUser.Text = "Hi " + globals.getGlobals().GetLogedInUser();
            }
            else lbUser.Text = "Hi " + globals.getGlobals().GetLogedInUser() + " Your last visit was at " + globals.getGlobals().GetUserLastVisit().ToString("d");
       
              
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tables.tblStation.frmAddStation frmAddStation = new Tables.tblStation.frmAddStation(this);
            frmAddStation.Show();
            this.Enabled = false;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStation.frmFindStations frmFindStations = new Tables.tblStation.frmFindStations(this);
            frmFindStations.Show();
            this.Enabled = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStation.frmUpdateStation frmUpdateStation = new Tables.tblStation.frmUpdateStation(this);
            frmUpdateStation.Show();
            this.Enabled = false;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStation.frmRemoveStation frmRemoveStation = new Tables.tblStation.frmRemoveStation(this);
            frmRemoveStation.Show();
            this.Enabled = false;
        }

        private void remoteSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.RemoteSites frmRemoteSites = new RemoteSites(this);
            frmRemoteSites.Show();
            this.Enabled = false;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LondonCity.frmCsvImportSiteUpdate frmCsvSiteUpdate = new LondonCity.frmCsvImportSiteUpdate(this);
            frmCsvSiteUpdate.Show();
            this.Enabled = false;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LondonCity.frmCsvExportSites frmCsvExportSites = new LondonCity.frmCsvExportSites(this);
            frmCsvExportSites.Show();
            this.Enabled = false;
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedia frmMedia = new frmMedia(this);
            frmMedia.Show();
            this.Enabled = false;
        }
        private void logOurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void addLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblLine.frmAddLine frmAddLine = new frmAddLine(this);
            frmAddLine.Show();
            this.Enabled = false;
        }

        private void UpdateLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblLine.frmUpdateLine frmUpdateLine = new frmUpdateLine(this);
            frmUpdateLine.Show();
            this.Enabled = false;
        }

        private void RemoveLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblLine.frmRemoveLine frmRemoveLine = new frmRemoveLine(this);
            frmRemoveLine.Show();
            this.Enabled = false;
        }

        private void FindLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblLine.frmFindLine frmFindLine = new frmFindLine(this);
            frmFindLine.Show();
            this.Enabled = false;
        }

        private void addStationToLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStationInLine.frmAddStationToLine frmAddStationToLine = new frmAddStationToLine(this);
            frmAddStationToLine.Show();
            this.Enabled = false;
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tables.tblStationInLine.frmRemoveStationFromLine frmRemoveStationFromLine = new frmRemoveStationFromLine(this);
            frmRemoveStationFromLine.Show();
            this.Enabled = false;
        }

        private void findStationLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStationInLine.frmFindStationLines frmFindStationLines = new frmFindStationLines(this);
            frmFindStationLines.Show();
            this.Enabled = false;
        }

        private void newOysterCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Tables.tblOysterCard.frmNewOyserCard frmNewOyserCard = new frmNewOyserCard(this);
            frmNewOyserCard.Show();
            this.Enabled = false;
        }

        private void addSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSite.frmAddSite frmAddSite = new frmAddSite(this);
            frmAddSite.Show();
            this.Enabled = false;
        }

        private void updateSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSite.frmUpdateSite frmUpdateSite = new frmUpdateSite(this);
            frmUpdateSite.Show();
            this.Enabled = false;
        }

        private void removeSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSite.frmRemoveSite frmRemoveSite = new frmRemoveSite(this);
            frmRemoveSite.Show();
            this.Enabled = false;
        }

        private void findSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSite.frmFindSite frmFindSite = new frmFindSite(this);
            frmFindSite.Show();
            this.Enabled = false;
        }

        private void upgradeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblOysterCard.frmUpgradeProgram frmUpgradeProgram = new frmUpgradeProgram(this);
            frmUpgradeProgram.Show();
            this.Enabled = false;
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblOysterCard.frmRenewCard frmRenewCard = new frmRenewCard(this);
            frmRenewCard.Show();
            this.Enabled = false;
        }

        private void newPaperCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblPaperCard.frmNewPaperCard frmNewPaperCard = new frmNewPaperCard(this);
            frmNewPaperCard.Show();
            this.Enabled = false;
        }

        private void addSiteToExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromExit.frmSiteFromExit frmSiteFromExit = new frmSiteFromExit(this);
            frmSiteFromExit.Show();
            this.Enabled = false;
        }

        private void removeSiteFromExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromExit.frmRemoveSiteFromExit frmRemoveSiteFromExit = new frmRemoveSiteFromExit(this);
            frmRemoveSiteFromExit.Show();
            this.Enabled = false;
        }

        private void viewMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStation.frmViewInMap frmViewInMap = new frmViewInMap(this);
            frmViewInMap.Show();
            this.Enabled = false;
        }

        private void addSiteFromSiteStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromSite.frmSiteFromSite frmSiteFromSite = new frmSiteFromSite(this);
            frmSiteFromSite.Show();
            this.Enabled = false;
        }

        private void removeNearbySitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromSite.frmRemoveNearbySites frmRemoveNearbySites = new frmRemoveNearbySites(this);
            frmRemoveNearbySites.Show();
            this.Enabled = false;
        }

        private void updateNearbySitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromSite.frmUpdetNearbySites frmUpdetNearbySites = new frmUpdetNearbySites(this);
            frmUpdetNearbySites.Show();
            this.Enabled = false;
        }

        private void oyterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblOysterCard.frmNewOyserCard frmNewOyserCard = new frmNewOyserCard(this);
            frmNewOyserCard.Show();
            this.Enabled = false;
        }

        private void paperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblPaperCard.frmNewPaperCard frmNewPaperCard = new frmNewPaperCard(this);
            frmNewPaperCard.Show();
            this.Enabled = false;
        }

        private void oyserDepositRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblGeneralParameters.frmAddDepositRate frmAddDepositRate = new frmAddDepositRate(this);
            frmAddDepositRate.Show();
            this.Enabled = false;
        }

        private void upgradeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblOysterCard.frmUpgradeProgram frmUpgradeProgram = new frmUpgradeProgram(this);
            frmUpgradeProgram.Show();
            this.Enabled = false;
        }

        private void renewTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblOysterCard.frmRenewCard frmRenewCard = new frmRenewCard(this);
            frmRenewCard.Show();
            this.Enabled = false;
        }

        private void addZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblZone.frmAddZone frmAddZone = new frmAddZone(this);
            frmAddZone.Show();
            this.Enabled = false;
        }

        private void removeZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblZone.frmRemoveZone frmRemoveZone = new frmRemoveZone(this);
            frmRemoveZone.Show();
            this.Enabled = false;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblUser.frmAddUser frmAddUser = new frmAddUser(this);
            frmAddUser.Show();
            this.Enabled = false;
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblUser.frmRemoveUser frmRemoveUser = new frmRemoveUser(this);
            frmRemoveUser.Show();
            this.Enabled = false;
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblUser.frmUpdateUser frmUpdateUser = new frmUpdateUser(this);
            frmUpdateUser.Show();
            this.Enabled = false;
        }

        private void addSiteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteType.frmAddSiteType frmAddSiteType = new frmAddSiteType(this);
            frmAddSiteType.Show();
            this.Enabled = false;
        }

        private void planARrouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblActivity.frmNewTrainRide frmNewTrainRide = new frmNewTrainRide(this);
            frmNewTrainRide.Show();
            this.Enabled = false;
        }

        private void catchATrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblActivity.frmBoardingAtrain frmBoardingAtrain = new frmBoardingAtrain(this);
            frmBoardingAtrain.Show();
            this.Enabled = false;
        }

        private void updateSiteFromExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromExit.frmUpdateSiteFromExit frmUpdateSiteFromExit = new frmUpdateSiteFromExit(this);
            frmUpdateSiteFromExit.Show();
            this.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void viewStationOnMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblStation.frmViewInMap frmViewInMap = new frmViewInMap(this);
            frmViewInMap.Show();
            this.Enabled = false;
        }

        private void ticketsActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblActivity.frmViewTicketsActivity frmViewTicketsActivity = new frmViewTicketsActivity(this);
            frmViewTicketsActivity.Show();
            this.Enabled = false;
        }

        private void viewSitesNearExitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromExit.frmViewSitesNearSites frmViewSitesNearSites = new frmViewSitesNearSites(this);
            frmViewSitesNearSites.Show();
            this.Enabled = false;
        }

        private void viewNearbySitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables.tblSiteFromSite.frmViewSiteFromSite frmViewSiteFromSite = new frmViewSiteFromSite(this);
            frmViewSiteFromSite.Show();
            this.Enabled = false;
        }

        private void lastYearTrafficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.frmLastYearTraffic frmLastYearTraffic = new frmLastYearTraffic(this);
            frmLastYearTraffic.Show();
            this.Enabled = false;
        }

        private void mostActiveUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.frmMostActiveUser frmMostActiveUser = new frmMostActiveUser(this);
            frmMostActiveUser.Show();
            this.Enabled = false;
        }

        private void misusedTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.BadTicket BadTicket = new BadTicket(this);
            BadTicket.Show();
            this.Enabled = false;
        }

        private void unusedTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.UnusedTicket UnusedTicket = new UnusedTicket(this);
            UnusedTicket.Show();
            this.Enabled = false;
        }

        private void primStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.PrimStations PrimStations = new PrimStations(this);
            PrimStations.Show();
            this.Enabled = false;
        }

        private void mostActiveStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.MostActive MostActive = new MostActive(this);
            MostActive.Show();
            this.Enabled = false;
        }

        private void oysterUsedLastMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.UsedOyster UsedOyster = new UsedOyster(this);
            UsedOyster.Show();
            this.Enabled = false;
        }

        private void profitableYearDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.ShowDeposit ShowDeposit = new ShowDeposit(this);
            ShowDeposit.Show();
            this.Enabled = false;
        }

    }
}
