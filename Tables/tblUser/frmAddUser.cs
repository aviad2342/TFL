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
    public partial class frmAddUser : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        string type;

        public frmAddUser()
        {
            InitializeComponent();
        }
        public frmAddUser(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserID;
            cbType.Items.Add("Admin");
            cbType.Items.Add("Manager");
            cbType.Items.Add("Customer");
            cbType.Items.Add("City Employee");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input checks
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtUserID.Text != "" && txtPassword.Text != "" && cbType.Text != "")
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
                if (!Utils.InputValidation.isNumbers(txtUserID))
                {
                    Utils.Alerts.errorMessage("User Id must contain only numbers!");
                    txtUserID.Clear();
                    txtUserID.Focus();
                    return;
                }
                if (txtUserID.Text.Length < 9)
                {
                    Utils.Alerts.errorMessage("User Id must contain exactly 9 digitss!");
                    txtUserID.Clear();
                    txtUserID.Focus();
                    return;
                }
                if (!Utils.InputValidation.checkLength(9, txtUserID))
                {
                    Utils.Alerts.errorMessage("User ID is to long!");
                    txtUserID.Clear();
                    txtUserID.Focus();
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
                if (SQLConnection.GetDataContextInstance().tblUsers.Where(u => u.UserId == txtUserID.Text).Any())
                {
                    Utils.Alerts.errorMessage("Sorry the User ID: " + txtUserID.Text + " already exists in system! please try a different one");
                    txtUserID.Clear();
                    txtUserID.Focus();
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
                dataCommand.CommandText = ("insert tblUser (UserId, UserPassword, FirstName, LastName, UserType) values (@UID, @PW, @FN, @LN, @UT)");
                dataCommand.Parameters.AddWithValue("@UID", txtUserID.Text);
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

        private void frmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
