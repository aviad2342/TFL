namespace HW5.Tables.tblOysterCard
{
    partial class frmNewOyserCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewOyserCard));
            this.lbPicture = new System.Windows.Forms.Label();
            this.lbZone = new System.Windows.Forms.Label();
            this.lbValidFor = new System.Windows.Forms.Label();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbZoneNumber = new System.Windows.Forms.ComboBox();
            this.cbCardLength = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbUpload = new System.Windows.Forms.Label();
            this.lbNewOysterCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPicture
            // 
            this.lbPicture.AutoSize = true;
            this.lbPicture.BackColor = System.Drawing.Color.Transparent;
            this.lbPicture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPicture.Location = new System.Drawing.Point(10, 250);
            this.lbPicture.Name = "lbPicture";
            this.lbPicture.Size = new System.Drawing.Size(127, 15);
            this.lbPicture.TabIndex = 1;
            this.lbPicture.Text = "Picture (Optional):";
            // 
            // lbZone
            // 
            this.lbZone.AutoSize = true;
            this.lbZone.BackColor = System.Drawing.Color.Transparent;
            this.lbZone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZone.Location = new System.Drawing.Point(10, 153);
            this.lbZone.Name = "lbZone";
            this.lbZone.Size = new System.Drawing.Size(43, 15);
            this.lbZone.TabIndex = 2;
            this.lbZone.Text = "Zone:";
            // 
            // lbValidFor
            // 
            this.lbValidFor.AutoSize = true;
            this.lbValidFor.BackColor = System.Drawing.Color.Transparent;
            this.lbValidFor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidFor.Location = new System.Drawing.Point(10, 199);
            this.lbValidFor.Name = "lbValidFor";
            this.lbValidFor.Size = new System.Drawing.Size(69, 15);
            this.lbValidFor.TabIndex = 3;
            this.lbValidFor.Text = "Valid For:";
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicture.Location = new System.Drawing.Point(143, 246);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(128, 23);
            this.btnChoosePicture.TabIndex = 4;
            this.btnChoosePicture.Text = "Choose Picture...";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(363, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(167, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbZoneNumber
            // 
            this.cbZoneNumber.BackColor = System.Drawing.Color.White;
            this.cbZoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZoneNumber.FormattingEnabled = true;
            this.cbZoneNumber.Location = new System.Drawing.Point(85, 153);
            this.cbZoneNumber.Name = "cbZoneNumber";
            this.cbZoneNumber.Size = new System.Drawing.Size(52, 23);
            this.cbZoneNumber.TabIndex = 13;
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
            this.cbCardLength.Location = new System.Drawing.Point(85, 197);
            this.cbCardLength.Name = "cbCardLength";
            this.cbCardLength.Size = new System.Drawing.Size(121, 23);
            this.cbCardLength.TabIndex = 14;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(421, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(359, 246);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 23);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbUpload
            // 
            this.lbUpload.AutoSize = true;
            this.lbUpload.BackColor = System.Drawing.Color.Transparent;
            this.lbUpload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpload.Location = new System.Drawing.Point(277, 250);
            this.lbUpload.Name = "lbUpload";
            this.lbUpload.Size = new System.Drawing.Size(76, 15);
            this.lbUpload.TabIndex = 18;
            this.lbUpload.Text = "Or Upload:";
            // 
            // lbNewOysterCard
            // 
            this.lbNewOysterCard.AutoSize = true;
            this.lbNewOysterCard.BackColor = System.Drawing.Color.Transparent;
            this.lbNewOysterCard.Font = new System.Drawing.Font("Aharoni", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbNewOysterCard.Location = new System.Drawing.Point(46, 9);
            this.lbNewOysterCard.Name = "lbNewOysterCard";
            this.lbNewOysterCard.Size = new System.Drawing.Size(322, 28);
            this.lbNewOysterCard.TabIndex = 19;
            this.lbNewOysterCard.Text = "Purchase Oyster ticket";
            // 
            // frmNewOyserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources._10703_640x360_oyster12ns1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 407);
            this.Controls.Add(this.lbNewOysterCard);
            this.Controls.Add(this.lbUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbCardLength);
            this.Controls.Add(this.cbZoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.lbValidFor);
            this.Controls.Add(this.lbZone);
            this.Controls.Add(this.lbPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewOyserCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Oyster ticket";
            this.Activated += new System.EventHandler(this.frmNewOyserCard_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewOyserCard_FormClosing);
            this.Load += new System.EventHandler(this.frmNewOyserCard_Load);
            this.MouseEnter += new System.EventHandler(this.frmNewOyserCard_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPicture;
        private System.Windows.Forms.Label lbZone;
        private System.Windows.Forms.Label lbValidFor;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbZoneNumber;
        private System.Windows.Forms.ComboBox cbCardLength;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lbUpload;
        private System.Windows.Forms.Label lbNewOysterCard;
    }
}