namespace Sample_Projectt
{
    partial class Login
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Panel panel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblUser;
            System.Windows.Forms.Label lblLiveGold;
            this.btnSubmitEmp = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.txtEpass = new System.Windows.Forms.TextBox();
            this.txtEuser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtApass = new System.Windows.Forms.TextBox();
            this.txtAuser = new System.Windows.Forms.TextBox();
            this.lblhead = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtGoldLive = new System.Windows.Forms.TextBox();
            this.LivePriceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitLive = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            lblLiveGold = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(20, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Location = new System.Drawing.Point(18, 28);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(91, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.SlateGray;
            panel2.Controls.Add(this.btnSubmitEmp);
            panel2.Controls.Add(this.btncan);
            panel2.Controls.Add(this.txtEpass);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(this.txtEuser);
            panel2.Controls.Add(lblUser);
            panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel2.Location = new System.Drawing.Point(448, 233);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(320, 187);
            panel2.TabIndex = 1;
            // 
            // btnSubmitEmp
            // 
            this.btnSubmitEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmitEmp.BackgroundImage")));
            this.btnSubmitEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitEmp.FlatAppearance.BorderSize = 0;
            this.btnSubmitEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEmp.Location = new System.Drawing.Point(181, 125);
            this.btnSubmitEmp.Name = "btnSubmitEmp";
            this.btnSubmitEmp.Size = new System.Drawing.Size(101, 40);
            this.btnSubmitEmp.TabIndex = 7;
            this.btnSubmitEmp.Text = "Submit";
            this.btnSubmitEmp.UseVisualStyleBackColor = true;
            this.btnSubmitEmp.Click += new System.EventHandler(this.btnSubmitEmp_Click);
            // 
            // btncan
            // 
            this.btncan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncan.BackgroundImage")));
            this.btncan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncan.FlatAppearance.BorderSize = 0;
            this.btncan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(64, 125);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(101, 40);
            this.btncan.TabIndex = 6;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = true;
            // 
            // txtEpass
            // 
            this.txtEpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpass.Location = new System.Drawing.Point(113, 67);
            this.txtEpass.Name = "txtEpass";
            this.txtEpass.PasswordChar = '*';
            this.txtEpass.Size = new System.Drawing.Size(181, 26);
            this.txtEpass.TabIndex = 5;
            this.txtEpass.Text = "12345";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(18, 70);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txtEuser
            // 
            this.txtEuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuser.Location = new System.Drawing.Point(113, 22);
            this.txtEuser.Name = "txtEuser";
            this.txtEuser.Size = new System.Drawing.Size(181, 26);
            this.txtEuser.TabIndex = 3;
            this.txtEuser.Text = "Nil";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUser.Location = new System.Drawing.Point(18, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(91, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // lblLiveGold
            // 
            lblLiveGold.AutoSize = true;
            lblLiveGold.BackColor = System.Drawing.Color.Transparent;
            lblLiveGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLiveGold.Location = new System.Drawing.Point(452, 89);
            lblLiveGold.Name = "lblLiveGold";
            lblLiveGold.Size = new System.Drawing.Size(158, 20);
            lblLiveGold.TabIndex = 6;
            lblLiveGold.Text = "Today\'s Gold Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtApass);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtAuser);
            this.panel1.Controls.Add(lblName);
            this.panel1.Location = new System.Drawing.Point(30, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 194);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(66, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(183, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 38);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtApass
            // 
            this.txtApass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApass.Location = new System.Drawing.Point(112, 73);
            this.txtApass.Name = "txtApass";
            this.txtApass.PasswordChar = '*';
            this.txtApass.Size = new System.Drawing.Size(184, 26);
            this.txtApass.TabIndex = 3;
            this.txtApass.Text = "12345";
            // 
            // txtAuser
            // 
            this.txtAuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuser.Location = new System.Drawing.Point(112, 28);
            this.txtAuser.Name = "txtAuser";
            this.txtAuser.Size = new System.Drawing.Size(184, 26);
            this.txtAuser.TabIndex = 1;
            this.txtAuser.Text = "Admin";
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.BackColor = System.Drawing.Color.Transparent;
            this.lblhead.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(121, 25);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(137, 26);
            this.lblhead.TabIndex = 2;
            this.lblhead.Text = "ADMIN LOGIN";
            this.lblhead.Click += new System.EventHandler(this.lblhead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMPLOYEE LOGIN";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(769, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtGoldLive
            // 
            this.txtGoldLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoldLive.Location = new System.Drawing.Point(629, 86);
            this.txtGoldLive.Name = "txtGoldLive";
            this.txtGoldLive.Size = new System.Drawing.Size(118, 26);
            this.txtGoldLive.TabIndex = 7;
            this.txtGoldLive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FloatNumbers_KeyPress);
            // 
            // LivePriceDatePicker
            // 
            this.LivePriceDatePicker.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.LivePriceDatePicker.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.LivePriceDatePicker.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.LivePriceDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivePriceDatePicker.Location = new System.Drawing.Point(474, 46);
            this.LivePriceDatePicker.Name = "LivePriceDatePicker";
            this.LivePriceDatePicker.Size = new System.Drawing.Size(273, 23);
            this.LivePriceDatePicker.TabIndex = 8;
            this.LivePriceDatePicker.ValueChanged += new System.EventHandler(this.LivePriceDatePicker_ValueChanged);
            this.LivePriceDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NOinput_KeyPress);
            // 
            // btnSubmitLive
            // 
            this.btnSubmitLive.BackgroundImage = global::Sample_Projectt.Properties.Resources.button_4;
            this.btnSubmitLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitLive.FlatAppearance.BorderSize = 0;
            this.btnSubmitLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitLive.Location = new System.Drawing.Point(561, 125);
            this.btnSubmitLive.Name = "btnSubmitLive";
            this.btnSubmitLive.Size = new System.Drawing.Size(81, 32);
            this.btnSubmitLive.TabIndex = 6;
            this.btnSubmitLive.Text = "Submit";
            this.btnSubmitLive.UseVisualStyleBackColor = true;
            this.btnSubmitLive.Click += new System.EventHandler(this.btnSubmitLive_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmitLive);
            this.Controls.Add(this.LivePriceDatePicker);
            this.Controls.Add(this.txtGoldLive);
            this.Controls.Add(lblLiveGold);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtApass;
        private System.Windows.Forms.TextBox txtAuser;
        private System.Windows.Forms.Button btnSubmitEmp;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.TextBox txtEpass;
        private System.Windows.Forms.TextBox txtEuser;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGoldLive;
        private System.Windows.Forms.DateTimePicker LivePriceDatePicker;
        private System.Windows.Forms.Button btnSubmitLive;
    }
}