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
    public partial class frmUpdateLine : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();

        public frmUpdateLine()
        {
            InitializeComponent();
        }
        public frmUpdateLine(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmUpdateLine_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbLineName;
            Utils.Services.fillComboBoxI(cbLineName, "select name from tblLine", "name");
            cbColors.Items.AddRange(Utils.Services.getColors());
            groupBox.Visible = false;
        }

        private void cbLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            txtColor.Visible = true;
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
                    UpFoundedYear.Text = sdr["foundedYear"].ToString();
                    upLineLength.Text = sdr["lineLength"].ToString();
                    if (sdr["lineType"].ToString() == "O")
                    {
                        type = "On surface";
                    }
                    else type = "Under surface";
                    cbLineType.SelectedIndex = cbLineType.Items.IndexOf(type);
                }
                else
                {
                    MessageBox.Show("Please enter a valid item barcode");
                }

            }
            catch (Exception)
            {
                Utils.Alerts.errorMessage("Something is wrong, couldn't get this data!");
            }
         SQLConnection.con.Close();

           dataCommand1 = new SqlCommand("SELECT * FROM tblLineColor WHERE lineName=@LineName", SQLConnection.con);
           dataCommand1.Parameters.Add("@LineName", SqlDbType.VarChar).Value = cbLineName.Text;
           dataCommand1.Connection = SQLConnection.con;

            SQLConnection.con.Open();
            try
            {
                SqlDataReader sdr = dataCommand1.ExecuteReader();
                if (sdr.Read())
                {
                    cbColors.SelectedIndex = cbColors.Items.IndexOf(sdr["name"].ToString());
                }
                else
                {
                    MessageBox.Show("Please enter a valid item barcode");
                }
                
            }
            catch (Exception)
            {
                Utils.Alerts.errorMessage("Something is wrong, couldn't get this data!");
            }
            finally { SQLConnection.con.Close(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char type = 'a';
            // input checks
            if (cbLineName.Text == "")
            {
                Utils.Alerts.errorMessage("You Must Choose Line Name first!!");
                return;
            }
            if (cbLineName.Text != "" && UpFoundedYear.Text != "" && upLineLength.Text != "" && cbLineType.Text != "" && cbColors.Text != "")
            {
        
                if (cbLineType.Text == "On surface")
                {
                    type = 'O';
                }
                else
                {
                    type = 'U';
                }
                if (upLineLength.Value == 0)
                {
                    Utils.Alerts.errorMessage("Line Length cant be 0!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblLines.Where(u => u.name == cbLineName.Text && u.foundedYear == int.Parse(UpFoundedYear.Text)
                    && u.lineLength == double.Parse(UpFoundedYear.Text) && u.lineType == type).Any())
                {
                    Utils.Alerts.errorMessage("The record already exists in system!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblLineColors.Where(u => u.lineName == cbLineName.Text).FirstOrDefault().name != cbColors.Text)
                {
                    if (SQLConnection.GetDataContextInstance().tblLineColors.Where(u => u.name == cbColors.Text).Any())
                    {
                        Utils.Alerts.errorMessage("Sorry the color: " + cbColors.Text + " already assign to a line, please try a different color");
                        cbColors.Text = "";
                        return;
                    }
                }

                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("update tblLine set foundedYear=@FY, lineLength=@LL, lineType=@LT where name=@NAME");
                dataCommand.Parameters.AddWithValue("@NAME", cbLineName.Text);
                dataCommand.Parameters.AddWithValue("@FY", UpFoundedYear.Value.ToString());
                dataCommand.Parameters.AddWithValue("@LL", upLineLength.Value.ToString());
                dataCommand.Parameters.AddWithValue("@LT", type);

                dataCommand1.Connection = SQLConnection.con;
                dataCommand1.CommandText = ("update tblLineColor set name=@CN where lineName=@LN");
                dataCommand1.Parameters.AddWithValue("@CN", cbColors.Text);
                dataCommand1.Parameters.AddWithValue("@LN", cbLineName.Text);

                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand1.ExecuteNonQuery();
                    dataCommand.Parameters.Clear();
                    dataCommand1.Parameters.Clear();
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

        private void frmUpdateLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbColors.Text == "Grey")
                {
                    txtColor.BackColor = System.Drawing.Color.Gray;
                }
                else txtColor.BackColor = System.Drawing.Color.FromName(cbColors.Text);
            }
            catch (Exception)
            {
                 
            }
            
        }

        private void frmUpdateLine_MouseEnter(object sender, EventArgs e)
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
