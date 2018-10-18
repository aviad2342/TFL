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
    public partial class UnusedTicket : Form
    {
        private Form mainWindow;

        public UnusedTicket()
        {
            InitializeComponent();
        }

        public UnusedTicket(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void UnusedTicket_Load(object sender, EventArgs e)
        {
            string qry ="select PC.number, PC.purchaseDate, PC.isTourist,MAX(PCA.zoneNumber) as 'maxZone'" 
                + " FROM dbo.tblPaperCard as PC inner join dbo.tblPaperCardAreas as PCA on PC.number = PCA.cardNumber"
                + " WHERE DATEDIFF(day, PC.purchaseDate, getdate())<60 and PC.number not in("
                    + " select A.cardNumber"
                    + " FROM dbo.tblActivity as A" 
                    + " WHERE DATEDIFF(day, A.activityDate, getdate())<30)"
                + " GROUP BY PC.number, PC.purchaseDate, PC.isTourist";
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

        private void UnusedTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }


    }
}
