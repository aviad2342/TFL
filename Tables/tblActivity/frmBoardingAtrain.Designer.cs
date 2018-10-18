namespace HW5.Tables.tblActivity
{
    partial class frmBoardingAtrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoardingAtrain));
            this.cbLins = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbOriginStstion = new System.Windows.Forms.ComboBox();
            this.cbUserTickets = new System.Windows.Forms.ComboBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbStstion = new System.Windows.Forms.Label();
            this.lbTicketNumber = new System.Windows.Forms.Label();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.rbOut = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLins
            // 
            this.cbLins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLins.FormattingEnabled = true;
            this.cbLins.Location = new System.Drawing.Point(170, 189);
            this.cbLins.Name = "cbLins";
            this.cbLins.Size = new System.Drawing.Size(143, 23);
            this.cbLins.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(351, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(129, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbOriginStstion
            // 
            this.cbOriginStstion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginStstion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOriginStstion.FormattingEnabled = true;
            this.cbOriginStstion.Location = new System.Drawing.Point(170, 149);
            this.cbOriginStstion.Name = "cbOriginStstion";
            this.cbOriginStstion.Size = new System.Drawing.Size(143, 23);
            this.cbOriginStstion.TabIndex = 24;
            this.cbOriginStstion.SelectedIndexChanged += new System.EventHandler(this.cbOriginStstion_SelectedIndexChanged);
            // 
            // cbUserTickets
            // 
            this.cbUserTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserTickets.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserTickets.FormattingEnabled = true;
            this.cbUserTickets.Location = new System.Drawing.Point(170, 108);
            this.cbUserTickets.Name = "cbUserTickets";
            this.cbUserTickets.Size = new System.Drawing.Size(57, 23);
            this.cbUserTickets.TabIndex = 22;
            this.cbUserTickets.SelectedIndexChanged += new System.EventHandler(this.cbUserTickets_SelectedIndexChanged);
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.BackColor = System.Drawing.Color.Transparent;
            this.lbLine.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbLine.Location = new System.Drawing.Point(33, 192);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(96, 15);
            this.lbLine.TabIndex = 21;
            this.lbLine.Text = "Choose Line:";
            // 
            // lbStstion
            // 
            this.lbStstion.AutoSize = true;
            this.lbStstion.BackColor = System.Drawing.Color.Transparent;
            this.lbStstion.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbStstion.Location = new System.Drawing.Point(33, 152);
            this.lbStstion.Name = "lbStstion";
            this.lbStstion.Size = new System.Drawing.Size(59, 15);
            this.lbStstion.TabIndex = 17;
            this.lbStstion.Text = "Ststion:";
            // 
            // lbTicketNumber
            // 
            this.lbTicketNumber.AutoSize = true;
            this.lbTicketNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbTicketNumber.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbTicketNumber.Location = new System.Drawing.Point(30, 111);
            this.lbTicketNumber.Name = "lbTicketNumber";
            this.lbTicketNumber.Size = new System.Drawing.Size(107, 15);
            this.lbTicketNumber.TabIndex = 16;
            this.lbTicketNumber.Text = "Choose Ticket:";
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbIn.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbIn.Location = new System.Drawing.Point(29, 22);
            this.rbIn.Name = "rbIn";
            this.rbIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbIn.Size = new System.Drawing.Size(39, 19);
            this.rbIn.TabIndex = 30;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "In";
            this.rbIn.UseVisualStyleBackColor = true;
            // 
            // rbOut
            // 
            this.rbOut.AutoSize = true;
            this.rbOut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbOut.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbOut.Location = new System.Drawing.Point(80, 22);
            this.rbOut.Name = "rbOut";
            this.rbOut.Size = new System.Drawing.Size(51, 19);
            this.rbOut.TabIndex = 31;
            this.rbOut.TabStop = true;
            this.rbOut.Text = "Out";
            this.rbOut.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.rbIn);
            this.groupBox.Controls.Add(this.rbOut);
            this.groupBox.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox.Location = new System.Drawing.Point(24, 228);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(155, 62);
            this.groupBox.TabIndex = 32;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Going:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Catch A Train";
            // 
            // frmBoardingAtrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.Brookwood_672def29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cbLins);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbOriginStstion);
            this.Controls.Add(this.cbUserTickets);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.lbStstion);
            this.Controls.Add(this.lbTicketNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBoardingAtrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boarding A train";
            this.Load += new System.EventHandler(this.frmBoardingAtrain_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLins;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbOriginStstion;
        private System.Windows.Forms.ComboBox cbUserTickets;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbStstion;
        private System.Windows.Forms.Label lbTicketNumber;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.RadioButton rbOut;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
    }
}