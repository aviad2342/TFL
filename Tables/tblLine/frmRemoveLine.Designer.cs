namespace HW5.Tables.tblLine
{
    partial class frmRemoveLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveLine));
            this.lbRemoveLine = new System.Windows.Forms.Label();
            this.cbLineName = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtLineType = new System.Windows.Forms.TextBox();
            this.txtLineLength = new System.Windows.Forms.TextBox();
            this.txtFoundedYear = new System.Windows.Forms.TextBox();
            this.lbFoundedYear = new System.Windows.Forms.Label();
            this.lbLineType = new System.Windows.Forms.Label();
            this.lbLineLength = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ibLineName = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRemoveLine
            // 
            this.lbRemoveLine.AutoSize = true;
            this.lbRemoveLine.BackColor = System.Drawing.Color.Transparent;
            this.lbRemoveLine.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemoveLine.Location = new System.Drawing.Point(60, 12);
            this.lbRemoveLine.Name = "lbRemoveLine";
            this.lbRemoveLine.Size = new System.Drawing.Size(246, 42);
            this.lbRemoveLine.TabIndex = 31;
            this.lbRemoveLine.Text = "Remove Line";
            // 
            // cbLineName
            // 
            this.cbLineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineName.FormattingEnabled = true;
            this.cbLineName.Location = new System.Drawing.Point(99, 77);
            this.cbLineName.Name = "cbLineName";
            this.cbLineName.Size = new System.Drawing.Size(121, 21);
            this.cbLineName.TabIndex = 30;
            this.cbLineName.SelectedIndexChanged += new System.EventHandler(this.cbLineName_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtLineType);
            this.groupBox.Controls.Add(this.txtLineLength);
            this.groupBox.Controls.Add(this.txtFoundedYear);
            this.groupBox.Controls.Add(this.lbFoundedYear);
            this.groupBox.Controls.Add(this.lbLineType);
            this.groupBox.Controls.Add(this.lbLineLength);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(16, 115);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(331, 162);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Line Details: ";
            // 
            // txtLineType
            // 
            this.txtLineType.Enabled = false;
            this.txtLineType.Location = new System.Drawing.Point(131, 115);
            this.txtLineType.Name = "txtLineType";
            this.txtLineType.Size = new System.Drawing.Size(100, 23);
            this.txtLineType.TabIndex = 25;
            // 
            // txtLineLength
            // 
            this.txtLineLength.Enabled = false;
            this.txtLineLength.Location = new System.Drawing.Point(131, 82);
            this.txtLineLength.Name = "txtLineLength";
            this.txtLineLength.Size = new System.Drawing.Size(73, 23);
            this.txtLineLength.TabIndex = 24;
            // 
            // txtFoundedYear
            // 
            this.txtFoundedYear.Enabled = false;
            this.txtFoundedYear.Location = new System.Drawing.Point(131, 44);
            this.txtFoundedYear.Name = "txtFoundedYear";
            this.txtFoundedYear.Size = new System.Drawing.Size(73, 23);
            this.txtFoundedYear.TabIndex = 23;
            // 
            // lbFoundedYear
            // 
            this.lbFoundedYear.AutoSize = true;
            this.lbFoundedYear.BackColor = System.Drawing.Color.Transparent;
            this.lbFoundedYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoundedYear.Location = new System.Drawing.Point(16, 47);
            this.lbFoundedYear.Name = "lbFoundedYear";
            this.lbFoundedYear.Size = new System.Drawing.Size(100, 15);
            this.lbFoundedYear.TabIndex = 15;
            this.lbFoundedYear.Text = "Founded Year:";
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
            // lbLineLength
            // 
            this.lbLineLength.AutoSize = true;
            this.lbLineLength.BackColor = System.Drawing.Color.Transparent;
            this.lbLineLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineLength.Location = new System.Drawing.Point(16, 85);
            this.lbLineLength.Name = "lbLineLength";
            this.lbLineLength.Size = new System.Drawing.Size(56, 15);
            this.lbLineLength.TabIndex = 17;
            this.lbLineLength.Text = "Length:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(216, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(57, 296);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "OK";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ibLineName
            // 
            this.ibLineName.AutoSize = true;
            this.ibLineName.BackColor = System.Drawing.Color.Transparent;
            this.ibLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLineName.Location = new System.Drawing.Point(13, 79);
            this.ibLineName.Name = "ibLineName";
            this.ibLineName.Size = new System.Drawing.Size(80, 15);
            this.ibLineName.TabIndex = 26;
            this.ibLineName.Text = "Line Name:";
            // 
            // frmRemoveLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 341);
            this.Controls.Add(this.lbRemoveLine);
            this.Controls.Add(this.cbLineName);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.ibLineName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveLine_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveLine_Load);
            this.MouseEnter += new System.EventHandler(this.frmRemoveLine_MouseEnter);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRemoveLine;
        private System.Windows.Forms.ComboBox cbLineName;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lbFoundedYear;
        private System.Windows.Forms.Label lbLineType;
        private System.Windows.Forms.Label lbLineLength;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label ibLineName;
        private System.Windows.Forms.TextBox txtLineLength;
        private System.Windows.Forms.TextBox txtFoundedYear;
        private System.Windows.Forms.TextBox txtLineType;
    }
}