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
    public partial class frmLastYearTraffic : Form
    {
        private Form mainWindow;

        public frmLastYearTraffic()
        {
            InitializeComponent();
        }
        public frmLastYearTraffic(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmLastYearTraffic_Load(object sender, EventArgs e)
        {
            string qry = "select lineName as [Line Name], COUNT(activityDate) as [Last Year Traffic]"
               + " from tblActivity"
               + " where activityDate between dateadd(YEAR,-1,getdate()) and getdate()"
               + " group by lineName"
               + " order by [Last Year Traffic] desc";

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

        private void frmLastYearTraffic_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
