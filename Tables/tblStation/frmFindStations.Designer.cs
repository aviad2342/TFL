namespace HW5.Tables.tblStation
{
    partial class frmFindStations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindStations));
            this.dataGridStations = new System.Windows.Forms.DataGridView();
            this.tblStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFL_HW2DataSet3 = new HW5.TFL_HW2DataSet3();
            this.tblStationTableAdapter = new HW5.TFL_HW2DataSet3TableAdapters.tblStationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFL_HW2DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStations
            // 
            this.dataGridStations.AllowUserToAddRows = false;
            this.dataGridStations.AllowUserToDeleteRows = false;
            this.dataGridStations.AllowUserToResizeColumns = false;
            this.dataGridStations.AllowUserToResizeRows = false;
            this.dataGridStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStations.Location = new System.Drawing.Point(0, 0);
            this.dataGridStations.Name = "dataGridStations";
            this.dataGridStations.ReadOnly = true;
            this.dataGridStations.RowHeadersVisible = false;
            this.dataGridStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStations.Size = new System.Drawing.Size(378, 304);
            this.dataGridStations.TabIndex = 0;
            // 
            // tblStationBindingSource
            // 
            this.tblStationBindingSource.DataMember = "tblStation";
            this.tblStationBindingSource.DataSource = this.tFL_HW2DataSet3;
            // 
            // tFL_HW2DataSet3
            // 
            this.tFL_HW2DataSet3.DataSetName = "TFL_HW2DataSet3";
            this.tFL_HW2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStationTableAdapter
            // 
            this.tblStationTableAdapter.ClearBeforeFill = true;
            // 
            // frmFindStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 304);
            this.Controls.Add(this.dataGridStations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFindStations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Stations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindStations_FormClosing);
            this.Load += new System.EventHandler(this.frmDisplayStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFL_HW2DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStations;
        private TFL_HW2DataSet3 tFL_HW2DataSet3;
        private System.Windows.Forms.BindingSource tblStationBindingSource;
        private TFL_HW2DataSet3TableAdapters.tblStationTableAdapter tblStationTableAdapter;
    }
}