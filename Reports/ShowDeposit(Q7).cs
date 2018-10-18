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
    public partial class ShowDeposit : Form
    {
        private Form mainWindow;

        public ShowDeposit()
        {
            InitializeComponent();
        }

        public ShowDeposit(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void ShowDeposit_Load(object sender, EventArgs e)
        {
	       string qry = "select year(A.activityDate),"
               + " case when NOR.[num of rides for Oyster] is null then 'Low'"
               + " when NOR.[num of rides for Oyster] = COUNT(*) then 'High'"
               + " when (cast(NOR.[num of rides for Oyster] as float)/COUNT(*))<0.2 then 'Low'"
               + " when (cast(NOR.[num of rides for Oyster] as float)/COUNT(*))<0.6 then 'Medium'"
               + " when (cast(NOR.[num of rides for Oyster] as float)/COUNT(*))>=0.6 then 'High'"
               + " end as 'how many oysters'"
               + " from tblActivity A left outer join NumOfOysterRides NOR on year(A.activityDate) = NOR.theYear, yearsWithMoreThan5000 YM"
               + " where (year(A.activityDate)>=YM.depositStartYear and year(A.activityDate)<=YM.depositEndYear)"
               + " group by year(A.activityDate), NOR.[num of rides for Oyster]";

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

        private void ShowDeposit_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }


    }
}
