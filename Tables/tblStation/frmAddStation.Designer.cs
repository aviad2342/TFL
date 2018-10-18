namespace HW5.Tables.tblStation
{
    partial class frmAddStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStation));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lebStationName = new System.Windows.Forms.Label();
            this.platformNumber = new System.Windows.Forms.NumericUpDown();
            this.labplatformNumber = new System.Windows.Forms.Label();
            this.checkKiosk = new System.Windows.Forms.CheckBox();
            this.cbZoneNumber = new System.Windows.Forms.ComboBox();
            this.labZoneNumber = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.platformNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(109, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(285, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.White;
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.Location = new System.Drawing.Point(133, 72);
            this.txtStationName.Multiline = true;
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(109, 20);
            this.txtStationName.TabIndex = 2;
            // 
            // lebStationName
            // 
            this.lebStationName.BackColor = System.Drawing.Color.Transparent;
            this.lebStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebStationName.Location = new System.Drawing.Point(9, 72);
            this.lebStationName.Name = "lebStationName";
            this.lebStationName.Size = new System.Drawing.Size(107, 20);
            this.lebStationName.TabIndex = 3;
            this.lebStationName.Text = "Station Name:";
            // 
            // platformNumber
            // 
            this.platformNumber.BackColor = System.Drawing.Color.White;
            this.platformNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformNumber.Location = new System.Drawing.Point(173, 111);
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
            this.platformNumber.Size = new System.Drawing.Size(52, 23);
            this.platformNumber.TabIndex = 4;
            this.platformNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labplatformNumber
            // 
            this.labplatformNumber.BackColor = System.Drawing.Color.Transparent;
            this.labplatformNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labplatformNumber.ForeColor = System.Drawing.Color.Black;
            this.labplatformNumber.Location = new System.Drawing.Point(9, 112);
            this.labplatformNumber.Name = "labplatformNumber";
            this.labplatformNumber.Size = new System.Drawing.Size(146, 20);
            this.labplatformNumber.TabIndex = 5;
            this.labplatformNumber.Text = "Number Of Platforms:";
            // 
            // checkKiosk
            // 
            this.checkKiosk.AutoSize = true;
            this.checkKiosk.BackColor = System.Drawing.Color.Transparent;
            this.checkKiosk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkKiosk.Location = new System.Drawing.Point(285, 112);
            this.checkKiosk.Name = "checkKiosk";
            this.checkKiosk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkKiosk.Size = new System.Drawing.Size(66, 19);
            this.checkKiosk.TabIndex = 6;
            this.checkKiosk.Text = ":Kiosk";
            this.checkKiosk.UseVisualStyleBackColor = false;
            // 
            // cbZoneNumber
            // 
            this.cbZoneNumber.BackColor = System.Drawing.Color.White;
            this.cbZoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZoneNumber.FormattingEnabled = true;
            this.cbZoneNumber.Location = new System.Drawing.Point(399, 73);
            this.cbZoneNumber.Name = "cbZoneNumber";
            this.cbZoneNumber.Size = new System.Drawing.Size(48, 23);
            this.cbZoneNumber.TabIndex = 7;
            // 
            // labZoneNumber
            // 
            this.labZoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labZoneNumber.Location = new System.Drawing.Point(282, 73);
            this.labZoneNumber.Name = "labZoneNumber";
            this.labZoneNumber.Size = new System.Drawing.Size(100, 21);
            this.labZoneNumber.TabIndex = 8;
            this.labZoneNumber.Text = "Zone Number:";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(168, 9);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(159, 26);
            this.labelT.TabIndex = 10;
            this.labelT.Text = "Add Station";
            // 
            // frmAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.TrainLAPorteStation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(499, 408);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labZoneNumber);
            this.Controls.Add(this.cbZoneNumber);
            this.Controls.Add(this.checkKiosk);
            this.Controls.Add(this.labplatformNumber);
            this.Controls.Add(this.platformNumber);
            this.Controls.Add(this.lebStationName);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddStation_FormClosing);
            this.Load += new System.EventHandler(this.frmAddStation_Load);
            this.MouseEnter += new System.EventHandler(this.frmAddStation_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.platformNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Label lebStationName;
        private System.Windows.Forms.NumericUpDown platformNumber;
        private System.Windows.Forms.Label labplatformNumber;
        private System.Windows.Forms.CheckBox checkKiosk;
        private System.Windows.Forms.ComboBox cbZoneNumber;
        private System.Windows.Forms.Label labZoneNumber;
        private System.Windows.Forms.Label labelT;
    }
}