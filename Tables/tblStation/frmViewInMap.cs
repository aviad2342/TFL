using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Tables.tblStation
{
    public partial class frmViewInMap : Form
    {
        private Form mainWindow { get; set; }

        public frmViewInMap()
        {
            InitializeComponent();
        }
        public frmViewInMap(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmViewInMap_Load(object sender, EventArgs e)
        {
            Utils.Services.fillComboBoxI(cbStationName, "select name from tblStation", "name");
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void cbStationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string station = "underground " + cbStationName.Text + " station";
            StringBuilder add = new StringBuilder("http://maps.google.com/?q=");

            add.Append(station);
            
            webBrowser.Navigate(add.ToString());

           
            
        }

        private void frmViewInMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
