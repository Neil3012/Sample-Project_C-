namespace Sample_Projectt
{
    partial class CashoutClint
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
            this.listBoxSupplier = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPureGold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransctionID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSupplier
            // 
            this.listBoxSupplier.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSupplier.FormattingEnabled = true;
            this.listBoxSupplier.ItemHeight = 16;
            this.listBoxSupplier.Location = new System.Drawing.Point(525, 60);
            this.listBoxSupplier.Name = "listBoxSupplier";
            this.listBoxSupplier.Size = new System.Drawing.Size(194, 52);
            this.listBoxSupplier.TabIndex = 135;
            this.listBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.listBoxSupplier_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 134;
            this.label5.Text = "Date=>";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(141, 119);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(14, 20);
            this.lblRate.TabIndex = 133;
            this.lblRate.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 132;
            this.label6.Text = "Rate:=";
            // 
            // txtPureGold
            // 
            this.txtPureGold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPureGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPureGold.Location = new System.Drawing.Point(525, 270);
            this.txtPureGold.Name = "txtPureGold";
            this.txtPureGold.Size = new System.Drawing.Size(194, 26);
            this.txtPureGold.TabIndex = 131;
            this.txtPureGold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FloatNumbers_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 130;
            this.label4.Text = "Equivalent Gold";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(490, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 38);
            this.btnSubmit.TabIndex = 129;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(141, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(14, 20);
            this.lblDate.TabIndex = 128;
            this.lblDate.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 127;
            this.label2.Text = "Total Cash";
            // 
            // txtTotalCash
            // 
            this.txtTotalCash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCash.Location = new System.Drawing.Point(525, 128);
            this.txtTotalCash.Name = "txtTotalCash";
            this.txtTotalCash.Size = new System.Drawing.Size(194, 26);
            this.txtTotalCash.TabIndex = 126;
            this.txtTotalCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 125;
            this.label1.Text = "Transection ID";
            // 
            // cmbTransctionID
            // 
            this.cmbTransctionID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTransctionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransctionID.FormattingEnabled = true;
            this.cmbTransctionID.Location = new System.Drawing.Point(525, 172);
            this.cmbTransctionID.Name = "cmbTransctionID";
            this.cmbTransctionID.Size = new System.Drawing.Size(194, 28);
            this.cmbTransctionID.TabIndex = 124;
            this.cmbTransctionID.SelectedIndexChanged += new System.EventHandler(this.cmbTransctionID_SelectedIndexChanged);
            this.cmbTransctionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(76, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 114);
            this.dataGridView1.TabIndex = 123;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtCurrent
            // 
            this.txtCurrent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(525, 220);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(194, 26);
            this.txtCurrent.TabIndex = 122;
            this.txtCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(359, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 121;
            this.label12.Text = "Current Cash";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(359, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 120;
            this.label13.Text = "Supplier_ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(525, 82);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(194, 26);
            this.txtId.TabIndex = 119;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(359, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 118;
            this.label14.Text = "Supplier_Name";
            // 
            // cmbClientName
            // 
            this.cmbClientName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbClientName.DropDownHeight = 80;
            this.cmbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.IntegralHeight = false;
            this.cmbClientName.Location = new System.Drawing.Point(525, 34);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(194, 28);
            this.cmbClientName.TabIndex = 117;
            this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbSuplierName_SelectedIndexChanged);
            this.cmbClientName.TextChanged += new System.EventHandler(this.cmbSuplierName_TextChanged);
            // 
            // CashoutClint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 553);
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
            this.Controls.Add(this.cmbClientName);
            this.Name = "CashoutClint";
            this.Text = "CashoutClint";
            this.Load += new System.EventHandler(this.CashoutClint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPureGold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransctionID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbClientName;
    }
}