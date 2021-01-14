namespace Sample_Projectt
{
    partial class ClientReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientReport));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.txtClintNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Transection No";
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbClient.DropDownHeight = 70;
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.IntegralHeight = false;
            this.cmbClient.Location = new System.Drawing.Point(193, 76);
            this.cmbClient.MaxDropDownItems = 5;
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(227, 28);
            this.cmbClient.TabIndex = 5;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(47, 138);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(833, 223);
            this.dataGrid1.TabIndex = 7;
            // 
            // txtClintNam
            // 
            this.txtClintNam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClintNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClintNam.Location = new System.Drawing.Point(688, 76);
            this.txtClintNam.Name = "txtClintNam";
            this.txtClintNam.Size = new System.Drawing.Size(192, 26);
            this.txtClintNam.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client ID";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(436, 385);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 41);
            this.btnPrint.TabIndex = 107;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.printPreviewButton_Click);
            // 
            // ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 512);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtClintNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientReport";
            this.Load += new System.EventHandler(this.ClientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.TextBox txtClintNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
    }
}