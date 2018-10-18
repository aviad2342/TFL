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
    public partial class UsedOyster : Form
    {
        private Form mainWindow;

        public UsedOyster()
        {
            InitializeComponent();
        }

        public UsedOyster(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void UsedOyster_Load(object sender, EventArgs e)
        {

            string qry =  "select A.cardNumber, count(A.cardNumber) / 2 as 'NumOfTrip'"
                        + " FROM dbo.tblActivity A"
                        + " WHERE A.cardNumber in("
                            + " select A1.cardNumber"
                            + " FROM dbo.tblActivity as A1"
                            + " WHERE DATEDIFF(month, A1. activityDate, getdate()) = 0 and A1. activityType = 'I' and exists ("
                                + " select A2.cardNumber"
                                + " FROM dbo.tblActivity as A2"
                                + " WHERE (convert(varchar(10), A2.activityDate,120) = convert(varchar(10), A1.activityDate,120) and (activityType = 'O') and A1.cardNumber = A2.cardNumber))"
                            + " GROUP BY A1.cardNumber"
                            + " HAVING COUNT(A1.activityDate) > 19) and not exists ("
                                + " select ACA.cardNumber"
                                + " FROM dbo.tblOysterCardAreas as ACA"
                                + " WHERE ((ACA.cardNumber = A.cardNumber) and (ACA.cardLength IN('1', ' 3', ' W'))))"
                        + " GROUP BY A.cardNumber"
                        + " ORDER BY NumOfTrip desc";
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

        private void UsedOyster_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }


    }
}
