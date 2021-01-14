namespace Sample_Projectt
{
    partial class SuppilerPopUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppilerPopUP));
            this.label4 = new System.Windows.Forms.Label();
            this.txtCashPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.cmbSpplierName = new System.Windows.Forms.ComboBox();
            this.txtGoldPaid = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cash Paid";
            // 
            // txtCashPaid
            // 
            this.txtCashPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashPaid.Location = new System.Drawing.Point(356, 266);
            this.txtCashPaid.Name = "txtCashPaid";
            this.txtCashPaid.Size = new System.Drawing.Size(194, 23);
            this.txtCashPaid.TabIndex = 56;
            this.txtCashPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Gold Paid";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(215, 174);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 20);
            this.lblID.TabIndex = 53;
            this.lblID.Text = "Supllier ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(356, 172);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(194, 23);
            this.txtID.TabIndex = 52;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(215, 127);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 51;
            this.lblname.Text = "Name";
            // 
            // cmbSpplierName
            // 
            this.cmbSpplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpplierName.FormattingEnabled = true;
            this.cmbSpplierName.Location = new System.Drawing.Point(356, 124);
            this.cmbSpplierName.Name = "cmbSpplierName";
            this.cmbSpplierName.Size = new System.Drawing.Size(194, 24);
            this.cmbSpplierName.TabIndex = 50;
            this.cmbSpplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSpplierName_SelectedIndexChanged);
            // 
            // txtGoldPaid
            // 
            this.txtGoldPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoldPaid.Location = new System.Drawing.Point(356, 219);
            this.txtGoldPaid.Name = "txtGoldPaid";
            this.txtGoldPaid.Size = new System.Drawing.Size(194, 23);
            this.txtGoldPaid.TabIndex = 70;
            this.txtGoldPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(356, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 71;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Transection ID";
            // 
            // txtTransID
            // 
            this.txtTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransID.Location = new System.Drawing.Point(356, 77);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(194, 23);
            this.txtTransID.TabIndex = 72;
            // 
            // SuppilerPopUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtGoldPaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCashPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.cmbSpplierName);
            this.Name = "SuppilerPopUP";
            this.Text = "SuppilerPopUP";
            this.Load += new System.EventHandler(this.SuppilerPopUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCashPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbSpplierName;
        private System.Windows.Forms.TextBox txtGoldPaid;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransID;
    }
}