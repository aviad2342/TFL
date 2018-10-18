namespace HW5.Tables.tblStation
{
    partial class frmViewInMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewInMap));
            this.cbStationName = new System.Windows.Forms.ComboBox();
            this.lbStationName = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbStationName
            // 
            this.cbStationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationName.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbStationName.FormattingEnabled = true;
            this.cbStationName.Location = new System.Drawing.Point(132, 14);
            this.cbStationName.Name = "cbStationName";
            this.cbStationName.Size = new System.Drawing.Size(134, 23);
            this.cbStationName.TabIndex = 4;
            this.cbStationName.SelectedIndexChanged += new System.EventHandler(this.cbStationName_SelectedIndexChanged);
            // 
            // lbStationName
            // 
            this.lbStationName.AutoSize = true;
            this.lbStationName.BackColor = System.Drawing.Color.Transparent;
            this.lbStationName.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbStationName.Location = new System.Drawing.Point(12, 15);
            this.lbStationName.Name = "lbStationName";
            this.lbStationName.Size = new System.Drawing.Size(114, 16);
            this.lbStationName.TabIndex = 3;
            this.lbStationName.Text = "Station Name:";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 43);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(973, 584);
            this.webBrowser.TabIndex = 5;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // frmViewInMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.BGshow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 627);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.cbStationName);
            this.Controls.Add(this.lbStationName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewInMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Map:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewInMap_FormClosing);
            this.Load += new System.EventHandler(this.frmViewInMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStationName;
        private System.Windows.Forms.Label lbStationName;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}