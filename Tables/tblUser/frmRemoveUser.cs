using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5.Tables.tblUser
{
    public partial class frmRemoveUser : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        string type;

        public frmRemoveUser()
        {
            InitializeComponent();
        }
        public frmRemoveUser(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmRemoveUser_Load(object sender, EventArgs e)
        {
            groupBox.Visible = false;
            Utils.Services.fillComboBoxI(cbUserID, "select UserId from tblUser", "UserId");
        }

        private void cbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;

            dataCommand = new SqlCommand("SELECT * FROM tblUser WHERE UserId=@USERID", SQLConnection.con);
            dataCommand.Parameters.Add("@USERID", SqlDbType.VarChar).Value = cbUserID.Text;
            dataCommand.Connection = SQLConnection.con;
            SQLConnection.con.Open();
            try
            {
                SqlDataReader sdr = dataCommand.ExecuteReader();

                if (sdr.Read())
                {
                    txtFirstName.Text = sdr["FirstName"].ToString();
                    txtLastName.Text = sdr["LastName"].ToString();
                    txtPassword.Text = sdr["UserPassword"].ToString();
                    type = sdr["UserType"].ToString();

                    switch (type)
                    {
                        case "A":
                            txtType.Text = "Admin";
                            break;
                        case "M":
                            txtType.Text = "Manager";
                            break;
                        case "C":
                            txtType.Text = "Customer";
                            break;
                        case "CE":
                            txtType.Text = "City Employee";
                            break;
                        default:
                            
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry No User Found");
                }
            }
            catch (Exception)
            {
                Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
            }
            finally { SQLConnection.con.Close(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbUserID.Text != "")
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {

                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("delete from tblUser where UserId=@USERID1");
                    dataCommand.Parameters.AddWithValue("@USERID1", cbUserID.Text);

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
            else Utils.Alerts.errorMessage("You Must choose User ID first!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmRemoveUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
