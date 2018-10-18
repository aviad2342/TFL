namespace HW5.Tables.tblLine
{
    partial class frmUpdateLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateLine));
            this.upLineLength = new System.Windows.Forms.NumericUpDown();
            this.UpFoundedYear = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbLineType = new System.Windows.Forms.ComboBox();
            this.lbLineLength = new System.Windows.Forms.Label();
            this.lbLineType = new System.Windows.Forms.Label();
            this.lbFoundedYear = new System.Windows.Forms.Label();
            this.ibLineName = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbLineName = new System.Windows.Forms.ComboBox();
            this.lbUpdateLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upLineLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // upLineLength
            // 
            this.upLineLength.BackColor = System.Drawing.Color.LightSkyBlue;
            this.upLineLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upLineLength.DecimalPlaces = 1;
            this.upLineLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLineLength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.upLineLength.Location = new System.Drawing.Point(132, 82);
            this.upLineLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.upLineLength.Name = "upLineLength";
            this.upLineLength.ReadOnly = true;
            this.upLineLength.Size = new System.Drawing.Size(59, 23);
            this.upLineLength.TabIndex = 22;
            // 
            // UpFoundedYear
            // 
            this.UpFoundedYear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpFoundedYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpFoundedYear.Location = new System.Drawing.Point(131, 43);
            this.UpFoundedYear.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.UpFoundedYear.Minimum = new decimal(new int[] {
            1863,
            0,
            0,
            0});
            this.UpFoundedYear.Name = "UpFoundedYear";
            this.UpFoundedYear.ReadOnly = true;
            this.UpFoundedYear.Size = new System.Drawing.Size(60, 23);
            this.UpFoundedYear.TabIndex = 21;
            this.UpFoundedYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(226, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(67, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbLineType
            // 
            this.cbLineType.BackColor = System.Drawing.Color.White;
            this.cbLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLineType.FormattingEnabled = true;
            this.cbLineType.Items.AddRange(new object[] {
            "On surface",
            "Under surface"});
            this.cbLineType.Location = new System.Drawing.Point(131, 118);
            this.cbLineType.Name = "cbLineType";
            this.cbLineType.Size = new System.Drawing.Size(123, 23);
            this.cbLineType.TabIndex = 18;
            // 
            // lbLineLength
            // 
            this.lbLineLength.AutoSize = true;
            this.lbLineLength.BackColor = System.Drawing.Color.Transparent;
            this.lbLineLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineLength.Location = new System.Drawing.Point(16, 82);
            this.lbLineLength.Name = "lbLineLength";
            this.lbLineLength.Size = new System.Drawing.Size(56, 15);
            this.lbLineLength.TabIndex = 17;
            this.lbLineLength.Text = "Length:";
            // 
            // lbLineType
            // 
            this.lbLineType.AutoSize = true;
            this.lbLineType.BackColor = System.Drawing.Color.Transparent;
            this.lbLineType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineType.Location = new System.Drawing.Point(16, 118);
            this.lbLineType.Name = "lbLineType";
            this.lbLineType.Size = new System.Drawing.Size(42, 15);
            this.lbLineType.TabIndex = 16;
            this.lbLineType.Text = "Type:";
            // 
            // lbFoundedYear
            // 
            this.lbFoundedYear.AutoSize = true;
            this.lbFoundedYear.BackColor = System.Drawing.Color.Transparent;
            this.lbFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoundedYear.Location = new System.Drawing.Point(16, 44);
            this.lbFoundedYear.Name = "lbFoundedYear";
            this.lbFoundedYear.Size = new System.Drawing.Size(100, 15);
            this.lbFoundedYear.TabIndex = 15;
            this.lbFoundedYear.Text = "Founded Year:";
            // 
            // ibLineName
            // 
            this.ibLineName.AutoSize = true;
            this.ibLineName.BackColor = System.Drawing.Color.Transparent;
            this.ibLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLineName.Location = new System.Drawing.Point(23, 76);
            this.ibLineName.Name = "ibLineName";
            this.ibLineName.Size = new System.Drawing.Size(80, 15);
            this.ibLineName.TabIndex = 13;
            this.ibLineName.Text = "Line Name:";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtColor);
            this.groupBox.Controls.Add(this.cbColors);
            this.groupBox.Controls.Add(this.lbColor);
            this.groupBox.Controls.Add(this.lbFoundedYear);
            this.groupBox.Controls.Add(this.upLineLength);
            this.groupBox.Controls.Add(this.lbLineType);
            this.groupBox.Controls.Add(this.UpFoundedYear);
            this.groupBox.Controls.Add(this.lbLineLength);
            this.groupBox.Controls.Add(this.cbLineType);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(26, 112);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(331, 186);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Line Details: ";
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(261, 154);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(28, 23);
            this.txtColor.TabIndex = 25;
            this.txtColor.Visible = false;
            // 
            // cbColors
            // 
            this.cbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(131, 154);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(123, 22);
            this.cbColors.TabIndex = 24;
            this.cbColors.SelectedIndexChanged += new System.EventHandler(this.cbColors_SelectedIndexChanged);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Transparent;
            this.lbColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(15, 156);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(47, 15);
            this.lbColor.TabIndex = 23;
            this.lbColor.Text = "Color:";
            // 
            // cbLineName
            // 
            this.cbLineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineName.FormattingEnabled = true;
            this.cbLineName.Location = new System.Drawing.Point(109, 74);
            this.cbLineName.Name = "cbLineName";
            this.cbLineName.Size = new System.Drawing.Size(121, 21);
            this.cbLineName.TabIndex = 24;
            this.cbLineName.SelectedIndexChanged += new System.EventHandler(this.cbLineName_SelectedIndexChanged);
            // 
            // lbUpdateLine
            // 
            this.lbUpdateLine.AutoSize = true;
            this.lbUpdateLine.BackColor = System.Drawing.Color.Transparent;
            this.lbUpdateLine.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdateLine.Location = new System.Drawing.Point(70, 9);
            this.lbUpdateLine.Name = "lbUpdateLine";
            this.lbUpdateLine.Size = new System.Drawing.Size(231, 42);
            this.lbUpdateLine.TabIndex = 25;
            this.lbUpdateLine.Text = "Update Line";
            // 
            // frmUpdateLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.lbUpdateLine);
            this.Controls.Add(this.cbLineName);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ibLineName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateLine_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateLine_Load);
            this.MouseEnter += new System.EventHandler(this.frmUpdateLine_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.upLineLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upLineLength;
        private System.Windows.Forms.NumericUpDown UpFoundedYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbLineType;
        private System.Windows.Forms.Label lbLineLength;
        private System.Windows.Forms.Label lbLineType;
        private System.Windows.Forms.Label lbFoundedYear;
        private System.Windows.Forms.Label ibLineName;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbLineName;
        private System.Windows.Forms.Label lbUpdateLine;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Label lbColor;
    }
}