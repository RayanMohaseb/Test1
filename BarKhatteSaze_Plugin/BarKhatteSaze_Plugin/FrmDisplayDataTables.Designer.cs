namespace BarKhatteSaze_Plugin
{
    partial class FrmDisplayDataTables
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
            this.DtgrdDataTables = new System.Windows.Forms.DataGridView();
            this.CmbbxTableNames = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgrdDataTables
            // 
            this.DtgrdDataTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgrdDataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdDataTables.Location = new System.Drawing.Point(12, 39);
            this.DtgrdDataTables.Name = "DtgrdDataTables";
            this.DtgrdDataTables.Size = new System.Drawing.Size(344, 349);
            this.DtgrdDataTables.TabIndex = 0;
            // 
            // CmbbxTableNames
            // 
            this.CmbbxTableNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbbxTableNames.FormattingEnabled = true;
            this.CmbbxTableNames.Location = new System.Drawing.Point(12, 12);
            this.CmbbxTableNames.Name = "CmbbxTableNames";
            this.CmbbxTableNames.Size = new System.Drawing.Size(345, 21);
            this.CmbbxTableNames.TabIndex = 1;
            this.CmbbxTableNames.SelectedIndexChanged += new System.EventHandler(this.CmbbxTableNames_SelectedIndexChanged);
            // 
            // FrmDisplayDataTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 400);
            this.Controls.Add(this.CmbbxTableNames);
            this.Controls.Add(this.DtgrdDataTables);
            this.Name = "FrmDisplayDataTables";
            this.Text = "FrmDisplayDataTables";
            this.Load += new System.EventHandler(this.FrmDisplayDataTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdDataTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgrdDataTables;
        private System.Windows.Forms.ComboBox CmbbxTableNames;
    }
}