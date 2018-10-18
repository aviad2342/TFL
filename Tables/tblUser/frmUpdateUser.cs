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
    public partial class frmUpdateUser : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        string type;

        public frmUpdateUser()
        {
            InitializeComponent();
        }
        public frmUpdateUser(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            Utils.Services.fillComboBoxI(cbUserID, "select UserId from tblUser", "UserId");
            cbType.Items.Add("Admin");
            cbType.Items.Add("Manager");
            cbType.Items.Add("Customer");
            cbType.Items.Add("City Employee");
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPassword.Enabled = false;
            cbType.Enabled = false;
        }

        private void cbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPassword.Enabled = true;
            cbType.Enabled = true;

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
                            cbType.SelectedIndex = cbType.Items.IndexOf("Admin");
                            break;
                        case "M":
                            cbType.SelectedIndex = cbType.Items.IndexOf("Manager");
                            break;
                        case "C":
                            cbType.SelectedIndex = cbType.Items.IndexOf("Customer");
                            break;
                        case "CE":
                            cbType.SelectedIndex = cbType.Items.IndexOf("City Employee");
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
            // input checks
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cbUserID.Text != "" && txtPassword.Text != "" && cbType.Text != "")
            {

                if (!Utils.InputValidation.isLetters(txtFirstName))
                {
                    Utils.Alerts.errorMessage("First Name can contains only english letters!");
                    txtFirstName.Clear();
                    txtFirstName.Focus();
                    return;
                }
                if (!Utils.InputValidation.checkLength(20, txtFirstName))
                {
                    Utils.Alerts.errorMessage("First Name is to long!");
                    txtFirstName.Clear();
                    txtFirstName.Focus();
                    return;
                }
                if (!Utils.InputValidation.isLetters(txtLastName))
                {
                    Utils.Alerts.errorMessage("Last Name can contains only english letters!");
                    txtLastName.Clear();
                    txtLastName.Focus();
                    return;
                }
                if (!Utils.InputValidation.checkLength(20, txtLastName))
                {
                    Utils.Alerts.errorMessage("Last Name is to long!");
                    txtLastName.Clear();
                    txtLastName.Focus();
                    return;
                }
                if (!Utils.InputValidation.isNumbersLetters(txtPassword))
                {
                    Utils.Alerts.errorMessage("Password must contains english letters And numbers!");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
                if (!Utils.InputValidation.checkLength(20, txtPassword))
                {
                    Utils.Alerts.errorMessage("Password is to long!");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                switch (cbType.Text)
                {
                    case "Admin":
                        type = "A";
                        break;
                    case "Manager":
                        type = "M";
                        break;
                    case "Customer":
                        type = "C";
                        break;
                    case "City Employee":
                        type = "CE";
                        break;
                    default:
                        type = "C";
                        break;
                }


                    dataCommand.Connection = SQLConnection.con;
                    dataCommand.CommandText = ("update tblUser set UserPassword=@PW, FirstName=@FN, LastName=@LN, UserType=@UT where UserId=@UID");
                    dataCommand.Parameters.AddWithValue("@UID", cbUserID.Text);
                    dataCommand.Parameters.AddWithValue("@PW", txtPassword.Text);
                    dataCommand.Parameters.AddWithValue("@FN", txtFirstName.Text);
                    dataCommand.Parameters.AddWithValue("@LN", txtLastName.Text);
                    dataCommand.Parameters.AddWithValue("@UT", type);

                    try
                    {
                        SQLConnection.con.Open();
                        dataCommand.ExecuteNonQuery();
                        Utils.Alerts.dataSavedSuccessfully();
                        mainWindow.Enabled = true;
                        this.Dispose();
                    }
                    catch (Exception)
                    {
                        Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
                    }
                    finally { SQLConnection.con.Close(); }
                }
                else Utils.Alerts.errorMessage("You Must Fill All Fields!!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmUpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
