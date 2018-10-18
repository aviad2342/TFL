namespace HW5.Tables.tblSiteFromExit
{
    partial class frmSiteFromExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiteFromExit));
            this.cbStationId = new System.Windows.Forms.ComboBox();
            this.lbStationId = new System.Windows.Forms.Label();
            this.cbLineName = new System.Windows.Forms.ComboBox();
            this.ibLineName = new System.Windows.Forms.Label();
            this.cbSiteID = new System.Windows.Forms.ComboBox();
            this.lbSiteID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.upDistance = new System.Windows.Forms.NumericUpDown();
            this.lbDistance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStationId
            // 
            this.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStationId.FormattingEnabled = true;
            this.cbStationId.Location = new System.Drawing.Point(102, 92);
            this.cbStationId.Name = "cbStationId";
            this.cbStationId.Size = new System.Drawing.Size(61, 23);
            this.cbStationId.TabIndex = 19;
            this.cbStationId.SelectedIndexChanged += new System.EventHandler(this.cbStationId_SelectedIndexChanged);
            // 
            // lbStationId
            // 
            this.lbStationId.BackColor = System.Drawing.Color.Transparent;
            this.lbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationId.Location = new System.Drawing.Point(16, 94);
            this.lbStationId.Name = "lbStationId";
            this.lbStationId.Size = new System.Drawing.Size(85, 20);
            this.lbStationId.TabIndex = 18;
            this.lbStationId.Text = "Station ID:";
            // 
            // cbLineName
            // 
            this.cbLineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineName.Enabled = false;
            this.cbLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLineName.FormattingEnabled = true;
            this.cbLineName.Location = new System.Drawing.Point(102, 131);
            this.cbLineName.Name = "cbLineName";
            this.cbLineName.Size = new System.Drawing.Size(121, 23);
            this.cbLineName.TabIndex = 26;
            // 
            // ibLineName
            // 
            this.ibLineName.AutoSize = true;
            this.ibLineName.BackColor = System.Drawing.Color.Transparent;
            this.ibLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLineName.Location = new System.Drawing.Point(16, 133);
            this.ibLineName.Name = "ibLineName";
            this.ibLineName.Size = new System.Drawing.Size(80, 15);
            this.ibLineName.TabIndex = 25;
            this.ibLineName.Text = "Line Name:";
            // 
            // cbSiteID
            // 
            this.cbSiteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID.FormattingEnabled = true;
            this.cbSiteID.Location = new System.Drawing.Point(102, 167);
            this.cbSiteID.Name = "cbSiteID";
            this.cbSiteID.Size = new System.Drawing.Size(61, 23);
            this.cbSiteID.TabIndex = 35;
            this.cbSiteID.SelectedIndexChanged += new System.EventHandler(this.cbSiteID_SelectedIndexChanged);
            // 
            // lbSiteID
            // 
            this.lbSiteID.AutoSize = true;
            this.lbSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiteID.Location = new System.Drawing.Point(16, 170);
            this.lbSiteID.Name = "lbSiteID";
            this.lbSiteID.Size = new System.Drawing.Size(54, 15);
            this.lbSiteID.TabIndex = 34;
            this.lbSiteID.Text = "Site ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(290, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(125, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.upDistance.Location = new System.Drawing.Point(102, 208);
            this.upDistance.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upDistance.Name = "upDistance";
            this.upDistance.ReadOnly = true;
            this.upDistance.Size = new System.Drawing.Size(59, 23);
            this.upDistance.TabIndex = 38;
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.Location = new System.Drawing.Point(16, 210);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(69, 15);
            this.lbDistance.TabIndex = 39;
            this.lbDistance.Text = "Distance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Add Site To Exit";
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Enabled = false;
            this.txtStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.Location = new System.Drawing.Point(180, 91);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(104, 23);
            this.txtStationName.TabIndex = 41;
            this.txtStationName.Visible = false;
            // 
            // txtSiteName
            // 
            this.txtSiteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Enabled = false;
            this.txtSiteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(180, 167);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(148, 23);
            this.txtSiteName.TabIndex = 42;
            this.txtSiteName.Visible = false;
            // 
            // frmSiteFromExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.The_London_Eye_has_been_named_as_the_world_s_best_tourist_attraction_in_a_new_survey_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 348);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDistance);
            this.Controls.Add(this.upDistance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSiteID);
            this.Controls.Add(this.lbSiteID);
            this.Controls.Add(this.cbLineName);
            this.Controls.Add(this.ibLineName);
            this.Controls.Add(this.cbStationId);
            this.Controls.Add(this.lbStationId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiteFromExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site From Exit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSiteFromExit_FormClosing);
            this.Load += new System.EventHandler(this.frmSiteFromExit_Load);
            this.MouseEnter += new System.EventHandler(this.frmSiteFromExit_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStationId;
        private System.Windows.Forms.Label lbStationId;
        private System.Windows.Forms.ComboBox cbLineName;
        private System.Windows.Forms.Label ibLineName;
        private System.Windows.Forms.ComboBox cbSiteID;
        private System.Windows.Forms.Label lbSiteID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown upDistance;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.TextBox txtSiteName;
    }
}