namespace HW5.Tables.tblStationInLine
{
    partial class frmRemoveStationFromLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveStationFromLine));
            this.cbStationId = new System.Windows.Forms.ComboBox();
            this.lbStationId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxLineName = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStationId
            // 
            this.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationId.FormattingEnabled = true;
            this.cbStationId.Location = new System.Drawing.Point(106, 62);
            this.cbStationId.Name = "cbStationId";
            this.cbStationId.Size = new System.Drawing.Size(61, 21);
            this.cbStationId.TabIndex = 21;
            this.cbStationId.SelectedIndexChanged += new System.EventHandler(this.cbStationId_SelectedIndexChanged);
            // 
            // lbStationId
            // 
            this.lbStationId.BackColor = System.Drawing.Color.Transparent;
            this.lbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationId.Location = new System.Drawing.Point(28, 64);
            this.lbStationId.Name = "lbStationId";
            this.lbStationId.Size = new System.Drawing.Size(82, 21);
            this.lbStationId.TabIndex = 20;
            this.lbStationId.Text = "Station ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(169, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(43, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxLineName
            // 
            this.lbxLineName.BackColor = System.Drawing.Color.Gray;
            this.lbxLineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLineName.FormattingEnabled = true;
            this.lbxLineName.ItemHeight = 15;
            this.lbxLineName.Location = new System.Drawing.Point(12, 22);
            this.lbxLineName.Name = "lbxLineName";
            this.lbxLineName.Size = new System.Drawing.Size(201, 92);
            this.lbxLineName.TabIndex = 31;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.lbxLineName);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(31, 102);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(227, 125);
            this.groupBox.TabIndex = 32;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "This Station Lines: ";
            this.groupBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Remove Station From Line";
            // 
            // frmRemoveStationFromLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW5.Properties.Resources.graywallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbStationId);
            this.Controls.Add(this.lbStationId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveStationFromLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Station From Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveStationFromLine_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveStationFromLine_Load);
            this.MouseEnter += new System.EventHandler(this.frmRemoveStationFromLine_MouseEnter);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStationId;
        private System.Windows.Forms.Label lbStationId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxLineName;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
    }
}