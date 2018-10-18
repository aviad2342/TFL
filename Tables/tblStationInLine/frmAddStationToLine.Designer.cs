namespace HW5.Tables.tblStationInLine
{
    partial class frmAddStationToLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStationToLine));
            this.cbStationId = new System.Windows.Forms.ComboBox();
            this.lbStationId = new System.Windows.Forms.Label();
            this.cbLineName = new System.Windows.Forms.ComboBox();
            this.ibLineName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbStationId
            // 
            this.cbStationId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStationId.FormattingEnabled = true;
            this.cbStationId.Location = new System.Drawing.Point(113, 74);
            this.cbStationId.Name = "cbStationId";
            this.cbStationId.Size = new System.Drawing.Size(61, 22);
            this.cbStationId.TabIndex = 19;
            this.cbStationId.SelectedIndexChanged += new System.EventHandler(this.cbStationId_SelectedIndexChanged);
            // 
            // lbStationId
            // 
            this.lbStationId.BackColor = System.Drawing.Color.Transparent;
            this.lbStationId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStationId.Location = new System.Drawing.Point(25, 74);
            this.lbStationId.Name = "lbStationId";
            this.lbStationId.Size = new System.Drawing.Size(82, 21);
            this.lbStationId.TabIndex = 18;
            this.lbStationId.Text = "Station ID:";
            // 
            // cbLineName
            // 
            this.cbLineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLineName.FormattingEnabled = true;
            this.cbLineName.Location = new System.Drawing.Point(113, 104);
            this.cbLineName.Name = "cbLineName";
            this.cbLineName.Size = new System.Drawing.Size(137, 23);
            this.cbLineName.TabIndex = 26;
            // 
            // ibLineName
            // 
            this.ibLineName.AutoSize = true;
            this.ibLineName.BackColor = System.Drawing.Color.Transparent;
            this.ibLineName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLineName.Location = new System.Drawing.Point(25, 106);
            this.ibLineName.Name = "ibLineName";
            this.ibLineName.Size = new System.Drawing.Size(80, 15);
            this.ibLineName.TabIndex = 25;
            this.ibLineName.Text = "Line Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(191, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(54, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add Station To Line";
            // 
            // txtStationName
            // 
            this.txtStationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStationName.Enabled = false;
            this.txtStationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStationName.Location = new System.Drawing.Point(181, 74);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(107, 23);
            this.txtStationName.TabIndex = 30;
            // 
            // frmAddStationToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW5.Properties.Resources.railroad_tracks_and_train_in_motion_example_of_diagonal_leading_lines_in_photography;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 250);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbLineName);
            this.Controls.Add(this.ibLineName);
            this.Controls.Add(this.cbStationId);
            this.Controls.Add(this.lbStationId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStationToLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Station To Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddStationToLine_FormClosing);
            this.Load += new System.EventHandler(this.frmAddStationToLine_Load);
            this.MouseEnter += new System.EventHandler(this.frmAddStationToLine_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStationId;
        private System.Windows.Forms.Label lbStationId;
        private System.Windows.Forms.ComboBox cbLineName;
        private System.Windows.Forms.Label ibLineName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStationName;
    }
}