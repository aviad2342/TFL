namespace HW5.Tables.tblStation
{
    partial class frmRemoveStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveStation));
            this.cbStationId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labZoneNumber = new System.Windows.Forms.Label();
            this.labplatformNumber = new System.Windows.Forms.Label();
            this.lebStationName = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtKiosk = new System.Windows.Forms.TextBox();
            this.txtZoneNumber = new System.Windows.Forms.TextBox();
            this.txtNumOfPlatforms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStationId
            // 
            this.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationId.FormattingEnabled = true;
            this.cbStationId.Location = new System.Drawing.Point(120, 31);
            this.cbStationId.Name = "cbStationId";
            this.cbStationId.Size = new System.Drawing.Size(61, 21);
            this.cbStationId.TabIndex = 27;
            this.cbStationId.SelectedIndexChanged += new System.EventHandler(this.cbStationId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Station Id:";
            // 
            // labZoneNumber
            // 
            this.labZoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labZoneNumber.Location = new System.Drawing.Point(17, 108);
            this.labZoneNumber.Name = "labZoneNumber";
            this.labZoneNumber.Size = new System.Drawing.Size(100, 21);
            this.labZoneNumber.TabIndex = 25;
            this.labZoneNumber.Text = "Zone Number:";
            // 
            // labplatformNumber
            // 
            this.labplatformNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labplatformNumber.ForeColor = System.Drawing.Color.Black;
            this.labplatformNumber.Location = new System.Drawing.Point(17, 70);
            this.labplatformNumber.Name = "labplatformNumber";
            this.labplatformNumber.Size = new System.Drawing.Size(146, 20);
            this.labplatformNumber.TabIndex = 22;
            this.labplatformNumber.Text = "Number Of Platforms:";
            // 
            // lebStationName
            // 
            this.lebStationName.BackColor = System.Drawing.Color.Transparent;
            this.lebStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebStationName.Location = new System.Drawing.Point(17, 34);
            this.lebStationName.Name = "lebStationName";
            this.lebStationName.Size = new System.Drawing.Size(107, 20);
            this.lebStationName.TabIndex = 20;
            this.lebStationName.Text = "Station Name:";
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.White;
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Enabled = false;
            this.txtStationName.Location = new System.Drawing.Point(183, 34);
            this.txtStationName.Multiline = true;
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(115, 20);
            this.txtStationName.TabIndex = 19;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtKiosk);
            this.groupBox.Controls.Add(this.txtZoneNumber);
            this.groupBox.Controls.Add(this.txtNumOfPlatforms);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.lebStationName);
            this.groupBox.Controls.Add(this.txtStationName);
            this.groupBox.Controls.Add(this.labplatformNumber);
            this.groupBox.Controls.Add(this.labZoneNumber);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(38, 77);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(326, 176);
            this.groupBox.TabIndex = 28;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Station Details: ";
            this.groupBox.Visible = false;
            // 
            // txtKiosk
            // 
            this.txtKiosk.BackColor = System.Drawing.Color.White;
            this.txtKiosk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKiosk.Enabled = false;
            this.txtKiosk.Location = new System.Drawing.Point(183, 140);
            this.txtKiosk.Multiline = true;
            this.txtKiosk.Name = "txtKiosk";
            this.txtKiosk.Size = new System.Drawing.Size(59, 20);
            this.txtKiosk.TabIndex = 29;
            // 
            // txtZoneNumber
            // 
            this.txtZoneNumber.BackColor = System.Drawing.Color.White;
            this.txtZoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZoneNumber.Enabled = false;
            this.txtZoneNumber.Location = new System.Drawing.Point(183, 107);
            this.txtZoneNumber.Multiline = true;
            this.txtZoneNumber.Name = "txtZoneNumber";
            this.txtZoneNumber.Size = new System.Drawing.Size(59, 20);
            this.txtZoneNumber.TabIndex = 28;
            // 
            // txtNumOfPlatforms
            // 
            this.txtNumOfPlatforms.BackColor = System.Drawing.Color.White;
            this.txtNumOfPlatforms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOfPlatforms.Enabled = false;
            this.txtNumOfPlatforms.Location = new System.Drawing.Point(183, 70);
            this.txtNumOfPlatforms.Multiline = true;
            this.txtNumOfPlatforms.Name = "txtNumOfPlatforms";
            this.txtNumOfPlatforms.Size = new System.Drawing.Size(59, 20);
            this.txtNumOfPlatforms.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kiosk:";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(79, 281);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(223, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRemoveStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 325);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cbStationId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRemoveStation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveStation_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveStation_Load);
            this.MouseEnter += new System.EventHandler(this.frmRemoveStation_MouseEnter);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labZoneNumber;
        private System.Windows.Forms.Label labplatformNumber;
        private System.Windows.Forms.Label lebStationName;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtKiosk;
        private System.Windows.Forms.TextBox txtZoneNumber;
        private System.Windows.Forms.TextBox txtNumOfPlatforms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}