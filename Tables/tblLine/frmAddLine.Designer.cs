namespace HW5.Tables.tblLine
{
    partial class frmAddLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLine));
            this.ibLineName = new System.Windows.Forms.Label();
            this.txtLineName = new System.Windows.Forms.TextBox();
            this.lbFoundedYear = new System.Windows.Forms.Label();
            this.lbLineType = new System.Windows.Forms.Label();
            this.lbLineLength = new System.Windows.Forms.Label();
            this.cbLineType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.UpFoundedYear = new System.Windows.Forms.NumericUpDown();
            this.upLineLength = new System.Windows.Forms.NumericUpDown();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLineLength)).BeginInit();
            this.SuspendLayout();
            // 
            // ibLineName
            // 
            this.ibLineName.AutoSize = true;
            this.ibLineName.BackColor = System.Drawing.Color.Transparent;
            this.ibLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLineName.Location = new System.Drawing.Point(9, 56);
            this.ibLineName.Name = "ibLineName";
            this.ibLineName.Size = new System.Drawing.Size(80, 15);
            this.ibLineName.TabIndex = 0;
            this.ibLineName.Text = "Line Name:";
            // 
            // txtLineName
            // 
            this.txtLineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineName.Location = new System.Drawing.Point(124, 56);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.Size = new System.Drawing.Size(121, 23);
            this.txtLineName.TabIndex = 1;
            // 
            // lbFoundedYear
            // 
            this.lbFoundedYear.AutoSize = true;
            this.lbFoundedYear.BackColor = System.Drawing.Color.Transparent;
            this.lbFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoundedYear.Location = new System.Drawing.Point(9, 91);
            this.lbFoundedYear.Name = "lbFoundedYear";
            this.lbFoundedYear.Size = new System.Drawing.Size(100, 15);
            this.lbFoundedYear.TabIndex = 3;
            this.lbFoundedYear.Text = "Founded Year:";
            // 
            // lbLineType
            // 
            this.lbLineType.AutoSize = true;
            this.lbLineType.BackColor = System.Drawing.Color.Transparent;
            this.lbLineType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineType.Location = new System.Drawing.Point(9, 165);
            this.lbLineType.Name = "lbLineType";
            this.lbLineType.Size = new System.Drawing.Size(42, 15);
            this.lbLineType.TabIndex = 5;
            this.lbLineType.Text = "Type:";
            // 
            // lbLineLength
            // 
            this.lbLineLength.AutoSize = true;
            this.lbLineLength.BackColor = System.Drawing.Color.Transparent;
            this.lbLineLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineLength.Location = new System.Drawing.Point(9, 129);
            this.lbLineLength.Name = "lbLineLength";
            this.lbLineLength.Size = new System.Drawing.Size(52, 15);
            this.lbLineLength.TabIndex = 7;
            this.lbLineLength.Text = "Length";
            // 
            // cbLineType
            // 
            this.cbLineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLineType.FormattingEnabled = true;
            this.cbLineType.Items.AddRange(new object[] {
            "On surface",
            "Under surface"});
            this.cbLineType.Location = new System.Drawing.Point(124, 165);
            this.cbLineType.Name = "cbLineType";
            this.cbLineType.Size = new System.Drawing.Size(110, 23);
            this.cbLineType.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(101, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(260, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpFoundedYear
            // 
            this.UpFoundedYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UpFoundedYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpFoundedYear.Location = new System.Drawing.Point(124, 90);
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
            this.UpFoundedYear.TabIndex = 11;
            this.UpFoundedYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // upLineLength
            // 
            this.upLineLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.upLineLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upLineLength.DecimalPlaces = 1;
            this.upLineLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLineLength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.upLineLength.Location = new System.Drawing.Point(125, 129);
            this.upLineLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.upLineLength.Name = "upLineLength";
            this.upLineLength.ReadOnly = true;
            this.upLineLength.Size = new System.Drawing.Size(59, 23);
            this.upLineLength.TabIndex = 12;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.BackColor = System.Drawing.Color.Transparent;
            this.lbAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.ForeColor = System.Drawing.Color.Black;
            this.lbAdd.Location = new System.Drawing.Point(165, 9);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(114, 28);
            this.lbAdd.TabIndex = 13;
            this.lbAdd.Text = "Add Line";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Transparent;
            this.lbColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(9, 197);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(47, 15);
            this.lbColor.TabIndex = 14;
            this.lbColor.Text = "Color:";
            // 
            // cbColors
            // 
            this.cbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(125, 199);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(109, 22);
            this.cbColors.TabIndex = 15;
            this.cbColors.SelectedIndexChanged += new System.EventHandler(this.cbColors_SelectedIndexChanged);
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(241, 199);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(21, 20);
            this.txtColor.TabIndex = 16;
            this.txtColor.Visible = false;
            // 
            // frmAddLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.Rail_Road_HD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 331);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cbColors);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.upLineLength);
            this.Controls.Add(this.UpFoundedYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbLineType);
            this.Controls.Add(this.lbLineLength);
            this.Controls.Add(this.lbLineType);
            this.Controls.Add(this.lbFoundedYear);
            this.Controls.Add(this.txtLineName);
            this.Controls.Add(this.ibLineName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddLine_FormClosing);
            this.Load += new System.EventHandler(this.frmAddLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpFoundedYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLineLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibLineName;
        private System.Windows.Forms.TextBox txtLineName;
        private System.Windows.Forms.Label lbFoundedYear;
        private System.Windows.Forms.Label lbLineType;
        private System.Windows.Forms.Label lbLineLength;
        private System.Windows.Forms.ComboBox cbLineType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown UpFoundedYear;
        private System.Windows.Forms.NumericUpDown upLineLength;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.TextBox txtColor;
    }
}