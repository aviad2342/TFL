using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5
{
    public partial class frmMedia : Form
    {
        private Form mainWindow { get; set; }

        public frmMedia()
        {
            InitializeComponent();
        }
        public frmMedia(Form m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void frmMedia_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Enabled = true;
        }
    }
}
