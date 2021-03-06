﻿namespace HW5.Tables.tblOysterCard
{
    partial class frmUpgradeProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpgradeProgram));
            this.lbCardNumber = new System.Windows.Forms.Label();
            this.cbCardNumber = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCardLength = new System.Windows.Forms.ComboBox();
            this.cbZoneNumber = new System.Windows.Forms.ComboBox();
            this.lbValidFor = new System.Windows.Forms.Label();
            this.lbZone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCardNumber
            // 
            this.lbCardNumber.AutoSize = true;
            this.lbCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbCardNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardNumber.Location = new System.Drawing.Point(21, 75);
            this.lbCardNumber.Name = "lbCardNumber";
            this.lbCardNumber.Size = new System.Drawing.Size(98, 15);
            this.lbCardNumber.TabIndex = 0;
            this.lbCardNumber.Text = "Card Number:";
            // 
            // cbCardNumber
            // 
            this.cbCardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCardNumber.FormattingEnabled = true;
            this.cbCardNumber.Location = new System.Drawing.Point(125, 74);
            this.cbCardNumber.Name = "cbCardNumber";
            this.cbCardNumber.Size = new System.Drawing.Size(82, 20);
            this.cbCardNumber.TabIndex = 1;
            this.cbCardNumber.SelectedIndexChanged += new System.EventHandler(this.cbCardNumber_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(24, 108);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(398, 131);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Installed Programs:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(381, 94);
            this.dataGridView.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(106, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 28);
            this.btnAdd.TabIndex = 3;
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
            this.cbCardLength.Location = new System.Drawing.Point(234, 255);
            this.cbCardLength.Name = "cbCardLength";
            this.cbCardLength.Size = new System.Drawing.Size(121, 23);
            this.cbCardLength.TabIndex = 18;
            // 
            // cbZoneNumber
            // 
            this.cbZoneNumber.BackColor = System.Drawing.Color.White;
            this.cbZoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZoneNumber.FormattingEnabled = true;
            this.cbZoneNumber.Location = new System.Drawing.Point(77, 255);
            this.cbZoneNumber.Name = "cbZoneNumber";
            this.cbZoneNumber.Size = new System.Drawing.Size(55, 23);
            this.cbZoneNumber.TabIndex = 17;
            // 
            // lbValidFor
            // 
            this.lbValidFor.AutoSize = true;
            this.lbValidFor.BackColor = System.Drawing.Color.Transparent;
            this.lbValidFor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidFor.Location = new System.Drawing.Point(159, 257);
            this.lbValidFor.Name = "lbValidFor";
            this.lbValidFor.Size = new System.Drawing.Size(69, 15);
            this.lbValidFor.TabIndex = 16;
            this.lbValidFor.Text = "Valid For:";
            // 
            // lbZone
            // 
            this.lbZone.AutoSize = true;
            this.lbZone.BackColor = System.Drawing.Color.Transparent;
            this.lbZone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZone.Location = new System.Drawing.Point(28, 257);
            this.lbZone.Name = "lbZone";
            this.lbZone.Size = new System.Drawing.Size(43, 15);
            this.lbZone.TabIndex = 15;
            this.lbZone.Text = "Zone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Upgrade Card Program";
            // 
            // frmUpgradeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.graywallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCardLength);
            this.Controls.Add(this.cbZoneNumber);
            this.Controls.Add(this.lbValidFor);
            this.Controls.Add(this.lbZone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cbCardNumber);
            this.Controls.Add(this.lbCardNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpgradeProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpgradeProgram_FormClosing);
            this.Load += new System.EventHandler(this.frmUpgradeProgram_Load);
            this.MouseEnter += new System.EventHandler(this.frmUpgradeProgram_MouseEnter);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCardNumber;
        private System.Windows.Forms.ComboBox cbCardNumber;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCardLength;
        private System.Windows.Forms.ComboBox cbZoneNumber;
        private System.Windows.Forms.Label lbValidFor;
        private System.Windows.Forms.Label lbZone;
        private System.Windows.Forms.Label label1;
    }
}