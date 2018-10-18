namespace HW5.Tables.tblStation
{
    partial class frmUpdateStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStation));
            this.labZoneNumber = new System.Windows.Forms.Label();
            this.cbZoneNumber = new System.Windows.Forms.ComboBox();
            this.checkKiosk = new System.Windows.Forms.CheckBox();
            this.labplatformNumber = new System.Windows.Forms.Label();
            this.platformNumber = new System.Windows.Forms.NumericUpDown();
            this.lebStationName = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lbStationId = new System.Windows.Forms.Label();
            this.cbStationId = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.platformNumber)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labZoneNumber
            // 
            this.labZoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labZoneNumber.Location = new System.Drawing.Point(289, 47);
            this.labZoneNumber.Name = "labZoneNumber";
            this.labZoneNumber.Size = new System.Drawing.Size(100, 21);
            this.labZoneNumber.TabIndex = 15;
            this.labZoneNumber.Text = "Zone Number:";
            // 
            // cbZoneNumber
            // 
            this.cbZoneNumber.BackColor = System.Drawing.Color.White;
            this.cbZoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneNumber.FormattingEnabled = true;
            this.cbZoneNumber.Location = new System.Drawing.Point(395, 44);
            this.cbZoneNumber.Name = "cbZoneNumber";
            this.cbZoneNumber.Size = new System.Drawing.Size(42, 23);
            this.cbZoneNumber.TabIndex = 14;
            // 
            // checkKiosk
            // 
            this.checkKiosk.AutoSize = true;
            this.checkKiosk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkKiosk.Location = new System.Drawing.Point(292, 86);
            this.checkKiosk.Name = "checkKiosk";
            this.checkKiosk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkKiosk.Size = new System.Drawing.Size(66, 19);
            this.checkKiosk.TabIndex = 13;
            this.checkKiosk.Text = ":Kiosk";
            this.checkKiosk.UseVisualStyleBackColor = true;
            // 
            // labplatformNumber
            // 
            this.labplatformNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labplatformNumber.ForeColor = System.Drawing.Color.Black;
            this.labplatformNumber.Location = new System.Drawing.Point(16, 86);
            this.labplatformNumber.Name = "labplatformNumber";
            this.labplatformNumber.Size = new System.Drawing.Size(146, 20);
            this.labplatformNumber.TabIndex = 12;
            this.labplatformNumber.Text = "Number Of Platforms:";
            // 
            // platformNumber
            // 
            this.platformNumber.BackColor = System.Drawing.Color.White;
            this.platformNumber.Location = new System.Drawing.Point(207, 83);
            this.platformNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.platformNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.platformNumber.Name = "platformNumber";
            this.platformNumber.Size = new System.Drawing.Size(48, 23);
            this.platformNumber.TabIndex = 11;
            this.platformNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lebStationName
            // 
            this.lebStationName.BackColor = System.Drawing.Color.Transparent;
            this.lebStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebStationName.Location = new System.Drawing.Point(16, 46);
            this.lebStationName.Name = "lebStationName";
            this.lebStationName.Size = new System.Drawing.Size(107, 20);
            this.lebStationName.TabIndex = 10;
            this.lebStationName.Text = "Station Name:";
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.White;
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Location = new System.Drawing.Point(140, 46);
            this.txtStationName.Multiline = true;
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(115, 20);
            this.txtStationName.TabIndex = 9;
            // 
            // lbStationId
            // 
            this.lbStationId.BackColor = System.Drawing.Color.Transparent;
            this.lbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationId.Location = new System.Drawing.Point(19, 38);
            this.lbStationId.Name = "lbStationId";
            this.lbStationId.Size = new System.Drawing.Size(85, 20);
            this.lbStationId.TabIndex = 16;
            this.lbStationId.Text = "Station ID:";
            // 
            // cbStationId
            // 
            this.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationId.FormattingEnabled = true;
            this.cbStationId.Location = new System.Drawing.Point(99, 36);
            this.cbStationId.Name = "cbStationId";
            this.cbStationId.Size = new System.Drawing.Size(61, 21);
            this.cbStationId.TabIndex = 17;
            this.cbStationId.SelectedIndexChanged += new System.EventHandler(this.cbStationId_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(111, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(282, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lebStationName);
            this.groupBox.Controls.Add(this.txtStationName);
            this.groupBox.Controls.Add(this.platformNumber);
            this.groupBox.Controls.Add(this.labplatformNumber);
            this.groupBox.Controls.Add(this.checkKiosk);
            this.groupBox.Controls.Add(this.labZoneNumber);
            this.groupBox.Controls.Add(this.cbZoneNumber);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 91);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(456, 146);
            this.groupBox.TabIndex = 20;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Station Details: ";
            // 
            // frmUpdateStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbStationId);
            this.Controls.Add(this.lbStationId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateStation_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateStation_Load);
            this.MouseEnter += new System.EventHandler(this.frmUpdateStation_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.platformNumber)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labZoneNumber;
        private System.Windows.Forms.ComboBox cbZoneNumber;
        private System.Windows.Forms.CheckBox checkKiosk;
        private System.Windows.Forms.Label labplatformNumber;
        private System.Windows.Forms.NumericUpDown platformNumber;
        private System.Windows.Forms.Label lebStationName;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Label lbStationId;
        private System.Windows.Forms.ComboBox cbStationId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox;
    }
}