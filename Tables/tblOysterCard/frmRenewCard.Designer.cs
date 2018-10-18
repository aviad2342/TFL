namespace HW5.Tables.tblOysterCard
{
    partial class frmRenewCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewCard));
            this.cbCardNumber = new System.Windows.Forms.ComboBox();
            this.lbCardNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCardLength = new System.Windows.Forms.ComboBox();
            this.cbZoneNumber = new System.Windows.Forms.ComboBox();
            this.lbValidFor = new System.Windows.Forms.Label();
            this.lbZone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCardNumber
            // 
            this.cbCardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCardNumber.FormattingEnabled = true;
            this.cbCardNumber.Location = new System.Drawing.Point(126, 65);
            this.cbCardNumber.Name = "cbCardNumber";
            this.cbCardNumber.Size = new System.Drawing.Size(82, 20);
            this.cbCardNumber.TabIndex = 3;
            this.cbCardNumber.SelectedIndexChanged += new System.EventHandler(this.cbCardNumber_SelectedIndexChanged);
            // 
            // lbCardNumber
            // 
            this.lbCardNumber.AutoSize = true;
            this.lbCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbCardNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardNumber.Location = new System.Drawing.Point(12, 66);
            this.lbCardNumber.Name = "lbCardNumber";
            this.lbCardNumber.Size = new System.Drawing.Size(98, 15);
            this.lbCardNumber.TabIndex = 2;
            this.lbCardNumber.Text = "Card Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(205, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(56, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCardLength
            // 
            this.cbCardLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCardLength.FormattingEnabled = true;
            this.cbCardLength.Items.AddRange(new object[] {
            "Day",
            "3 Days",
            "Week",
            "Month",
            "3 Months",
            "Year"});
            this.cbCardLength.Location = new System.Drawing.Point(126, 138);
            this.cbCardLength.Name = "cbCardLength";
            this.cbCardLength.Size = new System.Drawing.Size(121, 23);
            this.cbCardLength.TabIndex = 22;
            // 
            // cbZoneNumber
            // 
            this.cbZoneNumber.BackColor = System.Drawing.Color.White;
            this.cbZoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZoneNumber.FormattingEnabled = true;
            this.cbZoneNumber.Location = new System.Drawing.Point(126, 101);
            this.cbZoneNumber.Name = "cbZoneNumber";
            this.cbZoneNumber.Size = new System.Drawing.Size(55, 23);
            this.cbZoneNumber.TabIndex = 21;
            // 
            // lbValidFor
            // 
            this.lbValidFor.AutoSize = true;
            this.lbValidFor.BackColor = System.Drawing.Color.Transparent;
            this.lbValidFor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidFor.Location = new System.Drawing.Point(12, 144);
            this.lbValidFor.Name = "lbValidFor";
            this.lbValidFor.Size = new System.Drawing.Size(69, 15);
            this.lbValidFor.TabIndex = 20;
            this.lbValidFor.Text = "Valid For:";
            // 
            // lbZone
            // 
            this.lbZone.AutoSize = true;
            this.lbZone.BackColor = System.Drawing.Color.Transparent;
            this.lbZone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZone.Location = new System.Drawing.Point(12, 103);
            this.lbZone.Name = "lbZone";
            this.lbZone.Size = new System.Drawing.Size(43, 15);
            this.lbZone.TabIndex = 19;
            this.lbZone.Text = "Zone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Renew Card";
            // 
            // frmRenewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources._2jb0c3d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCardLength);
            this.Controls.Add(this.cbZoneNumber);
            this.Controls.Add(this.lbValidFor);
            this.Controls.Add(this.lbZone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCardNumber);
            this.Controls.Add(this.lbCardNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRenewCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRenewCard_FormClosing);
            this.Load += new System.EventHandler(this.frmRenewCard_Load);
            this.MouseEnter += new System.EventHandler(this.frmRenewCard_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCardNumber;
        private System.Windows.Forms.Label lbCardNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCardLength;
        private System.Windows.Forms.ComboBox cbZoneNumber;
        private System.Windows.Forms.Label lbValidFor;
        private System.Windows.Forms.Label lbZone;
        private System.Windows.Forms.Label label1;
    }
}