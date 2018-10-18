using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Reports
{
    public partial class BadTicket : Form
    {
        private Form mainWindow;

        public BadTicket()
        {
            InitializeComponent();
        }

        public BadTicket(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void BadTicket_Load(object sender, EventArgs e)
        {
	       string qry = "select A.cardNumber,A.cardPurchaseDate"
               + " from tblActivity A inner join tblStation S on A.stationID=S.ID"
               + " where S.zoneNumber>(select MAX(OCA.zoneNumber)"
               + " from tblOysterCardAreas OCA"
               + " where A.cardNumber=OCA.cardNumber and A.cardPurchaseDate=OCA.cardPurchaseDate)"
               + " UNION"
               + " select A.cardNumber,A.cardPurchaseDate"
               + " from tblActivity A inner join endDates ED on A.cardNumber=ED.cardNumber and A.cardPurchaseDate=ED.cardPurchaseDate"
               + " where A.activityDate>ED.date or A.activityDate<A.cardPurchaseDate"
               + " group by A.cardNumber,A.cardPurchaseDate";


            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, SQLConnection.con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);


                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                dataGridView.AutoGenerateColumns = true;
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = ds.Tables[0];
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Utils.Alerts.errorMessage("Something is wrong, couldn't show this data!");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BadTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
