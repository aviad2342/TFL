namespace HW5.Tables.tblActivity
{
    partial class frmNewTrainRide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTrainRide));
            this.lbTicketNumber = new System.Windows.Forms.Label();
            this.lbOriginStstion = new System.Windows.Forms.Label();
            this.ibTime1 = new System.Windows.Forms.Label();
            this.ibDestinationSation = new System.Windows.Forms.Label();
            this.lbTime2 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.cbUserTickets = new System.Windows.Forms.ComboBox();
            this.cbDestinationSation = new System.Windows.Forms.ComboBox();
            this.cbOriginStstion = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.OrigintimePicker = new System.Windows.Forms.DateTimePicker();
            this.DestinationtimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbLins = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTicketNumber
            // 
            this.lbTicketNumber.AutoSize = true;
            this.lbTicketNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbTicketNumber.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbTicketNumber.Location = new System.Drawing.Point(20, 85);
            this.lbTicketNumber.Name = "lbTicketNumber";
            this.lbTicketNumber.Size = new System.Drawing.Size(107, 15);
            this.lbTicketNumber.TabIndex = 0;
            this.lbTicketNumber.Text = "Choose Ticket:";
            // 
            // lbOriginStstion
            // 
            this.lbOriginStstion.AutoSize = true;
            this.lbOriginStstion.BackColor = System.Drawing.Color.Transparent;
            this.lbOriginStstion.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbOriginStstion.Location = new System.Drawing.Point(23, 123);
            this.lbOriginStstion.Name = "lbOriginStstion";
            this.lbOriginStstion.Size = new System.Drawing.Size(107, 15);
            this.lbOriginStstion.TabIndex = 1;
            this.lbOriginStstion.Text = "Origin Ststion:";
            // 
            // ibTime1
            // 
            this.ibTime1.AutoSize = true;
            this.ibTime1.BackColor = System.Drawing.Color.Transparent;
            this.ibTime1.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ibTime1.Location = new System.Drawing.Point(349, 123);
            this.ibTime1.Name = "ibTime1";
            this.ibTime1.Size = new System.Drawing.Size(44, 15);
            this.ibTime1.TabIndex = 2;
            this.ibTime1.Text = "Time:";
            // 
            // ibDestinationSation
            // 
            this.ibDestinationSation.AutoSize = true;
            this.ibDestinationSation.BackColor = System.Drawing.Color.Transparent;
            this.ibDestinationSation.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ibDestinationSation.Location = new System.Drawing.Point(23, 166);
            this.ibDestinationSation.Name = "ibDestinationSation";
            this.ibDestinationSation.Size = new System.Drawing.Size(140, 15);
            this.ibDestinationSation.TabIndex = 3;
            this.ibDestinationSation.Text = "Destination Sation:";
            // 
            // lbTime2
            // 
            this.lbTime2.AutoSize = true;
            this.lbTime2.BackColor = System.Drawing.Color.Transparent;
            this.lbTime2.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbTime2.Location = new System.Drawing.Point(349, 166);
            this.lbTime2.Name = "lbTime2";
            this.lbTime2.Size = new System.Drawing.Size(44, 15);
            this.lbTime2.TabIndex = 4;
            this.lbTime2.Text = "Time:";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.BackColor = System.Drawing.Color.Transparent;
            this.lbLine.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbLine.Location = new System.Drawing.Point(23, 210);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(96, 15);
            this.lbLine.TabIndex = 5;
            this.lbLine.Text = "Choose Line:";
            // 
            // cbUserTickets
            // 
            this.cbUserTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserTickets.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserTickets.FormattingEnabled = true;
            this.cbUserTickets.Location = new System.Drawing.Point(160, 82);
            this.cbUserTickets.Name = "cbUserTickets";
            this.cbUserTickets.Size = new System.Drawing.Size(57, 23);
            this.cbUserTickets.TabIndex = 6;
            this.cbUserTickets.SelectedIndexChanged += new System.EventHandler(this.cbUserTickets_SelectedIndexChanged);
            // 
            // cbDestinationSation
            // 
            this.cbDestinationSation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationSation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestinationSation.FormattingEnabled = true;
            this.cbDestinationSation.Location = new System.Drawing.Point(160, 163);
            this.cbDestinationSation.Name = "cbDestinationSation";
            this.cbDestinationSation.Size = new System.Drawing.Size(143, 23);
            this.cbDestinationSation.TabIndex = 7;
            this.cbDestinationSation.SelectedIndexChanged += new System.EventHandler(this.cbDestinationSation_SelectedIndexChanged);
            // 
            // cbOriginStstion
            // 
            this.cbOriginStstion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginStstion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOriginStstion.FormattingEnabled = true;
            this.cbOriginStstion.Location = new System.Drawing.Point(160, 120);
            this.cbOriginStstion.Name = "cbOriginStstion";
            this.cbOriginStstion.Size = new System.Drawing.Size(143, 23);
            this.cbOriginStstion.TabIndex = 8;
            this.cbOriginStstion.SelectedIndexChanged += new System.EventHandler(this.cbOriginStstion_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(421, 403);
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
            this.btnAdd.Location = new System.Drawing.Point(160, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrigintimePicker
            // 
            this.OrigintimePicker.CustomFormat = "HH:mm";
            this.OrigintimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrigintimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrigintimePicker.Location = new System.Drawing.Point(425, 120);
            this.OrigintimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.OrigintimePicker.Name = "OrigintimePicker";
            this.OrigintimePicker.ShowUpDown = true;
            this.OrigintimePicker.Size = new System.Drawing.Size(71, 23);
            this.OrigintimePicker.TabIndex = 13;
            this.OrigintimePicker.Value = new System.DateTime(2015, 7, 30, 17, 52, 41, 0);
            // 
            // DestinationtimePicker
            // 
            this.DestinationtimePicker.CustomFormat = "HH:mm";
            this.DestinationtimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DestinationtimePicker.Location = new System.Drawing.Point(425, 160);
            this.DestinationtimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DestinationtimePicker.Name = "DestinationtimePicker";
            this.DestinationtimePicker.ShowUpDown = true;
            this.DestinationtimePicker.Size = new System.Drawing.Size(71, 23);
            this.DestinationtimePicker.TabIndex = 14;
            this.DestinationtimePicker.Value = new System.DateTime(2015, 7, 30, 17, 52, 58, 0);
            // 
            // cbLins
            // 
            this.cbLins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLins.FormattingEnabled = true;
            this.cbLins.Location = new System.Drawing.Point(160, 207);
            this.cbLins.Name = "cbLins";
            this.cbLins.Size = new System.Drawing.Size(143, 23);
            this.cbLins.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Aharoni", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(203, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Plan A Rroute";
            // 
            // frmNewTrainRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.ChooChoo_Train_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbLins);
            this.Controls.Add(this.DestinationtimePicker);
            this.Controls.Add(this.OrigintimePicker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbOriginStstion);
            this.Controls.Add(this.cbDestinationSation);
            this.Controls.Add(this.cbUserTickets);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.lbTime2);
            this.Controls.Add(this.ibDestinationSation);
            this.Controls.Add(this.ibTime1);
            this.Controls.Add(this.lbOriginStstion);
            this.Controls.Add(this.lbTicketNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewTrainRide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Train Ride";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewTrainRide_FormClosing);
            this.Load += new System.EventHandler(this.frmNewTrainRide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTicketNumber;
        private System.Windows.Forms.Label lbOriginStstion;
        private System.Windows.Forms.Label ibTime1;
        private System.Windows.Forms.Label ibDestinationSation;
        private System.Windows.Forms.Label lbTime2;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.ComboBox cbUserTickets;
        private System.Windows.Forms.ComboBox cbDestinationSation;
        private System.Windows.Forms.ComboBox cbOriginStstion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker OrigintimePicker;
        private System.Windows.Forms.DateTimePicker DestinationtimePicker;
        private System.Windows.Forms.ComboBox cbLins;
        private System.Windows.Forms.Label label7;
    }
}