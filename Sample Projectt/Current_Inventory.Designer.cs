namespace Sample_Projectt
{
    partial class Current_Inventory
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
            this.currentGrid = new System.Windows.Forms.DataGrid();
            this.gridViewCurrent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // currentGrid
            // 
            this.currentGrid.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.currentGrid.DataMember = "";
            this.currentGrid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGrid.ForeColor = System.Drawing.Color.Black;
            this.currentGrid.GridLineColor = System.Drawing.Color.DarkRed;
            this.currentGrid.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGrid.HeaderForeColor = System.Drawing.Color.Red;
            this.currentGrid.Location = new System.Drawing.Point(34, 29);
            this.currentGrid.Name = "currentGrid";
            this.currentGrid.PreferredColumnWidth = 100;
            this.currentGrid.RowHeaderWidth = 50;
            this.currentGrid.Size = new System.Drawing.Size(724, 485);
            this.currentGrid.TabIndex = 5;
            // 
            // gridViewCurrent
            // 
            this.gridViewCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCurrent.Location = new System.Drawing.Point(628, 140);
            this.gridViewCurrent.Name = "gridViewCurrent";
            this.gridViewCurrent.Size = new System.Drawing.Size(367, 238);
            this.gridViewCurrent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(764, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "CURRENT STOCK";
            // 
            // Current_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewCurrent);
            this.Controls.Add(this.currentGrid);
            this.Name = "Current_Inventory";
            this.Text = "Current_Inventory";
            this.Load += new System.EventHandler(this.Current_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid currentGrid;
        private System.Windows.Forms.DataGridView gridViewCurrent;
        private System.Windows.Forms.Label label1;
    }
}