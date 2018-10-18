namespace HW5.Tables.tblSiteFromSite
{
    partial class frmUpdetNearbySites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdetNearbySites));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSite2 = new System.Windows.Forms.TextBox();
            this.txtSite1 = new System.Windows.Forms.TextBox();
            this.lbDistance = new System.Windows.Forms.Label();
            this.cbSiteID2 = new System.Windows.Forms.ComboBox();
            this.lbSecondSiteID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateSite = new System.Windows.Forms.Button();
            this.cbSiteID1 = new System.Windows.Forms.ComboBox();
            this.lbFirstSiteID = new System.Windows.Forms.Label();
            this.upDistance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Update Nearby Sits";
            // 
            // txtSite2
            // 
            this.txtSite2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSite2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSite2.Enabled = false;
            this.txtSite2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite2.Location = new System.Drawing.Point(254, 159);
            this.txtSite2.Name = "txtSite2";
            this.txtSite2.Size = new System.Drawing.Size(156, 23);
            this.txtSite2.TabIndex = 65;
            this.txtSite2.Visible = false;
            // 
            // txtSite1
            // 
            this.txtSite1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSite1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSite1.Enabled = false;
            this.txtSite1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite1.Location = new System.Drawing.Point(254, 118);
            this.txtSite1.Name = "txtSite1";
            this.txtSite1.Size = new System.Drawing.Size(156, 23);
            this.txtSite1.TabIndex = 64;
            this.txtSite1.Visible = false;
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbDistance.Location = new System.Drawing.Point(56, 199);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(70, 15);
            this.lbDistance.TabIndex = 63;
            this.lbDistance.Text = "Distance:";
            // 
            // cbSiteID2
            // 
            this.cbSiteID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID2.FormattingEnabled = true;
            this.cbSiteID2.Location = new System.Drawing.Point(174, 157);
            this.cbSiteID2.Name = "cbSiteID2";
            this.cbSiteID2.Size = new System.Drawing.Size(59, 23);
            this.cbSiteID2.TabIndex = 62;
            this.cbSiteID2.SelectedIndexChanged += new System.EventHandler(this.cbSiteID2_SelectedIndexChanged);
            // 
            // lbSecondSiteID
            // 
            this.lbSecondSiteID.AutoSize = true;
            this.lbSecondSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbSecondSiteID.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSecondSiteID.Location = new System.Drawing.Point(56, 161);
            this.lbSecondSiteID.Name = "lbSecondSiteID";
            this.lbSecondSiteID.Size = new System.Drawing.Size(115, 15);
            this.lbSecondSiteID.TabIndex = 61;
            this.lbSecondSiteID.Text = "Nearby Site ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(264, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateSite
            // 
            this.btnUpdateSite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSite.Location = new System.Drawing.Point(110, 267);
            this.btnUpdateSite.Name = "btnUpdateSite";
            this.btnUpdateSite.Size = new System.Drawing.Size(88, 24);
            this.btnUpdateSite.TabIndex = 59;
            this.btnUpdateSite.Text = "OK";
            this.btnUpdateSite.UseVisualStyleBackColor = true;
            this.btnUpdateSite.Click += new System.EventHandler(this.btnRemoveSite_Click);
            // 
            // cbSiteID1
            // 
            this.cbSiteID1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID1.FormattingEnabled = true;
            this.cbSiteID1.Location = new System.Drawing.Point(174, 116);
            this.cbSiteID1.Name = "cbSiteID1";
            this.cbSiteID1.Size = new System.Drawing.Size(59, 23);
            this.cbSiteID1.TabIndex = 58;
            this.cbSiteID1.SelectedIndexChanged += new System.EventHandler(this.cbSiteID1_SelectedIndexChanged);
            // 
            // lbFirstSiteID
            // 
            this.lbFirstSiteID.AutoSize = true;
            this.lbFirstSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstSiteID.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbFirstSiteID.Location = new System.Drawing.Point(56, 120);
            this.lbFirstSiteID.Name = "lbFirstSiteID";
            this.lbFirstSiteID.Size = new System.Drawing.Size(57, 15);
            this.lbFirstSiteID.TabIndex = 57;
            this.lbFirstSiteID.Text = "Site ID:";
            // 
            // upDistance
            // 
            this.upDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upDistance.DecimalPlaces = 1;
            this.upDistance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.upDistance.Location = new System.Drawing.Point(174, 196);
            this.upDistance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDistance.Name = "upDistance";
            this.upDistance.ReadOnly = true;
            this.upDistance.Size = new System.Drawing.Size(59, 23);
            this.upDistance.TabIndex = 67;
            // 
            // frmUpdetNearbySites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 318);
            this.Controls.Add(this.upDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSite2);
            this.Controls.Add(this.txtSite1);
            this.Controls.Add(this.lbDistance);
            this.Controls.Add(this.cbSiteID2);
            this.Controls.Add(this.lbSecondSiteID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateSite);
            this.Controls.Add(this.cbSiteID1);
            this.Controls.Add(this.lbFirstSiteID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdetNearbySites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updet Nearby Sites:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdetNearbySites_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdetNearbySites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSite2;
        private System.Windows.Forms.TextBox txtSite1;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.ComboBox cbSiteID2;
        private System.Windows.Forms.Label lbSecondSiteID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateSite;
        private System.Windows.Forms.ComboBox cbSiteID1;
        private System.Windows.Forms.Label lbFirstSiteID;
        private System.Windows.Forms.NumericUpDown upDistance;
    }
}