namespace Sample_Projectt
{
    partial class ClientStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientStatement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.listBoxCustName = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPurGold = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItm = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(65, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(678, 396);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SUMIT METALS";
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbClient.DropDownHeight = 70;
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.IntegralHeight = false;
            this.cmbClient.ItemHeight = 18;
            this.cmbClient.Location = new System.Drawing.Point(553, 49);
            this.cmbClient.MaxDropDownItems = 5;
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(190, 26);
            this.cmbClient.TabIndex = 4;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            this.cmbClient.TextChanged += new System.EventHandler(this.cmbClient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CUSTOMER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MOBILE NUMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "DATE";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(549, 165);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(26, 20);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "na";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(549, 127);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(26, 20);
            this.lblAdd.TabIndex = 10;
            this.lblAdd.Text = "na";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.BackColor = System.Drawing.Color.Transparent;
            this.lblMobile.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(549, 89);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(26, 20);
            this.lblMobile.TabIndex = 9;
            this.lblMobile.Text = "na";
            // 
            // listBoxCustName
            // 
            this.listBoxCustName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustName.FormattingEnabled = true;
            this.listBoxCustName.ItemHeight = 16;
            this.listBoxCustName.Location = new System.Drawing.Point(554, 74);
            this.listBoxCustName.Name = "listBoxCustName";
            this.listBoxCustName.Size = new System.Drawing.Size(189, 36);
            this.listBoxCustName.TabIndex = 12;
            this.listBoxCustName.SelectedIndexChanged += new System.EventHandler(this.listBoxCustName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Total Cash";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.BackColor = System.Drawing.Color.Transparent;
            this.lblCash.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(701, 627);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(29, 21);
            this.lblCash.TabIndex = 39;
            this.lblCash.Text = "na";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Pure Gold";
            // 
            // lblPurGold
            // 
            this.lblPurGold.AutoSize = true;
            this.lblPurGold.BackColor = System.Drawing.Color.Transparent;
            this.lblPurGold.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurGold.Location = new System.Drawing.Point(531, 627);
            this.lblPurGold.Name = "lblPurGold";
            this.lblPurGold.Size = new System.Drawing.Size(29, 21);
            this.lblPurGold.TabIndex = 37;
            this.lblPurGold.Text = "na";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(248, 628);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 20);
            this.lbl.TabIndex = 36;
            this.lbl.Text = "Quantity";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(340, 627);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(29, 21);
            this.lblQuantity.TabIndex = 35;
            this.lblQuantity.Text = "na";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Item Weight ";
            // 
            // lblItm
            // 
            this.lblItm.AutoSize = true;
            this.lblItm.BackColor = System.Drawing.Color.Transparent;
            this.lblItm.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItm.Location = new System.Drawing.Point(188, 627);
            this.lblItm.Name = "lblItm";
            this.lblItm.Size = new System.Drawing.Size(29, 21);
            this.lblItm.TabIndex = 33;
            this.lblItm.Text = "na";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(362, 664);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 31);
            this.btnPrint.TabIndex = 109;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ClientStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 738);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPurGold);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblItm);
            this.Controls.Add(this.listBoxCustName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientStatement";
            this.Text = "ClientStatement";
            this.Load += new System.EventHandler(this.ClientStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.ListBox listBoxCustName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPurGold;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItm;
        private System.Windows.Forms.Button btnPrint;
    }
}