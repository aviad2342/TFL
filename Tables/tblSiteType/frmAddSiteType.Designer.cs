namespace HW5.Tables.tblSiteType
{
    partial class frmAddSiteType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSiteType));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(204, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSite.Location = new System.Drawing.Point(58, 163);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(88, 24);
            this.btnAddSite.TabIndex = 13;
            this.btnAddSite.Text = "OK";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Aharoni", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbType.Location = new System.Drawing.Point(51, 90);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(76, 15);
            this.lbType.TabIndex = 17;
            this.lbType.Text = "Site Type:";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(133, 87);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(126, 23);
            this.txtType.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Site Type";
            // 
            // frmAddSiteType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HW5.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSiteType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Site Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddSiteType_FormClosing);
            this.Load += new System.EventHandler(this.frmAddSiteType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
    }
}