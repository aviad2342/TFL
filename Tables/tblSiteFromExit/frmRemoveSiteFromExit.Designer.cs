namespace HW5.Tables.tblSiteFromExit
{
    partial class frmRemoveSiteFromExit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveSiteFromExit));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.lbSiteName = new System.Windows.Forms.Label();
            this.lbStationName = new System.Windows.Forms.Label();
            this.lbLineName = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtLineName = new System.Windows.Forms.TextBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(1, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(421, 265);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(243, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(78, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSiteName
            // 
            this.txtSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiteName.Enabled = false;
            this.txtSiteName.Location = new System.Drawing.Point(106, 25);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(148, 23);
            this.txtSiteName.TabIndex = 23;
            // 
            // lbSiteName
            // 
            this.lbSiteName.AutoSize = true;
            this.lbSiteName.BackColor = System.Drawing.Color.Transparent;
            this.lbSiteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiteName.Location = new System.Drawing.Point(6, 27);
            this.lbSiteName.Name = "lbSiteName";
            this.lbSiteName.Size = new System.Drawing.Size(78, 15);
            this.lbSiteName.TabIndex = 24;
            this.lbSiteName.Text = "Site Name:";
            // 
            // lbStationName
            // 
            this.lbStationName.AutoSize = true;
            this.lbStationName.BackColor = System.Drawing.Color.Transparent;
            this.lbStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationName.Location = new System.Drawing.Point(6, 53);
            this.lbStationName.Name = "lbStationName";
            this.lbStationName.Size = new System.Drawing.Size(99, 15);
            this.lbStationName.TabIndex = 25;
            this.lbStationName.Text = "Station Name:";
            // 
            // lbLineName
            // 
            this.lbLineName.AutoSize = true;
            this.lbLineName.BackColor = System.Drawing.Color.Transparent;
            this.lbLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineName.Location = new System.Drawing.Point(6, 78);
            this.lbLineName.Name = "lbLineName";
            this.lbLineName.Size = new System.Drawing.Size(80, 15);
            this.lbLineName.TabIndex = 26;
            this.lbLineName.Text = "Line Name:";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.Location = new System.Drawing.Point(6, 103);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(69, 15);
            this.lbDistance.TabIndex = 27;
            this.lbDistance.Text = "Distance:";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtDistance);
            this.groupBox.Controls.Add(this.txtLineName);
            this.groupBox.Controls.Add(this.txtStationName);
            this.groupBox.Controls.Add(this.lbStationName);
            this.groupBox.Controls.Add(this.lbDistance);
            this.groupBox.Controls.Add(this.txtSiteName);
            this.groupBox.Controls.Add(this.lbLineName);
            this.groupBox.Controls.Add(this.lbSiteName);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(53, 271);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(294, 129);
            this.groupBox.TabIndex = 28;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "You Choose:";
            this.groupBox.Visible = false;
            // 
            // txtDistance
            // 
            this.txtDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistance.Enabled = false;
            this.txtDistance.Location = new System.Drawing.Point(106, 101);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(148, 23);
            this.txtDistance.TabIndex = 30;
            // 
            // txtLineName
            // 
            this.txtLineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineName.Enabled = false;
            this.txtLineName.Location = new System.Drawing.Point(106, 76);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.Size = new System.Drawing.Size(148, 23);
            this.txtLineName.TabIndex = 29;
            // 
            // txtStationName
            // 
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Enabled = false;
            this.txtStationName.Location = new System.Drawing.Point(106, 51);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(148, 23);
            this.txtStationName.TabIndex = 28;
            // 
            // frmRemoveSiteFromExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.BGshow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 461);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveSiteFromExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Site From Exit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveSiteFromExit_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveSiteFromExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Label lbSiteName;
        private System.Windows.Forms.Label lbStationName;
        private System.Windows.Forms.Label lbLineName;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtLineName;
        private System.Windows.Forms.TextBox txtStationName;

    }
}