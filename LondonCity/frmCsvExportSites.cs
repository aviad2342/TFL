using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace HW5.LondonCity
{
    public partial class frmCsvExportSites : Form
    {
        private Form mainWindow;
        private string folderPath = "";

        public frmCsvExportSites()
        {
            InitializeComponent();
        }

        public frmCsvExportSites(Form m)
        {
            InitializeComponent();
            this.mainWindow = m;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void frmCsvExportSites_Load(object sender, EventArgs e)
        {
            string select = "SELECT ID as siteID,stationID,name,siteDescription,foundedYear,siteType,lineName,distance" 
                            + " FROM tblSite inner join tblSiteFromExit on tblSite.ID = tblSiteFromExit.siteID"
                            + " ORDER BY name,distance";
            ;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select,SQLConnection.con); //c.con is the connection string

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
           // dataGridView1.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                if (writeCSV(dataGridView, txtPath.Text))
                {
                    MessageBox.Show("File exported successfully!", "File Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPath.Text = "";
                    folderPath = "";
                }
                else
                {
                    Utils.Alerts.errorMessage("Something is wrong, export add this data!");
                }
            }
            else
            {
                MessageBox.Show("Please choose destination");
                return;
            }
        }

        public Boolean writeCSV(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile + "/output.csv");

                //write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(gridIn.Columns[i].HeaderText);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

    }
}
