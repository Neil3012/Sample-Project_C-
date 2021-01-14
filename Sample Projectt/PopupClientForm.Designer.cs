namespace Sample_Projectt
{
    partial class PopupClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCashPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransectionid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(306, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtGold
            // 
            this.txtGold.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGold.Location = new System.Drawing.Point(306, 193);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(192, 26);
            this.txtGold.TabIndex = 3;
            this.txtGold.TextChanged += new System.EventHandler(this.txtGold_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gold Paid";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(306, 290);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(192, 26);
            this.txtdate.TabIndex = 5;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(382, 341);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 31);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(306, 94);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 26);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 292);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtCashPaid
            // 
            this.txtCashPaid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCashPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashPaid.Location = new System.Drawing.Point(306, 242);
            this.txtCashPaid.Name = "txtCashPaid";
            this.txtCashPaid.Size = new System.Drawing.Size(192, 26);
            this.txtCashPaid.TabIndex = 18;
            this.txtCashPaid.TextChanged += new System.EventHandler(this.txtCashPaid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cash Paid";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTransectionid
            // 
            this.txtTransectionid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTransectionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransectionid.Location = new System.Drawing.Point(306, 50);
            this.txtTransectionid.Name = "txtTransectionid";
            this.txtTransectionid.Size = new System.Drawing.Size(192, 26);
            this.txtTransectionid.TabIndex = 20;
            this.txtTransectionid.TextChanged += new System.EventHandler(this.txtTransectionid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Transection ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PopupClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTransectionid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCashPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupClientForm";
            this.Text = "PopupClientForm";
            this.Load += new System.EventHandler(this.PopupClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCashPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransectionid;
        private System.Windows.Forms.Label label5;
    }
}