using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblLine
{
    public partial class frmRemoveLine : Form
    {

        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();

        public frmRemoveLine()
        {
            InitializeComponent();
        }
        public frmRemoveLine(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmRemoveLine_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbLineName;
            Utils.Services.fillComboBoxI(cbLineName, "select name from tblLine", "name");
            groupBox.Visible = false;
        }

        private void cbLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            string type = "";

            dataCommand = new SqlCommand("SELECT * FROM tblLine WHERE name=@LineName", SQLConnection.con);

            dataCommand.Parameters.Add("@LineName", SqlDbType.VarChar).Value = cbLineName.Text;
            dataCommand.Connection = SQLConnection.con;
            SQLConnection.con.Open();
            try
            {
                SqlDataReader sdr = dataCommand.ExecuteReader();

                if (sdr.Read())
                {
                    txtFoundedYear.Text = sdr["foundedYear"].ToString();
                    txtLineLength.Text = sdr["lineLength"].ToString();
                    if (sdr["lineType"].ToString() == "O")
                    {
                        type = "On surface";
                    }
                    else type = "Under surface";
                    txtLineType.Text = type;
                }
                else
                {
                    MessageBox.Show("Please enter a valid item barcode");
                }

            }
            catch (Exception)
            {
                Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
            }
            finally { SQLConnection.con.Close(); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbLineName.Text != "")
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("delete from tblLine where name=@NAME");
                    dataCommand.Parameters.AddWithValue("@NAME", cbLineName.Text);

                    try
                    {
                        SQLConnection.con.Open();
                        dataCommand.ExecuteNonQuery();
                        dataCommand.Parameters.Clear();
                        Utils.Alerts.dataSavedSuccessfully();
                        SQLConnection.con.Close();
                        mainWindow.Enabled = true;
                        this.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        Utils.Alerts.errorMessage("Something is wrong, couldn't delete this record!");

                    }
                    finally { SQLConnection.con.Close(); }
                }
            }
            else Utils.Alerts.errorMessage("You Must choose station number first!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;    
        }

        private void frmRemoveLine_MouseEnter(object sender, EventArgs e)
        {
            if (cbLineName.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no Lines available in system yet");
                mainWindow.Enabled = true;
                this.Dispose();
            }
        }
    }
}
