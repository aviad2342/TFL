namespace HW5.Tables.tblSite
{
    partial class frmAddSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSite));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.lbSiteName = new System.Windows.Forms.Label();
            this.lbSiteDescription = new System.Windows.Forms.Label();
            this.lbFoundedYear = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.UpFoundedYear = new System.Windows.Forms.NumericUpDown();
            this.cbSiteType = new System.Windows.Forms.ComboBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(442, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSite.Location = new System.Drawing.Point(198, 430);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(88, 24);
            this.btnAddSite.TabIndex = 11;
            this.btnAddSite.Text = "OK";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // lbSiteName
            // 
            this.lbSiteName.AutoSize = true;
            this.lbSiteName.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteName.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSiteName.Location = new System.Drawing.Point(12, 112);
            this.lbSiteName.Name = "lbSiteName";
            this.lbSiteName.Size = new System.Drawing.Size(85, 15);
            this.lbSiteName.TabIndex = 13;
            this.lbSiteName.Text = "Site Name:";
            // 
            // lbSiteDescription
            // 
            this.lbSiteDescription.AutoSize = true;
            this.lbSiteDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteDescription.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSiteDescription.Location = new System.Drawing.Point(12, 208);
            this.lbSiteDescription.Name = "lbSiteDescription";
            this.lbSiteDescription.Size = new System.Drawing.Size(89, 15);
            this.lbSiteDescription.TabIndex = 14;
            this.lbSiteDescription.Text = "Description:";
            // 
            // lbFoundedYear
            // 
            this.lbFoundedYear.AutoSize = true;
            this.lbFoundedYear.BackColor = System.Drawing.Color.Transparent;
            this.lbFoundedYear.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbFoundedYear.Location = new System.Drawing.Point(12, 175);
            this.lbFoundedYear.Name = "lbFoundedYear";
            this.lbFoundedYear.Size = new System.Drawing.Size(110, 15);
            this.lbFoundedYear.TabIndex = 15;
            this.lbFoundedYear.Text = "Founded Year:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbType.Location = new System.Drawing.Point(12, 145);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(45, 15);
            this.lbType.TabIndex = 16;
            this.lbType.Text = "Type:";
            // 
            // UpFoundedYear
            // 
            this.UpFoundedYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpFoundedYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpFoundedYear.Location = new System.Drawing.Point(128, 172);
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
            this.UpFoundedYear.TabIndex = 17;
            this.UpFoundedYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // cbSiteType
            // 
            this.cbSiteType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSiteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteType.FormattingEnabled = true;
            this.cbSiteType.Location = new System.Drawing.Point(128, 142);
            this.cbSiteType.Name = "cbSiteType";
            this.cbSiteType.Size = new System.Drawing.Size(114, 23);
            this.cbSiteType.TabIndex = 18;
            // 
            // txtSiteName
            // 
            this.txtSiteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(128, 109);
            this.txtSiteName.MaxLength = 20;
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(114, 23);
            this.txtSiteName.TabIndex = 19;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(128, 208);
            this.rtxtDescription.MaxLength = 150;
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(332, 89);
            this.rtxtDescription.TabIndex = 20;
            this.rtxtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add Site";
            // 
            // frmAddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.Big_Ben_and_the_sky_photography__by_paweldomaradzki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.cbSiteType);
            this.Controls.Add(this.UpFoundedYear);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbFoundedYear);
            this.Controls.Add(this.lbSiteDescription);
            this.Controls.Add(this.lbSiteName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Site";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddSite_FormClosing);
            this.Load += new System.EventHandler(this.frmAddSite_Load);
            this.MouseEnter += new System.EventHandler(this.frmAddSite_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Label lbSiteName;
        private System.Windows.Forms.Label lbSiteDescription;
        private System.Windows.Forms.Label lbFoundedYear;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.NumericUpDown UpFoundedYear;
        private System.Windows.Forms.ComboBox cbSiteType;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label1;
    }
}