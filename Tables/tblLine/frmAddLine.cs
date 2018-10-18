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
    public partial class frmAddLine : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();

        public frmAddLine()
        {
            InitializeComponent();
        }
        public frmAddLine(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void frmAddLine_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtLineName;
            UpFoundedYear.Maximum = DateTime.Now.Year;
            UpFoundedYear.Value = DateTime.Now.Year;
            cbColors.Items.AddRange(Utils.Services.getColors());
            txtColor.Visible = true;
        }

        private void frmAddLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            char type = 'a';
            // input checks
            if (txtLineName.Text != "" && upLineLength.Value != 0 && cbLineType.Text != "" && cbColors.Text != "")
            {

                if (!Utils.InputValidation.isLetters(txtLineName))
                {
                    Utils.Alerts.errorMessage("Line Name can contains only english letters!");
                    return;
                }
                if (!Utils.InputValidation.checkLength(15, txtLineName))
                {
                    Utils.Alerts.errorMessage("Line Name is to long!");
                    return;
                }
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
                if (SQLConnection.GetDataContextInstance().tblLines.Where(u => u.name == txtLineName.Text && u.foundedYear == int.Parse(UpFoundedYear.Text)
                    && u.lineLength == double.Parse(UpFoundedYear.Text) && u.lineType == type).Any())
                {
                    Utils.Alerts.errorMessage("The record already exists in system!");
                    return;
                }
                if (SQLConnection.GetDataContextInstance().tblLineColors.Where(u => u.name == cbColors.Text).Any())
                {
                    Utils.Alerts.errorMessage("Sorry the color: " + cbColors.Text + " already assign to a line, please try a different color");
                    cbColors.Text = "";
                    return;
                }

                dataCommand.Connection = SQLConnection.con;              
                dataCommand.CommandText = ("insert tblLine (name, foundedYear, lineLength, lineType) values (@NAME, @FY, @LL, @LT)");
                dataCommand.Parameters.AddWithValue("@NAME", txtLineName.Text);
                dataCommand.Parameters.AddWithValue("@FY", UpFoundedYear.Value.ToString());
                dataCommand.Parameters.AddWithValue("@LL", upLineLength.Value.ToString());
                dataCommand.Parameters.AddWithValue("@LT", type);

                dataCommand1.Connection = SQLConnection.con;
                dataCommand1.CommandText = ("insert tblLineColor (name, lineName) values (@CN, @LN)");
                dataCommand1.Parameters.AddWithValue("@CN", cbColors.Text);
                dataCommand1.Parameters.AddWithValue("@LN", txtLineName.Text);


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand1.ExecuteNonQuery();
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

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = System.Drawing.Color.FromName(cbColors.SelectedItem.ToString());
        }
    }
}
