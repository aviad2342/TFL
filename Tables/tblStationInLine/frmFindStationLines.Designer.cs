namespace HW5.Tables.tblStationInLine
{
    partial class frmFindStationLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindStationLines));
            this.dataGridStationLine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStationLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStationLine
            // 
            this.dataGridStationLine.AllowUserToAddRows = false;
            this.dataGridStationLine.AllowUserToDeleteRows = false;
            this.dataGridStationLine.AllowUserToResizeColumns = false;
            this.dataGridStationLine.AllowUserToResizeRows = false;
            this.dataGridStationLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStationLine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStationLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStationLine.Location = new System.Drawing.Point(0, 0);
            this.dataGridStationLine.Name = "dataGridStationLine";
            this.dataGridStationLine.ReadOnly = true;
            this.dataGridStationLine.RowHeadersVisible = false;
            this.dataGridStationLine.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridStationLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStationLine.Size = new System.Drawing.Size(194, 257);
            this.dataGridStationLine.TabIndex = 0;
            // 
            // frmFindStationLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(194, 257);
            this.Controls.Add(this.dataGridStationLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindStationLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Stations Lines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindStationLines_FormClosing);
            this.Load += new System.EventHandler(this.frmFindStationLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStationLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStationLine;
    }
}