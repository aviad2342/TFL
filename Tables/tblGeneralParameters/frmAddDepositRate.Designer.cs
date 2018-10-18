namespace HW5.Tables.tblGeneralParameters
{
    partial class frmAddDepositRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDepositRate));
            this.lbFromYear = new System.Windows.Forms.Label();
            this.lbEndYear = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.upPrice = new System.Windows.Forms.NumericUpDown();
            this.UpEndYear = new System.Windows.Forms.NumericUpDown();
            this.txtFromYear = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpEndYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFromYear
            // 
            this.lbFromYear.AutoSize = true;
            this.lbFromYear.BackColor = System.Drawing.Color.Transparent;
            this.lbFromYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromYear.Location = new System.Drawing.Point(32, 64);
            this.lbFromYear.Name = "lbFromYear";
            this.lbFromYear.Size = new System.Drawing.Size(78, 15);
            this.lbFromYear.TabIndex = 0;
            this.lbFromYear.Text = "From Year:";
            // 
            // lbEndYear
            // 
            this.lbEndYear.AutoSize = true;
            this.lbEndYear.BackColor = System.Drawing.Color.Transparent;
            this.lbEndYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndYear.Location = new System.Drawing.Point(32, 105);
            this.lbEndYear.Name = "lbEndYear";
            this.lbEndYear.Size = new System.Drawing.Size(69, 15);
            this.lbEndYear.TabIndex = 1;
            this.lbEndYear.Text = "End Year:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(32, 143);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 15);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price:";
            // 
            // upPrice
            // 
            this.upPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upPrice.DecimalPlaces = 1;
            this.upPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.upPrice.Location = new System.Drawing.Point(116, 141);
            this.upPrice.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.upPrice.Name = "upPrice";
            this.upPrice.ReadOnly = true;
            this.upPrice.Size = new System.Drawing.Size(59, 23);
            this.upPrice.TabIndex = 14;
            // 
            // UpEndYear
            // 
            this.UpEndYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpEndYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpEndYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpEndYear.Location = new System.Drawing.Point(116, 103);
            this.UpEndYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.UpEndYear.Minimum = new decimal(new int[] {
            1863,
            0,
            0,
            0});
            this.UpEndYear.Name = "UpEndYear";
            this.UpEndYear.ReadOnly = true;
            this.UpEndYear.Size = new System.Drawing.Size(60, 23);
            this.UpEndYear.TabIndex = 13;
            this.UpEndYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // txtFromYear
            // 
            this.txtFromYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFromYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromYear.Enabled = false;
            this.txtFromYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromYear.Location = new System.Drawing.Point(116, 62);
            this.txtFromYear.Name = "txtFromYear";
            this.txtFromYear.Size = new System.Drawing.Size(68, 23);
            this.txtFromYear.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(155, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(28, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Deposit Rate:";
            // 
            // frmAddDepositRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(267, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFromYear);
            this.Controls.Add(this.upPrice);
            this.Controls.Add(this.UpEndYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbEndYear);
            this.Controls.Add(this.lbFromYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddDepositRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Deposit Rate:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddDepositRate_FormClosing);
            this.Load += new System.EventHandler(this.frmAddDepositRate_Load);
            this.MouseEnter += new System.EventHandler(this.frmAddDepositRate_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.upPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpEndYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFromYear;
        private System.Windows.Forms.Label lbEndYear;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.NumericUpDown upPrice;
        private System.Windows.Forms.NumericUpDown UpEndYear;
        private System.Windows.Forms.TextBox txtFromYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}