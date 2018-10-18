using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HW5.Tables.tblOysterCard
{
    public partial class ViewPictures : Form
    {
        string selectedPic;

        private Form mainWindow { get; set; }

        public ViewPictures()
        {
            InitializeComponent();
        }
        public ViewPictures(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }
        private void ViewPictures_Load(object sender, EventArgs e)
        {
           int i = 0;
           string[] dirs = Directory.GetFiles(@"C:\Users\Public\Pictures\Sample Pictures").Where(u => u.EndsWith(".jpg")).ToArray();
           for (i = 0; i < imageList.Images.Count; i++)
              {
                listView.Items.Add(dirs[i], i);
              }
            listView.View = View.LargeIcon;
        }

        private void ViewPictures_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.Items[0].Selected == true)
            {
                selectedPic = listView.Items[0].Text;
            }
            else if (listView.Items[1].Selected == true)
            {
                selectedPic = listView.Items[1].Text;
            }
            else if (listView.Items[2].Selected == true)
            {
                selectedPic = listView.Items[2].Text;
            }
            else if (listView.Items[3].Selected == true)
            {
                selectedPic = listView.Items[3].Text;
            }
            else if (listView.Items[4].Selected == true)
            {
                selectedPic = listView.Items[4].Text;
            }
            else if (listView.Items[5].Selected == true)
            {
                selectedPic = listView.Items[5].Text;
            }
            else if (listView.Items[6].Selected == true)
            {
                selectedPic = listView.Items[6].Text;
            }
            else if (listView.Items[7].Selected == true)
            {
                selectedPic = listView.Items[7].Text;
            }
            mainWindow.Enabled = true;
            Tables.tblOysterCard.frmNewOyserCard.setPic(this.selectedPic);
            this.Dispose();
        }

    }
}
