using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HW5
{
    public partial class frmLogin : Form
    {

        private TFLDataContext TFL;

        private SqlCommand dataCommand = new SqlCommand();

        public frmLogin()
        {
            this.TFL = SQLConnection.GetDataContextInstance();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

                        if (txtUserId.Text == "" || txtPassword.Text == "")
                        {
                            lblError.Text = "Please fill all fields!";
                        }
                        else if (!Utils.InputValidation.isNumbers(txtUserId))
                        {
                            lblError.Text = "User Id must contain only numbers!";
                            txtUserId.Clear();
                            txtUserId.Focus();
                        }
                        else
                        {
                            if (TFL.tblUsers.Where(u => u.UserId == txtUserId.Text && u.UserPassword == txtPassword.Text).Any())
                            {
                    
                                string type = TFL.tblUsers.Where(u => u.UserId == txtUserId.Text && u.UserPassword == txtPassword.Text).FirstOrDefault().UserType;
                                string UserID = TFL.tblUsers.Where(u => u.UserId == txtUserId.Text && u.UserPassword == txtPassword.Text).FirstOrDefault().UserId;
                                string UserName = TFL.tblUsers.Where(u => u.UserId == txtUserId.Text && u.UserPassword == txtPassword.Text).FirstOrDefault().FirstName;
                                globals.getGlobals().SetLogedInUser(UserName);
                                globals.getGlobals().SetLogedInUserID(this.txtUserId.Text);
                                if (TFL.tblUserLogs.Where(u => u.UserID == txtUserId.Text).Any())
                                {
                                    DateTime LV = TFL.tblUserLogs.Where(u => u.UserID == txtUserId.Text).Max(u => u.LogDate);
                                    globals.getGlobals().SettUserLastVisit(LV);
                                }
                                else globals.getGlobals().SettUserLastVisit(new DateTime(1 / 1 / 1111));

                                dataCommand.Connection = SQLConnection.con;
                                dataCommand.CommandText = ("insert tblUserLog (UserID, LogDate) values (@ID, @DATE)");
                                dataCommand.Parameters.AddWithValue("@ID", UserID);
                                dataCommand.Parameters.AddWithValue("@DATE", DateTime.Now);

                                try
                                {
                                    SQLConnection.con.Open();
                                    dataCommand.ExecuteNonQuery();
                                }
                                catch (Exception)
                                {
                                }
                                finally { SQLConnection.con.Close(); }
                                System.Media.SystemSounds.Beep.Play();
                                frmMain frmMain = new frmMain(type);
                                frmMain.Show();
                                this.Visible = false;
                            }
                            else
                            {
                                lblError.Text = "UserId or Password Incorrect!";
                            }
                        }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            txtUserId.Clear();
            txtPassword.Clear();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(this);
            frmRegister.Show();
            this.Enabled = false;  
        }

        private void lbRegister_MouseHover(object sender, EventArgs e)
        {
            //lbRegister.ForeColor = System.Drawing.Color.Blue;
        }

        private void lbRegister_MouseEnter(object sender, EventArgs e)
        {
            lbRegister.ForeColor = System.Drawing.Color.Blue;
        }

        private void lbRegister_MouseLeave(object sender, EventArgs e)
        {
            lbRegister.ForeColor = System.Drawing.Color.Magenta;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserId;
        }

    }
}
