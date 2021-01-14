namespace Sample_Projectt
{
    partial class GoldLive_Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoldLive_Popup));
            this.txtDatePremain = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitInitial = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtDatePremain
            // 
            this.txtDatePremain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDatePremain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatePremain.Location = new System.Drawing.Point(199, 42);
            this.txtDatePremain.Name = "txtDatePremain";
            this.txtDatePremain.Size = new System.Drawing.Size(194, 26);
            this.txtDatePremain.TabIndex = 89;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(82, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 87;
            this.label17.Text = "Gold Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Date";
            // 
            // btnSubmitInitial
            // 
            this.btnSubmitInitial.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitInitial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmitInitial.BackgroundImage")));
            this.btnSubmitInitial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitInitial.FlatAppearance.BorderSize = 0;
            this.btnSubmitInitial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitInitial.Location = new System.Drawing.Point(169, 139);
            this.btnSubmitInitial.Name = "btnSubmitInitial";
            this.btnSubmitInitial.Size = new System.Drawing.Size(75, 34);
            this.btnSubmitInitial.TabIndex = 91;
            this.btnSubmitInitial.Text = "Submit";
            this.btnSubmitInitial.UseVisualStyleBackColor = false;
            this.btnSubmitInitial.Click += new System.EventHandler(this.btnSubmitInitial_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker1.TabIndex = 92;
            // 
            // GoldLive_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sample_Projectt.Properties.Resources.metallic_effect_in_photoshop_4b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 221);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSubmitInitial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatePremain);
            this.Controls.Add(this.label17);
            this.Name = "GoldLive_Popup";
            this.Text = "GoldLive_Popup";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatePremain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitInitial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}