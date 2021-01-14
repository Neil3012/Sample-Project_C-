namespace Sample_Projectt
{
    partial class Summery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summery));
            this.gridInventoryDetails = new System.Windows.Forms.DataGridView();
            this.gridPurchasedetails = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.datePickTo = new System.Windows.Forms.DateTimePicker();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.lblFrom = new System.Windows.Forms.Label();
            this.datePickFrom = new System.Windows.Forms.DateTimePicker();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblfine = new System.Windows.Forms.Label();
            this.lblSupGoldReceive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSupGoldPaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPurchasepure = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.lblPurchaseWeight = new System.Windows.Forms.Label();
            this.lblo = new System.Windows.Forms.Label();
            this.lblPurchaseQuantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printDailog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.lblFinePurchase = new System.Windows.Forms.Label();
            this.gridSupplierTransection = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasedetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplierTransection)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInventoryDetails
            // 
            this.gridInventoryDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridInventoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventoryDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridInventoryDetails.GridColor = System.Drawing.Color.DarkRed;
            this.gridInventoryDetails.Location = new System.Drawing.Point(6, 102);
            this.gridInventoryDetails.Name = "gridInventoryDetails";
            this.gridInventoryDetails.Size = new System.Drawing.Size(670, 237);
            this.gridInventoryDetails.TabIndex = 0;
            this.gridInventoryDetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvent_RowEnter);
            this.gridInventoryDetails.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvent_RowLeave);
            // 
            // gridPurchasedetails
            // 
            this.gridPurchasedetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPurchasedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPurchasedetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridPurchasedetails.GridColor = System.Drawing.Color.DarkRed;
            this.gridPurchasedetails.Location = new System.Drawing.Point(6, 384);
            this.gridPurchasedetails.Name = "gridPurchasedetails";
            this.gridPurchasedetails.Size = new System.Drawing.Size(670, 262);
            this.gridPurchasedetails.TabIndex = 2;
            this.gridPurchasedetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_RowEnter);
            this.gridPurchasedetails.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_RowLeave);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(40, 351);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(111, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Total Weight:-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.datePickTo);
            this.groupBox1.Controls.Add(this.rbMonth);
            this.groupBox1.Controls.Add(this.rbDay);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.datePickFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounting Summery:-";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(666, 33);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 39);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(765, 33);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(82, 39);
            this.btnShow.TabIndex = 81;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(453, 50);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 20);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            // 
            // datePickTo
            // 
            this.datePickTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickTo.Location = new System.Drawing.Point(499, 45);
            this.datePickTo.Name = "datePickTo";
            this.datePickTo.Size = new System.Drawing.Size(122, 26);
            this.datePickTo.TabIndex = 4;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(6, 64);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(168, 24);
            this.rbMonth.TabIndex = 3;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Monthly Summary";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(6, 32);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(137, 24);
            this.rbDay.TabIndex = 2;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Day Summary";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(228, 51);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // datePickFrom
            // 
            this.datePickFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickFrom.Location = new System.Drawing.Point(296, 46);
            this.datePickFrom.Name = "datePickFrom";
            this.datePickFrom.Size = new System.Drawing.Size(122, 26);
            this.datePickFrom.TabIndex = 0;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(146, 351);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 17);
            this.lbltotal.TabIndex = 7;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(230, 351);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 17);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Total Quantity:-";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(347, 351);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 17);
            this.lblQuantity.TabIndex = 9;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(441, 351);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(94, 17);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Gold_Paid:-";
            // 
            // lblfine
            // 
            this.lblfine.AutoSize = true;
            this.lblfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfine.Location = new System.Drawing.Point(565, 351);
            this.lblfine.Name = "lblfine";
            this.lblfine.Size = new System.Drawing.Size(14, 17);
            this.lblfine.TabIndex = 11;
            this.lblfine.Text = "-";
            // 
            // lblSupGoldReceive
            // 
            this.lblSupGoldReceive.AutoSize = true;
            this.lblSupGoldReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupGoldReceive.Location = new System.Drawing.Point(527, 695);
            this.lblSupGoldReceive.Name = "lblSupGoldReceive";
            this.lblSupGoldReceive.Size = new System.Drawing.Size(13, 17);
            this.lblSupGoldReceive.TabIndex = 17;
            this.lblSupGoldReceive.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Gold_Receive:-";
            // 
            // lblSupGoldPaid
            // 
            this.lblSupGoldPaid.AutoSize = true;
            this.lblSupGoldPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupGoldPaid.Location = new System.Drawing.Point(228, 695);
            this.lblSupGoldPaid.Name = "lblSupGoldPaid";
            this.lblSupGoldPaid.Size = new System.Drawing.Size(13, 17);
            this.lblSupGoldPaid.TabIndex = 13;
            this.lblSupGoldPaid.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 695);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total Gold_Paid:-";
            // 
            // lblPurchasepure
            // 
            this.lblPurchasepure.AutoSize = true;
            this.lblPurchasepure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasepure.Location = new System.Drawing.Point(1247, 713);
            this.lblPurchasepure.Name = "lblPurchasepure";
            this.lblPurchasepure.Size = new System.Drawing.Size(13, 17);
            this.lblPurchasepure.TabIndex = 23;
            this.lblPurchasepure.Text = ".";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lble.Location = new System.Drawing.Point(441, 659);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(120, 17);
            this.lble.TabIndex = 22;
            this.lble.Text = "Gold_Receive:-";
            // 
            // lblPurchaseWeight
            // 
            this.lblPurchaseWeight.AutoSize = true;
            this.lblPurchaseWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseWeight.Location = new System.Drawing.Point(334, 659);
            this.lblPurchaseWeight.Name = "lblPurchaseWeight";
            this.lblPurchaseWeight.Size = new System.Drawing.Size(13, 17);
            this.lblPurchaseWeight.TabIndex = 21;
            this.lblPurchaseWeight.Text = ".";
            // 
            // lblo
            // 
            this.lblo.AutoSize = true;
            this.lblo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblo.Location = new System.Drawing.Point(231, 659);
            this.lblo.Name = "lblo";
            this.lblo.Size = new System.Drawing.Size(106, 17);
            this.lblo.TabIndex = 20;
            this.lblo.Text = "Sold Weight:-";
            // 
            // lblPurchaseQuantity
            // 
            this.lblPurchaseQuantity.AutoSize = true;
            this.lblPurchaseQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseQuantity.Location = new System.Drawing.Point(139, 661);
            this.lblPurchaseQuantity.Name = "lblPurchaseQuantity";
            this.lblPurchaseQuantity.Size = new System.Drawing.Size(13, 17);
            this.lblPurchaseQuantity.TabIndex = 19;
            this.lblPurchaseQuantity.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 661);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sold Quantity:-";
            // 
            // printDailog
            // 
            this.printDailog.UseEXDialog = true;
            // 
            // lblFinePurchase
            // 
            this.lblFinePurchase.AutoSize = true;
            this.lblFinePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinePurchase.Location = new System.Drawing.Point(581, 659);
            this.lblFinePurchase.Name = "lblFinePurchase";
            this.lblFinePurchase.Size = new System.Drawing.Size(14, 17);
            this.lblFinePurchase.TabIndex = 24;
            this.lblFinePurchase.Text = "-";
            // 
            // gridSupplierTransection
            // 
            this.gridSupplierTransection.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridSupplierTransection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSupplierTransection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSupplierTransection.GridColor = System.Drawing.Color.DarkRed;
            this.gridSupplierTransection.Location = new System.Drawing.Point(1036, 676);
            this.gridSupplierTransection.Name = "gridSupplierTransection";
            this.gridSupplierTransection.Size = new System.Drawing.Size(116, 17);
            this.gridSupplierTransection.TabIndex = 1;
            this.gridSupplierTransection.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSup_RowEnter);
            this.gridSupplierTransection.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSup_RowLeave);
            // 
            // Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 749);
            this.Controls.Add(this.lblFinePurchase);
            this.Controls.Add(this.lblPurchasepure);
            this.Controls.Add(this.lble);
            this.Controls.Add(this.lblPurchaseWeight);
            this.Controls.Add(this.lblo);
            this.Controls.Add(this.lblPurchaseQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSupGoldReceive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSupGoldPaid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblfine);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gridPurchasedetails);
            this.Controls.Add(this.gridSupplierTransection);
            this.Controls.Add(this.gridInventoryDetails);
            this.Name = "Summery";
            this.Text = "b";
            this.Load += new System.EventHandler(this.Summery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasedetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplierTransection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridInventoryDetails;
        private System.Windows.Forms.DataGridView gridPurchasedetails;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker datePickTo;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker datePickFrom;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblfine;
        private System.Windows.Forms.Label lblSupGoldReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSupGoldPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPurchasepure;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lblPurchaseWeight;
        private System.Windows.Forms.Label lblo;
        private System.Windows.Forms.Label lblPurchaseQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintDialog printDailog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label lblFinePurchase;
        private System.Windows.Forms.DataGridView gridSupplierTransection;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
    }
}