using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HW5.Tables.tblOysterCard
{
    public partial class frmNewOyserCard : Form
    {
        private Form mainWindow { get; set; }
        private SqlCommand dataCommand = new SqlCommand();
        private SqlCommand dataCommand1 = new SqlCommand();
        private SqlCommand dataCommand2 = new SqlCommand();
        private SqlCommand dataCommand3 = new SqlCommand();
        private static string imagLoc = "";

        public frmNewOyserCard()
        {
            InitializeComponent();
        }
        public frmNewOyserCard(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        public static void setPic(string p)
        {
            imagLoc = p;
        }
        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            Tables.tblOysterCard.ViewPictures ViewPictures = new ViewPictures(this);
            ViewPictures.Show();
            this.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.Enabled = true;
            this.Dispose();
        }

        private void frmNewOyserCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void frmNewOyserCard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbZoneNumber;
            Utils.Services.fillComboBoxI(cbZoneNumber, "select number from tblZone", "number");
            imagLoc = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            char Length = 'a';
            // input checks
            if (cbZoneNumber.Text != "" && cbCardLength.Text != "")
            {

                if (cbCardLength.Text == "Day")
                {
                    Length = 'D';
                }
                else if (cbCardLength.Text == "3 Days")
                {
                    Length = 'S';
                }
                else if (cbCardLength.Text == "Week")
                {
                    Length = 'W';
                }
                else if (cbCardLength.Text == "Month")
                {
                    Length = 'M';
                }
                else if (cbCardLength.Text == "3 Months")
                {
                    Length = 'T';
                }
                else if (cbCardLength.Text == "Year")
                {
                    Length = 'Y';
                }

                long cardNumber = SQLConnection.GetDataContextInstance().tblCards.Max(u => u.number)+1;
                DateTime purchaseDate = DateTime.Now;


                dataCommand.Connection = SQLConnection.con;
                dataCommand.CommandText = ("insert tblCard (number, purchaseDate) values (@NUMBER, @DATE)");
                dataCommand.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand.Parameters.AddWithValue("@DATE", purchaseDate);

                dataCommand3.Connection = SQLConnection.con;
                dataCommand3.CommandText = ("insert tblUserCard (UserID, number, purchaseDate) values (@UID, @NUMBER, @DATE)");
                dataCommand3.Parameters.AddWithValue("@UID", globals.getGlobals().GetLogedInUserID());
                dataCommand3.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand3.Parameters.AddWithValue("@DATE", purchaseDate);
                

                if (imagLoc != "")
                {
                    FileStream fs = new FileStream(imagLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    dataCommand1.Connection = SQLConnection.con;
                    dataCommand1.CommandText = ("insert tblOysterCard (number, purchaseDate, picture) values (@NUMBER, @DATE, @PIC)");
                    dataCommand1.Parameters.AddWithValue("@NUMBER", cardNumber);
                    dataCommand1.Parameters.AddWithValue("@DATE", purchaseDate);
                    dataCommand1.Parameters.AddWithValue("@PIC", img);
                }
                else
                {
                    dataCommand1.Connection = SQLConnection.con;
                    dataCommand1.CommandText = ("insert tblOysterCard (number, purchaseDate) values (@NUMBER, @DATE)");
                    dataCommand1.Parameters.AddWithValue("@NUMBER", cardNumber);
                    dataCommand1.Parameters.AddWithValue("@DATE", purchaseDate);
                }
                dataCommand2.Connection = SQLConnection.con;
                dataCommand2.CommandText = ("insert tblOysterCardAreas (cardNumber,cardPurchaseDate, zoneNumber, cardLength) values (@NUMBER, @DATE, @ZONE, @L)");
                dataCommand2.Parameters.AddWithValue("@NUMBER", cardNumber);
                dataCommand2.Parameters.AddWithValue("@DATE", purchaseDate);
                dataCommand2.Parameters.AddWithValue("@ZONE", cbZoneNumber.Text);
                dataCommand2.Parameters.AddWithValue("@L", Length);


                try
                {
                    SQLConnection.con.Open();
                    dataCommand.ExecuteNonQuery();
                    dataCommand3.ExecuteNonQuery();
                    dataCommand1.ExecuteNonQuery();
                    dataCommand2.ExecuteNonQuery();
                    dataCommand.Parameters.Clear();
                    dataCommand3.Parameters.Clear();
                    dataCommand1.Parameters.Clear();
                    dataCommand2.Parameters.Clear();
                    Utils.Alerts.dataSavedSuccessfully();
                    mainWindow.Enabled = true;
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Utils.Alerts.errorMessage("Something is wrong, couldn't add this data!");
                }
                finally { SQLConnection.con.Close(); }
            }
            else Utils.Alerts.errorMessage("You Must Fill All Fields!!");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog flg = new OpenFileDialog();
                flg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                flg.Title = "Select Picture";

                if (flg.ShowDialog() == DialogResult.OK)
                {
                    imagLoc = flg.FileName.ToString();
                    pictureBox.ImageLocation = imagLoc;
                    pictureBox.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNewOyserCard_Activated(object sender, EventArgs e)
        {
            if (imagLoc != "")
            {
                pictureBox.ImageLocation = imagLoc;
                pictureBox.Visible = true;
            }
        }

        private void frmNewOyserCard_MouseEnter(object sender, EventArgs e)
        {
            if (cbZoneNumber.Items.Count == 0)
            {
                Utils.Alerts.errorMessage("Sorry no zones available in system yet");
                mainWindow.Enabled = true;
                this.Close();
            }
        }

    }
}
