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
    public partial class frmMostActiveUser : Form
    {
        private Form mainWindow;

        public frmMostActiveUser()
        {
            InitializeComponent();
        }
        public frmMostActiveUser(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmMostActiveUser_Load(object sender, EventArgs e)
        {
            string qry = "select FirstName as [First Name], LastName as [Last Name], COUNT(LogDate) AS [Number Of Logs]"
               + " from tblUser join tblUserLog on tblUser.UserId = tblUserLog.UserID"
               + " group by FirstName, LastName";

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

        private void frmMostActiveUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
