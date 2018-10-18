namespace HW5.Tables.tblSite
{
    partial class frmUpdateSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSite));
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.cbSiteType = new System.Windows.Forms.ComboBox();
            this.UpFoundedYear = new System.Windows.Forms.NumericUpDown();
            this.lbType = new System.Windows.Forms.Label();
            this.lbFoundedYear = new System.Windows.Forms.Label();
            this.lbSiteDescription = new System.Windows.Forms.Label();
            this.lbSiteName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbSiteID = new System.Windows.Forms.Label();
            this.cbSiteID = new System.Windows.Forms.ComboBox();
            this.lbUpdateSite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(122, 135);
            this.rtxtDescription.MaxLength = 150;
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(355, 89);
            this.rtxtDescription.TabIndex = 30;
            this.rtxtDescription.Text = "";
            // 
            // txtSiteName
            // 
            this.txtSiteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(122, 36);
            this.txtSiteName.MaxLength = 20;
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(153, 23);
            this.txtSiteName.TabIndex = 29;
            // 
            // cbSiteType
            // 
            this.cbSiteType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSiteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteType.FormattingEnabled = true;
            this.cbSiteType.Location = new System.Drawing.Point(122, 69);
            this.cbSiteType.Name = "cbSiteType";
            this.cbSiteType.Size = new System.Drawing.Size(114, 23);
            this.cbSiteType.TabIndex = 28;
            // 
            // UpFoundedYear
            // 
            this.UpFoundedYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpFoundedYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpFoundedYear.Location = new System.Drawing.Point(122, 99);
            this.UpFoundedYear.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.UpFoundedYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpFoundedYear.Name = "UpFoundedYear";
            this.UpFoundedYear.ReadOnly = true;
            this.UpFoundedYear.Size = new System.Drawing.Size(60, 23);
            this.UpFoundedYear.TabIndex = 27;
            this.UpFoundedYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(347, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSite.Location = new System.Drawing.Point(143, 391);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(88, 24);
            this.btnAddSite.TabIndex = 21;
            this.btnAddSite.Text = "OK";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lbFoundedYear);
            this.groupBox.Controls.Add(this.rtxtDescription);
            this.groupBox.Controls.Add(this.lbSiteName);
            this.groupBox.Controls.Add(this.txtSiteName);
            this.groupBox.Controls.Add(this.lbSiteDescription);
            this.groupBox.Controls.Add(this.cbSiteType);
            this.groupBox.Controls.Add(this.lbType);
            this.groupBox.Controls.Add(this.UpFoundedYear);
            this.groupBox.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox.Location = new System.Drawing.Point(29, 124);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(509, 239);
            this.groupBox.TabIndex = 31;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Site Details: ";
            this.groupBox.Visible = false;
            // 
            // lbSiteID
            // 
            this.lbSiteID.AutoSize = true;
            this.lbSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteID.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSiteID.Location = new System.Drawing.Point(26, 81);
            this.lbSiteID.Name = "lbSiteID";
            this.lbSiteID.Size = new System.Drawing.Size(57, 15);
            this.lbSiteID.TabIndex = 32;
            this.lbSiteID.Text = "Site ID:";
            // 
            // cbSiteID
            // 
            this.cbSiteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID.FormattingEnabled = true;
            this.cbSiteID.Location = new System.Drawing.Point(94, 78);
            this.cbSiteID.Name = "cbSiteID";
            this.cbSiteID.Size = new System.Drawing.Size(76, 23);
            this.cbSiteID.TabIndex = 33;
            this.cbSiteID.SelectedIndexChanged += new System.EventHandler(this.cbSiteID_SelectedIndexChanged);
            // 
            // lbUpdateSite
            // 
            this.lbUpdateSite.AutoSize = true;
            this.lbUpdateSite.BackColor = System.Drawing.Color.Transparent;
            this.lbUpdateSite.Font = new System.Drawing.Font("Aharoni", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUpdateSite.Location = new System.Drawing.Point(192, 9);
            this.lbUpdateSite.Name = "lbUpdateSite";
            this.lbUpdateSite.Size = new System.Drawing.Size(192, 32);
            this.lbUpdateSite.TabIndex = 34;
            this.lbUpdateSite.Text = "Update Site";
            // 
            // frmUpdateSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.graywallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 451);
            this.Controls.Add(this.lbUpdateSite);
            this.Controls.Add(this.cbSiteID);
            this.Controls.Add(this.lbSiteID);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Site";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateSite_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateSite_Load);
            this.MouseEnter += new System.EventHandler(this.frmUpdateSite_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.ComboBox cbSiteType;
        private System.Windows.Forms.NumericUpDown UpFoundedYear;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbFoundedYear;
        private System.Windows.Forms.Label lbSiteDescription;
        private System.Windows.Forms.Label lbSiteName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lbSiteID;
        private System.Windows.Forms.ComboBox cbSiteID;
        private System.Windows.Forms.Label lbUpdateSite;
    }
}