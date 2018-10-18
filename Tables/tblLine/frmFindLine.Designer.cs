namespace HW5.Tables.tblLine
{
    partial class frmFindLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindLine));
            this.dataGridLine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLine
            // 
            this.dataGridLine.AllowUserToAddRows = false;
            this.dataGridLine.AllowUserToDeleteRows = false;
            this.dataGridLine.AllowUserToResizeColumns = false;
            this.dataGridLine.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLine.Location = new System.Drawing.Point(0, 0);
            this.dataGridLine.Name = "dataGridLine";
            this.dataGridLine.ReadOnly = true;
            this.dataGridLine.RowHeadersVisible = false;
            this.dataGridLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLine.Size = new System.Drawing.Size(393, 286);
            this.dataGridLine.TabIndex = 0;
            this.dataGridLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLine_CellContentClick);
            // 
            // frmFindLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(393, 286);
            this.Controls.Add(this.dataGridLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindLine_FormClosing);
            this.Load += new System.EventHandler(this.frmFindLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLine;
    }
}