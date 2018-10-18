namespace HW5.Tables.tblSiteFromExit
{
    partial class frmUpdateSiteFromExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSiteFromExit));
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lbLineName = new System.Windows.Forms.Label();
            this.cbStationId = new System.Windows.Forms.ComboBox();
            this.lbStationId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upDistance = new System.Windows.Forms.NumericUpDown();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.cbSiteID = new System.Windows.Forms.ComboBox();
            this.lbSiteID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbLineName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Enabled = false;
            this.txtStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.Location = new System.Drawing.Point(206, 104);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(115, 23);
            this.txtStationName.TabIndex = 28;
            // 
            // lbLineName
            // 
            this.lbLineName.AutoSize = true;
            this.lbLineName.BackColor = System.Drawing.Color.Transparent;
            this.lbLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineName.Location = new System.Drawing.Point(39, 149);
            this.lbLineName.Name = "lbLineName";
            this.lbLineName.Size = new System.Drawing.Size(80, 15);
            this.lbLineName.TabIndex = 26;
            this.lbLineName.Text = "Line Name:";
            // 
            // cbStationId
            // 
            this.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStationId.FormattingEnabled = true;
            this.cbStationId.Location = new System.Drawing.Point(130, 104);
            this.cbStationId.Name = "cbStationId";
            this.cbStationId.Size = new System.Drawing.Size(61, 23);
            this.cbStationId.TabIndex = 31;
            this.cbStationId.SelectedIndexChanged += new System.EventHandler(this.cbStationId_SelectedIndexChanged);
            // 
            // lbStationId
            // 
            this.lbStationId.BackColor = System.Drawing.Color.Transparent;
            this.lbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationId.Location = new System.Drawing.Point(39, 107);
            this.lbStationId.Name = "lbStationId";
            this.lbStationId.Size = new System.Drawing.Size(97, 20);
            this.lbStationId.TabIndex = 30;
            this.lbStationId.Text = "Station Exit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Distance:";
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
            this.upDistance.Location = new System.Drawing.Point(130, 227);
            this.upDistance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDistance.Name = "upDistance";
            this.upDistance.ReadOnly = true;
            this.upDistance.Size = new System.Drawing.Size(61, 23);
            this.upDistance.TabIndex = 40;
            // 
            // txtSiteName
            // 
            this.txtSiteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Enabled = false;
            this.txtSiteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(206, 187);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(148, 23);
            this.txtSiteName.TabIndex = 45;
            this.txtSiteName.Visible = false;
            // 
            // cbSiteID
            // 
            this.cbSiteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteID.FormattingEnabled = true;
            this.cbSiteID.Location = new System.Drawing.Point(130, 187);
            this.cbSiteID.Name = "cbSiteID";
            this.cbSiteID.Size = new System.Drawing.Size(61, 23);
            this.cbSiteID.TabIndex = 44;
            this.cbSiteID.SelectedIndexChanged += new System.EventHandler(this.cbSiteID_SelectedIndexChanged);
            // 
            // lbSiteID
            // 
            this.lbSiteID.AutoSize = true;
            this.lbSiteID.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiteID.Location = new System.Drawing.Point(39, 190);
            this.lbSiteID.Name = "lbSiteID";
            this.lbSiteID.Size = new System.Drawing.Size(54, 15);
            this.lbSiteID.TabIndex = 43;
            this.lbSiteID.Text = "Site ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(246, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(85, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbLineName
            // 
            this.cbLineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLineName.FormattingEnabled = true;
            this.cbLineName.Location = new System.Drawing.Point(130, 149);
            this.cbLineName.Name = "cbLineName";
            this.cbLineName.Size = new System.Drawing.Size(130, 23);
            this.cbLineName.TabIndex = 48;
            this.cbLineName.SelectedIndexChanged += new System.EventHandler(this.cbLineName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Aharoni", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 28);
            this.label2.TabIndex = 49;
            this.label2.Text = "Update Site From Exit";
            // 
            // frmUpdateSiteFromExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.BGshow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLineName);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbLineName);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.cbSiteID);
            this.Controls.Add(this.lbSiteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDistance);
            this.Controls.Add(this.cbStationId);
            this.Controls.Add(this.lbStationId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateSiteFromExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Site From Exit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateSiteFromExit_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateSiteFromExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Label lbLineName;
        private System.Windows.Forms.ComboBox cbStationId;
        private System.Windows.Forms.Label lbStationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDistance;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.ComboBox cbSiteID;
        private System.Windows.Forms.Label lbSiteID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbLineName;
        private System.Windows.Forms.Label label2;
    }
}