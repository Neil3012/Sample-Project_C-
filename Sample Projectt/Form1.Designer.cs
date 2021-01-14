namespace Sample_Projectt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Create = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Submit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtSold = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldDataSet = new Sample_Projectt.GoldDataSet();
            this.inventoryTableAdapter = new Sample_Projectt.GoldDataSetTableAdapters.InventoryTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Create);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 181);
            this.panel1.TabIndex = 0;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(327, 132);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 12;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(587, 93);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(56, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "LOCATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PHONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAME";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(587, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Submit);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txtCash);
            this.panel2.Controls.Add(this.txtBalance);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Controls.Add(this.txtSold);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtItem);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbItem);
            this.panel2.Location = new System.Drawing.Point(26, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 242);
            this.panel2.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(691, 71);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(55, 23);
            this.Submit.TabIndex = 13;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(633, 37);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(64, 20);
            this.txtCash.TabIndex = 17;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(538, 37);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(64, 20);
            this.txtBalance.TabIndex = 16;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(451, 37);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(64, 20);
            this.txtWeight.TabIndex = 15;
            // 
            // txtSold
            // 
            this.txtSold.Location = new System.Drawing.Point(353, 37);
            this.txtSold.Name = "txtSold";
            this.txtSold.Size = new System.Drawing.Size(64, 20);
            this.txtSold.TabIndex = 14;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(249, 37);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(64, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(148, 37);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(64, 20);
            this.txtItem.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(642, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Cash";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Weight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sell Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Item Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ITEM Name";
            // 
            // cmbItem
            // 
            this.cmbItem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventoryBindingSource, "Item_Name", true));
            this.cmbItem.DataSource = this.inventoryBindingSource;
            this.cmbItem.DisplayMember = "Item_Name";
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(19, 37);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(89, 21);
            this.cmbItem.TabIndex = 0;
            this.cmbItem.ValueMember = "Item_Name";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.goldDataSet;
            // 
            // goldDataSet
            // 
            this.goldDataSet.DataSetName = "GoldDataSet";
            this.goldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.createToolStripMenuItem.Text = " CLIENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtSold;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Create;
        private GoldDataSet goldDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private GoldDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    }
}

