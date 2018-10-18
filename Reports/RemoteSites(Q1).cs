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
    public partial class RemoteSites : Form
    {
        private Form mainWindow;

        public RemoteSites()
        {
            InitializeComponent();
        }

        public RemoteSites(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void RemoteSites_Load(object sender, EventArgs e)
        {

        
            string qry = "select S.siteType, AVG(S.foundedYear) as 'average founded year',"
               + " COUNT(S.ID) as 'num of sites'"
               + " FROM tblSite S left outer join tblSiteFromExit SFE on S.ID=SFE.siteID"
               + " left outer join tblSiteFromSite SFS on (S.ID=SFS.siteID1 or S.ID=SFS.siteID2)"
               + " WHERE SFE.siteID is null and SFS.siteID1 is null and (S.siteType like '%s%m%')"
               + " GROUP BY S.siteType"
               + " ORDER BY 'average founded year' desc";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, SQLConnection.con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);  
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void RemoteSites_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }


    }
}
