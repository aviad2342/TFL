namespace HW5.Tables.tblSite
{
    partial class frmRemoveSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveSite));
            this.cbSiteID = new System.Windows.Forms.ComboBox();
            this.lbSiteID = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtFoundedYear = new System.Windows.Forms.TextBox();
            this.txtSiteType = new System.Windows.Forms.TextBox();
            this.lbFoundedYear = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lbSiteName = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.lbSiteDescription = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSiteID
            // 
            this.cbSiteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID.FormattingEnabled = true;
            this.cbSiteID.Location = new System.Drawing.Point(97, 75);
            this.cbSiteID.Name = "cbSiteID";
            this.cbSiteID.Size = new System.Drawing.Size(76, 23);
            this.cbSiteID.TabIndex = 38;
            this.cbSiteID.SelectedIndexChanged += new System.EventHandler(this.cbSiteID_SelectedIndexChanged);
            // 
            // lbSiteID
            // 
            this.lbSiteID.AutoSize = true;
            this.lbSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteID.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSiteID.Location = new System.Drawing.Point(29, 78);
            this.lbSiteID.Name = "lbSiteID";
            this.lbSiteID.Size = new System.Drawing.Size(57, 15);
            this.lbSiteID.TabIndex = 37;
            this.lbSiteID.Text = "Site ID:";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtFoundedYear);
            this.groupBox.Controls.Add(this.txtSiteType);
            this.groupBox.Controls.Add(this.lbFoundedYear);
            this.groupBox.Controls.Add(this.rtxtDescription);
            this.groupBox.Controls.Add(this.lbSiteName);
            this.groupBox.Controls.Add(this.txtSiteName);
            this.groupBox.Controls.Add(this.lbSiteDescription);
            this.groupBox.Controls.Add(this.lbType);
            this.groupBox.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox.Location = new System.Drawing.Point(32, 121);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(509, 239);
            this.groupBox.TabIndex = 36;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Site Details: ";
            this.groupBox.Visible = false;
            // 
            // txtFoundedYear
            // 
            this.txtFoundedYear.BackColor = System.Drawing.Color.White;
            this.txtFoundedYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoundedYear.Enabled = false;
            this.txtFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoundedYear.Location = new System.Drawing.Point(122, 99);
            this.txtFoundedYear.Name = "txtFoundedYear";
            this.txtFoundedYear.Size = new System.Drawing.Size(80, 23);
            this.txtFoundedYear.TabIndex = 32;
            // 
            // txtSiteType
            // 
            this.txtSiteType.BackColor = System.Drawing.Color.White;
            this.txtSiteType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteType.Enabled = false;
            this.txtSiteType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteType.Location = new System.Drawing.Point(122, 69);
            this.txtSiteType.Name = "txtSiteType";
            this.txtSiteType.Size = new System.Drawing.Size(131, 23);
            this.txtSiteType.TabIndex = 31;
            // 
            // lbFoundedYear
            // 
            this.lbFoundedYear.AutoSize = true;
            this.lbFoundedYear.BackColor = System.Drawing.Color.Transparent;
            this.lbFoundedYear.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbFoundedYear.Location = new System.Drawing.Point(6, 102);
            this.lbFoundedYear.Name = "lbFoundedYear";
            this.lbFoundedYear.Size = new System.Drawing.Size(110, 15);
            this.lbFoundedYear.TabIndex = 25;
            this.lbFoundedYear.Text = "Founded Year:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.White;
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Enabled = false;
            this.rtxtDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(122, 135);
            this.rtxtDescription.MaxLength = 150;
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(355, 89);
            this.rtxtDescription.TabIndex = 30;
            this.rtxtDescription.Text = "";
            // 
            // lbSiteName
            // 
            this.lbSiteName.AutoSize = true;
            this.lbSiteName.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteName.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSiteName.Location = new System.Drawing.Point(6, 39);
            this.lbSiteName.Name = "lbSiteName";
            this.lbSiteName.Size = new System.Drawing.Size(85, 15);
            this.lbSiteName.TabIndex = 23;
            this.lbSiteName.Text = "Site Name:";
            // 
            // txtSiteName
            // 
            this.txtSiteName.BackColor = System.Drawing.Color.White;
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Enabled = false;
            this.txtSiteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(122, 36);
            this.txtSiteName.MaxLength = 20;
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(161, 23);
            this.txtSiteName.TabIndex = 29;
            // 
            // lbSiteDescription
            // 
            this.lbSiteDescription.AutoSize = true;
            this.lbSiteDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteDescription.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSiteDescription.Location = new System.Drawing.Point(6, 135);
            this.lbSiteDescription.Name = "lbSiteDescription";
            this.lbSiteDescription.Size = new System.Drawing.Size(89, 15);
            this.lbSiteDescription.TabIndex = 24;
            this.lbSiteDescription.Text = "Description:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbType.Location = new System.Drawing.Point(6, 72);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(45, 15);
            this.lbType.TabIndex = 26;
            this.lbType.Text = "Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(350, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSite.Location = new System.Drawing.Point(146, 388);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(88, 24);
            this.btnAddSite.TabIndex = 34;
            this.btnAddSite.Text = "OK";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Remove Site";
            // 
            // frmRemoveSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.graywallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSiteID);
            this.Controls.Add(this.lbSiteID);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Site";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveSite_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveSite_Load);
            this.MouseEnter += new System.EventHandler(this.frmRemoveSite_MouseEnter);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSiteID;
        private System.Windows.Forms.Label lbSiteID;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtFoundedYear;
        private System.Windows.Forms.TextBox txtSiteType;
        private System.Windows.Forms.Label lbFoundedYear;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lbSiteName;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label lbSiteDescription;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Label label1;
    }
}