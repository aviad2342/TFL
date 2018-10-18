namespace HW5.Tables.tblSiteFromSite
{
    partial class frmSiteFromSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiteFromSite));
            this.cbSiteID1 = new System.Windows.Forms.ComboBox();
            this.lbFirstSiteID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.cbSiteID2 = new System.Windows.Forms.ComboBox();
            this.lbSecondSiteID = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.upDistance = new System.Windows.Forms.NumericUpDown();
            this.txtSite1 = new System.Windows.Forms.TextBox();
            this.txtSite2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSiteID1
            // 
            this.cbSiteID1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID1.FormattingEnabled = true;
            this.cbSiteID1.Location = new System.Drawing.Point(206, 102);
            this.cbSiteID1.Name = "cbSiteID1";
            this.cbSiteID1.Size = new System.Drawing.Size(59, 23);
            this.cbSiteID1.TabIndex = 35;
            this.cbSiteID1.SelectedIndexChanged += new System.EventHandler(this.cbSiteID1_SelectedIndexChanged);
            // 
            // lbFirstSiteID
            // 
            this.lbFirstSiteID.AutoSize = true;
            this.lbFirstSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstSiteID.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbFirstSiteID.Location = new System.Drawing.Point(88, 106);
            this.lbFirstSiteID.Name = "lbFirstSiteID";
            this.lbFirstSiteID.Size = new System.Drawing.Size(90, 15);
            this.lbFirstSiteID.TabIndex = 34;
            this.lbFirstSiteID.Text = "First Site ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(331, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSite.Location = new System.Drawing.Point(177, 410);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(88, 24);
            this.btnAddSite.TabIndex = 36;
            this.btnAddSite.Text = "OK";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // cbSiteID2
            // 
            this.cbSiteID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID2.FormattingEnabled = true;
            this.cbSiteID2.Location = new System.Drawing.Point(206, 143);
            this.cbSiteID2.Name = "cbSiteID2";
            this.cbSiteID2.Size = new System.Drawing.Size(59, 23);
            this.cbSiteID2.TabIndex = 39;
            this.cbSiteID2.SelectedIndexChanged += new System.EventHandler(this.cbSiteID2_SelectedIndexChanged);
            // 
            // lbSecondSiteID
            // 
            this.lbSecondSiteID.AutoSize = true;
            this.lbSecondSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbSecondSiteID.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSecondSiteID.Location = new System.Drawing.Point(88, 147);
            this.lbSecondSiteID.Name = "lbSecondSiteID";
            this.lbSecondSiteID.Size = new System.Drawing.Size(112, 15);
            this.lbSecondSiteID.TabIndex = 38;
            this.lbSecondSiteID.Text = "Second Site ID:";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbDistance.Location = new System.Drawing.Point(88, 185);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(70, 15);
            this.lbDistance.TabIndex = 41;
            this.lbDistance.Text = "Distance:";
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
            this.upDistance.Location = new System.Drawing.Point(206, 183);
            this.upDistance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDistance.Name = "upDistance";
            this.upDistance.ReadOnly = true;
            this.upDistance.Size = new System.Drawing.Size(59, 23);
            this.upDistance.TabIndex = 40;
            // 
            // txtSite1
            // 
            this.txtSite1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSite1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSite1.Enabled = false;
            this.txtSite1.Location = new System.Drawing.Point(286, 104);
            this.txtSite1.Name = "txtSite1";
            this.txtSite1.Size = new System.Drawing.Size(133, 20);
            this.txtSite1.TabIndex = 42;
            this.txtSite1.Visible = false;
            // 
            // txtSite2
            // 
            this.txtSite2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSite2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSite2.Enabled = false;
            this.txtSite2.Location = new System.Drawing.Point(286, 145);
            this.txtSite2.Name = "txtSite2";
            this.txtSite2.Size = new System.Drawing.Size(133, 20);
            this.txtSite2.TabIndex = 43;
            this.txtSite2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(141, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Add Nearby Sits";
            // 
            // frmSiteFromSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources._359494;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSite2);
            this.Controls.Add(this.txtSite1);
            this.Controls.Add(this.lbDistance);
            this.Controls.Add(this.upDistance);
            this.Controls.Add(this.cbSiteID2);
            this.Controls.Add(this.lbSecondSiteID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSite);
            this.Controls.Add(this.cbSiteID1);
            this.Controls.Add(this.lbFirstSiteID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiteFromSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site From Site";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSiteFromSite_FormClosing);
            this.Load += new System.EventHandler(this.frmSiteFromSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSiteID1;
        private System.Windows.Forms.Label lbFirstSiteID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.ComboBox cbSiteID2;
        private System.Windows.Forms.Label lbSecondSiteID;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.NumericUpDown upDistance;
        private System.Windows.Forms.TextBox txtSite1;
        private System.Windows.Forms.TextBox txtSite2;
        private System.Windows.Forms.Label label1;
    }
}