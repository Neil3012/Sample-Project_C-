namespace Sample_Projectt
{
    partial class Cashout
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbSuplierName = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.cmbTransctionID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPureGold = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSupplier = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(51, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 114);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(116, 87);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(14, 20);
            this.lblDate.TabIndex = 104;
            this.lblDate.Text = ".";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(465, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 38);
            this.btnSubmit.TabIndex = 105;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbSuplierName
            // 
            this.cmbSuplierName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbSuplierName.DropDownHeight = 80;
            this.cmbSuplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuplierName.FormattingEnabled = true;
            this.cmbSuplierName.IntegralHeight = false;
            this.cmbSuplierName.Location = new System.Drawing.Point(500, 39);
            this.cmbSuplierName.Name = "cmbSuplierName";
            this.cmbSuplierName.Size = new System.Drawing.Size(194, 28);
            this.cmbSuplierName.TabIndex = 89;
            this.cmbSuplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSuplierName_SelectedIndexChanged);
            this.cmbSuplierName.TextChanged += new System.EventHandler(this.cmbSuplierName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(334, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "Supplier_Name";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(500, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(194, 26);
            this.txtId.TabIndex = 91;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(334, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 92;
            this.label13.Text = "Supplier_ID";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 93;
            this.label12.Text = "Current Cash";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtCurrent
            // 
            this.txtCurrent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(500, 225);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(194, 26);
            this.txtCurrent.TabIndex = 94;
            this.txtCurrent.TextChanged += new System.EventHandler(this.txtCurrent_TextChanged);
            this.txtCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // cmbTransctionID
            // 
            this.cmbTransctionID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTransctionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransctionID.FormattingEnabled = true;
            this.cmbTransctionID.Location = new System.Drawing.Point(500, 177);
            this.cmbTransctionID.Name = "cmbTransctionID";
            this.cmbTransctionID.Size = new System.Drawing.Size(194, 28);
            this.cmbTransctionID.TabIndex = 100;
            this.cmbTransctionID.SelectedIndexChanged += new System.EventHandler(this.cmbTransctionID_SelectedIndexChanged);
            this.cmbTransctionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Transection ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.Location = new System.Drawing.Point(500, 133);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Size = new System.Drawing.Size(194, 26);
            this.txtTotalCash.TabIndex = 102;
            this.txtTotalCash.TextChanged += new System.EventHandler(this.txtTotalCash_TextChanged);
            this.txtTotalCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Total Cash";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Equivalent Gold";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPureGold
            // 
            this.txtPureGold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPureGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPureGold.Location = new System.Drawing.Point(500, 275);
            this.txtPureGold.Name = "txtPureGold";
            this.txtPureGold.Size = new System.Drawing.Size(194, 26);
            this.txtPureGold.TabIndex = 107;
            this.txtPureGold.TextChanged += new System.EventHandler(this.txtPureGold_TextChanged);
            this.txtPureGold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FloatNumbers_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "Rate:=";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(116, 124);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(14, 20);
            this.lblRate.TabIndex = 113;
            this.lblRate.Text = ".";
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Date=>";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listBoxSupplier
            // 
            this.listBoxSupplier.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSupplier.FormattingEnabled = true;
            this.listBoxSupplier.ItemHeight = 16;
            this.listBoxSupplier.Location = new System.Drawing.Point(501, 68);
            this.listBoxSupplier.Name = "listBoxSupplier";
            this.listBoxSupplier.Size = new System.Drawing.Size(194, 52);
            this.listBoxSupplier.TabIndex = 116;
            this.listBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.listBoxSupplier_SelectedIndexChanged);
            // 
            // Cashout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.listBoxSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPureGold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTransctionID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbSuplierName);
            this.Name = "Cashout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashout";
            this.Load += new System.EventHandler(this.Cashout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbSuplierName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.ComboBox cmbTransctionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPureGold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxSupplier;
    }
}