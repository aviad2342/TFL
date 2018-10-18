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
using Microsoft.VisualBasic.FileIO;

namespace HW5.LondonCity
{
    public partial class frmCsvImportSiteUpdate : Form
    {
        private Form mainWindow;
        private string filePath = "";
        private SqlCommand dataCommand = new SqlCommand();
        private BindingSource bs = new BindingSource();
        private int counter = 0;

        public frmCsvImportSiteUpdate()
        {
            InitializeComponent();
        }

        public frmCsvImportSiteUpdate(Form m)
        {
            InitializeComponent();
            openFileDialog.Filter = "CSV files (*.csv) | *.csv";
            openFileDialog.FileName = "";
            this.mainWindow = m;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
	        DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.filePath = txtPath.Text = openFileDialog.FileName;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.filePath != "")
            {
                
                    if (File.ReadAllText(this.filePath) != "")
                    {
                        ReadCsvFile(filePath);
                    }
                    else
                    { 
                        //TODO file content is empty - show message! 
                        MessageBox.Show("file content is empty!", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            else
            {
                MessageBox.Show("you must choose a directory first!", "Directory Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadCsvFile(string path)
        {
            
            //String[] csv = File.ReadAllLines(path);

            //foreach (string csvrow in csv)
            //{
            //    var fields = csvrow.Split(','); // csv delimiter
            //    InsertDatabase(fields[0], fields[1], fields[2], fields[3]);

            //}

            TextFieldParser parser = new TextFieldParser(path);

            parser.Delimiters = new string[] { "," };
            while (true)
            {
                string[] fields = parser.ReadFields();
                if (fields == null)
                {
                    break;
                }
                if (InsertDatabase(fields[0], fields[1], fields[2], fields[3]))
                {
                    this.counter++;
                    continue;
                }
                else if (Utils.InputValidation.checkStringLength(20, fields[0]))
                {
                    MessageBox.Show("Sorry the name: " + fields[0] + " is to long!", "Format Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                else if (fields[3] != "Museum" || fields[3] != "museum")
                {
                  MessageBox.Show("Sorry failed to add the site: " + fields[0] + " due to incurred site Type: " + fields[3], "Format Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  continue;
                }
                else if (Utils.InputValidation.isStringPositiveNumeric(fields[2]))
                {
                    MessageBox.Show("Sorry failed to add the site: " + fields[0] + " due to incurred Founded Year: " + fields[2], "Format Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                 else if (Utils.InputValidation.checkStringLength(150,fields[1]))
                {
                 MessageBox.Show("Sorry failed to add the site: " + fields[0] + " the Description is to long!", "Format Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 continue;
                }
                else if (SQLConnection.GetDataContextInstance().tblSites.Where(u => u.name == fields[0] && u.siteDescription == fields[1] && u.foundedYear == int.Parse(fields[2]) && u.siteType == fields[3]).Any())
                {
                    Utils.Alerts.errorMessage("The record: " + fields[0] + fields[1] + fields[2] + fields[3] + " already exists in system!");
                    continue;
                }
                else
                {
                  MessageBox.Show("Sorry failed to add the site: " + fields[0] + " due to fismatch data format", "Format Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  continue;
                }
            }

            if (counter != 0) // check if at least one record from CSV file is inserted to the table
            {
                Utils.Alerts.dataSavedSuccessfully();
                this.filePath = "";
                txtPath.Text = "";
                this.counter = 0;
            }            
            else Utils.Alerts.errorMessage("data from CSV file is already exists in the system!!");

            Utils.GridViewRefresh.RefreshTable(this.bs, dataGridView, "tblSite");

        }

        private Boolean InsertDatabase(string siteName, string siteDesc, string siteFoundedYear, string siteType)
        {

            
            if (Utils.InputValidation.checkIfStringLetters(siteName)
                && Utils.InputValidation.isStringPositiveNumeric(siteFoundedYear)
                && Utils.InputValidation.checkStringLength(20,siteName)
                && Utils.InputValidation.checkStringLength(150, siteDesc)
                &&(siteType == "Museum" || siteType == "museum"))
            {
             if (SQLConnection.GetDataContextInstance().tblSites.Where(u => u.name == siteName && u.siteDescription == siteDesc && u.foundedYear == int.Parse(siteFoundedYear) && u.siteType == siteType).Any())
              {
               Utils.Alerts.errorMessage("The record already exists in system!");
               return false;
              }


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblSite (name, siteDescription, foundedYear, siteType) values (@NAME, @SD, @SFY, @ST)");
                dataCommand.Parameters.AddWithValue("@NAME", siteName);
                dataCommand.Parameters.AddWithValue("@SD", siteDesc);
                dataCommand.Parameters.AddWithValue("@SFY", Convert.ToInt16(siteFoundedYear));
                dataCommand.Parameters.AddWithValue("@ST", siteType);


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand.Parameters.Clear();

                }
                catch (Exception)
                {
                return false;
                }
                finally { SQLConnection.con.Close(); }
                return true;
            }
            else
            {
                return false;
            }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmCsvImportSiteUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmCsvImportSiteUpdate_Load(object sender, EventArgs e)
        {

        }
        
    }
}
