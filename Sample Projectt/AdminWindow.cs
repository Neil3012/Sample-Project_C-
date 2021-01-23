using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Sample_Projectt
{
    public partial class AdminWindow : Form
    {
        public static double currentValue = 0.0f;
        int co,co_p;
        int i = 0;
        string[] collection,P_collection;
        bool _notavail;
        int productCount = 0;
        public static double pureGold = 0;
        public static int cash = 0;
        string rbNam = "";
        string value = "";
        float Gold_R, touchPouch, total;
        int count = 0, reportID;

        string UpdateID = "";
        double TotalGold = 0;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        string select, insert, update, insertInventory;

        SqlCommand cmd, cmd1, cmd2;
        DataSet ds = new DataSet();
        //DataTable dt;

        public static string Word = "SUP";

        int ID = 0;
        double G_Receive;
        float Lab;


        public static double gold_Paid = 0.0f;
        public double pureGoldQuantity = 0.0f;
        public int cashQuantity=0;
        public static string nameSupplier = "";
        public static string id_Supplier = "",date="";

        public bool _completeTrans = false;

        TransectionSupplier ts = new TransectionSupplier();
        string _tempPurity = "";


        int rowsCount = 0;
        public AdminWindow()
        {
            //dt = new DataTable();

            InitializeComponent();
            panelSupplier.Hide();
            panelInventory.Hide();
            panelPremainInventory.Hide();
            dataGridInventoryComfirm.Columns.Add("Product_ID", "Product_ID");
            dataGridInventoryComfirm.Columns.Add("Product_Name", "Product_Name");
            dataGridInventoryComfirm.Columns.Add("Supplier_ID", "Supplier_ID");
            dataGridInventoryComfirm.Columns.Add("Supplier_Name", "Supplier_Name");
            dataGridInventoryComfirm.Columns.Add("Item_Weight", "Item_Weight");
            dataGridInventoryComfirm.Columns.Add("Item_Quantity", "Item_Quantity");
            dataGridInventoryComfirm.Columns.Add("Date", "Date");
            dataGridInventoryComfirm.Columns.Add("Purity", "Purity");
            dataGridInventoryComfirm.Columns.Add("Transection_ID", "Transection_ID");
            dataGridInventoryComfirm.Columns.Add("Pure_Gold", "Pure_Gold");
            dataGridInventoryComfirm.Columns.Add("Labour", "Labour");
            dataGridInventoryComfirm.Columns.Add("LabourRS", "LabourRS");
            dataGridInventoryComfirm.Columns.Add("Touch_Pouch", "Touch_Pouch");
            StyleInventoryGrid();

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierRefresh();
            panelSupplier.Show();
            //StyleSupplierGrid(); 
            panelInventory.Hide();
            panelProduct.Hide();
            panelPremainInventory.Hide();


        }
        private void ProductToolStrip_Click(object sender, EventArgs e)
        {
            ProductRefresh();
            panelProduct.Show();

            panelSupplier.Hide();
            panelInventory.Hide();
            panelPremainInventory.Hide();


        }

        private void InventoryToolStrip_Click(object sender, EventArgs e)
        {
            GetSupplierName();
            collection = new string[co];

            GetSupplierNameSearch();
            listBox1.Visible = false;   


            panelSupplier.Hide();
            panelInventory.Hide();////
            TextBlankPreMainInventory();
            GetSupplierName();
            getCountInitial();
            panelProduct.Hide();
            panelPremainInventory.Show();///
            GettingcomboValue();


        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }



        private void AdminWindow_Load(object sender, EventArgs e)
        {

            GetSupplierName();
            collection = new string[co];
          
            GetSupplierNameSearch();

            GetProductName();
            P_collection = new string[co_p];
            GetProductNameSearch();
            listBox1.Visible = false;

            listboxProduct.Visible = false;




            btnCancelInventory.Enabled = true;

            btnuupdate.Enabled = false;
            getCount();
            panelPremainInventory.Hide();

            getCountProduct();
            //dt = new DataTable();
            btnUpdateProduct.Enabled = false;
            datePicker1.Text = DateTime.Now.Date.ToShortDateString();
            datePicker1.Enabled = false;
            datePickPremain.Text = DateTime.Now.ToShortDateString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("KINDLY PLEASE ENTER NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("KINDLY PLEASE ENTER EMAIL.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("KINDLY PLEASE ENTER CONTACT NUMBER", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                count = 0;
            using (con = new SqlConnection(conn))
                {
                    con.Open();
                    select = "select Name from Supplier where Name='" + txtName.Text + "' and Supplier_ID !='"+ UpdateID + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                }
            if (count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("SUPPLIER NAME ALREADY EXIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TextBoxProduct();
                count = 0;
                if (dialogResult == DialogResult.OK)
                {
                    //using (con = new SqlConnection(conn))
                    //{
                    //    string update = "update Supplier set Name='" + txtName.Text + "',Contact=" + txtContact.Text + ",Email='" + txtEmail.Text + "',Location='" + txtLoaction.Text + "'where Supplier_ID='" + UpdateID + "'";
                    //    cmd = new SqlCommand(update, con);
                    //    con.Open();
                    //    cmd.ExecuteNonQuery();
                        dataGridSupplier.DataSource = "";
                     

                    //}
                    btnAdd.Enabled = true;
                    btnDisplay .Enabled = true;
                    btnCancel .Enabled = true;
                    btnuupdate.Enabled = false;

                }
            }
            else
            {
                using (con = new SqlConnection(conn))
                {
                    string update = "update Supplier set Name='" + txtName.Text + "',Contact=" + txtContact.Text + ",Email='" + txtEmail.Text + "',Location='" + txtLoaction.Text + "'where Supplier_ID='" + UpdateID + "'";
                    cmd = new SqlCommand(update, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    ButtonDisableProduct();
                    btnuupdate.Enabled = false;
                    ResetTextBoxesSupplier();
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = true;
                    btnDisplay.Enabled = true;
                    GetData();
                }
                using (con = new SqlConnection(conn))
                {
                    string update = "update SupplierTransection set Supplier_Name='" + txtName.Text + "'where Supplier_ID='" + UpdateID + "'";
                    cmd = new SqlCommand(update, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                
            }
            SupplierRefreshTextBox();


        }
        void GetData()
        {

            DataTable dt = new DataTable();
            select = "select * from Supplier";

            con = new SqlConnection(conn);
            cmd = new SqlCommand(select, con);
            con.Open();
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            dataGridSupplier.DataSource = dt;

            con.Close();
            StyleSupplierGrid();
           
     
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GetData();
            SupplierRefreshTextBox();
            ButtonDisableSupplier();
            SuplierDisableTextBox();
            btnuupdate.Enabled = true;
            ///StyleSupplierGrid();

        }
        void SuplierEnableTextBox()
        {
            txtName.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;
            txtLoaction.Enabled = true;
        }
        void SuplierDisableTextBox()
        {
            txtName.Enabled = false;
            txtContact.Enabled = false;
            txtEmail.Enabled = false;
            txtLoaction.Enabled = false;
        }
        void SupplierRefreshTextBox()
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtLoaction.Text = "";
        }
        private void dataGridSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                SuplierEnableTextBox();
                dataGridSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                UpdateID = (dataGridSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = (dataGridSupplier.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtContact.Text = (dataGridSupplier.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtEmail.Text = dataGridSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtLoaction.Text = dataGridSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                ButtonDisableSupplier();
                btnuupdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please CLICK ON CONTENT NOT on Column Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Console.WriteLine("Print " + e.ColumnIndex + "      " + e.RowIndex);
            }

        }

        void getCount()
        {
            using (con = new SqlConnection(conn))
            {
                string temp = "";
                select = "SELECT TOP 1 Supplier_ID FROM Supplier ORDER BY Supplier_ID DESC";
                con.Open();

                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();
                //rdr.IsDBNull
                while (rdr.Read())
                {
                    temp = (rdr[0]).ToString();
                }
                if (temp != string.Empty)
                {
                    string stringID = temp.Substring(3, 5);

                    ID = Convert.ToInt32(stringID);
                }


            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCount();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("KINDLY PLEASE ENTER NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("KINDLY PLEASE ENTER EMAIL.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("KINDLY PLEASE ENTER CONTACT NUMBER.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                count = 0;

                using (con = new SqlConnection(conn))
                {
                    con.Open();
                    select = "select Name from Supplier where Name='" + txtName.Text + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                }
                if (count >= 1)
                {
                    DialogResult dialogResult = MessageBox.Show("SUPPLIER NAME ALREADY EXIST", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TextBoxProduct();
                    count = 0;
                    if (dialogResult == DialogResult.OK)
                    {

                        btnAdd.Enabled = true;
                        btnDisplay .Enabled = true;
                        //btnCancelProduct.Enabled = true;
                        btnuupdate .Enabled = false;

                    }
                }



                else
                {
                    ID++;
                    value = ID.ToString("00000");
                    string IDPass = Word + value;

                    insert = "insert into Supplier(Supplier_ID,Name,Contact,Email,Location,Balance_Cash,Balance_Gold) values('" + IDPass + "','" + txtName.Text + "','" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtLoaction.Text + "','" + 0 + "','" + 0 + "')";
                    using (con = new SqlConnection(conn))
                    {
                        con.Open();
                        cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                        GetData();
                        MessageBox.Show("SUPPLIER NAME INSERTED SUCCESSFULLY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                SupplierRefreshTextBox();
            }

        }



        void GetInventoyDetails()
        {

            //using (con = new SqlConnection(conn))
            //{
            //    DataTable dt = new DataTable();
            //    string select = "select * from InventoryDetails where Transection_ID='" + txtTransIDmain.Text + "'";
            //    cmd = new SqlCommand(select, con);
            //    con.Open();
            //    rdr = cmd.ExecuteReader();
            //    dt.Load(rdr);
            //    gridInventoryDetails.DataSource = dt;
            //    StyleInventoryGrid();
            //}
        }




        //panel 2 functions are here
        void getCountMain()
        {
            using (con = new SqlConnection(conn))
            {
                string temp = "";
                select = "SELECT TOP 1 ReportID FROM InventoryDetails ORDER BY ReportID DESC";
                con.Open();

                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();
                //rdr.IsDBNull
                while (rdr.Read())
                {
                    temp = (rdr[0]).ToString();
                }
                if (temp != string.Empty)
                {
                    string stringID = temp;

                    reportID = Convert.ToInt32(stringID);
                    reportID++;

                }
                else
                    reportID = 1;
                txtTransIDpremain.Text = ID.ToString();

            }

        }






        void MainWindowComponents()
        {
            txtLabour.Text = "";
            txtLabourRs.Text = "";
            txtQuantity.Text = "";
            txtPure.Text = "";
            txtTouchPouch.Text = "";
            txtProductName.Text = "";
            cmdID.Text = "";
            txtProductID.Text = "";
            txtWeight.Text = "";
           
        }





        private void btnSubmitInventory_Click(object sender, EventArgs e)
        {
            double labour, labourRs, pureGoldWeight;
            count = 0;
            if (cmdID.Text == string.Empty)
            {
                MessageBox.Show("PLEASE SELECT PRODUCT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }          
            else if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER QUANTITY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtLabour.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER LABOUR %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtWeight.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER WEIGHT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
            else if (txtTouchPouch.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER TOUCH POUCH.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtPure.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER PURE WEIGHT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtDate.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER DATE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtLabourRs.Text == string.Empty)
            {
                MessageBox.Show("PLEASE CHECK LABOUR IN RUPEES.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                count = 0;
                using (con = new SqlConnection(conn))
                {
                    con.Open();
                    select = "select Product_Name from Product where " +
                        "Product_Name='" + cmdID.Text + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("YOU HAVE ENTERED WRONG PRODUCT NAME.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtProductID.Text = "";
                    cmdID.Text = "";
                }

                else
                {


                    btnCancelInventory.Enabled = false;
                    productCount++;
                    if (txtLabourRs.Text != "Zero")
                    {
                        labourRs = Convert.ToDouble(txtLabourRs.Text);
                    }
                    else
                        labourRs = 0.0f;

                    if (txtPure.Text != "Zero")
                    {
                        pureGoldWeight = Convert.ToDouble(txtPure.Text);
                    }
                    else
                        pureGoldWeight = 0.0f;
                    if (pureGoldWeight != 0)
                        pureGold += Convert.ToDouble(String.Format("{0:#,##0.000;(#,##0.000);Zero}", pureGoldWeight)); // THIS IS FOR TOTAL GOLD USED AT SUMMARY FOR TOTAL PURE GOLD 
                    else
                        pureGold += pureGoldWeight;
                    TotalGold += Convert.ToDouble(String.Format("{0:#,##0.000;(#,##0.000);Zero}", (txtWeight.Text)));// THIS IS FOR TOTAL GOLD USED AT SUMMARY FOR TOTAL GOLD 
                    //cash = cash + Convert.ToInt32(txtCash.Text);
                    //string radioInput = "";

                    labour = Convert.ToDouble(txtLabour.Text);
                    

                   


                    insert = "insert into InventoryDetails(Product_ID,Product_Name,Supplier_ID,Supplier_Name,Item_Weight,Item_Quantity,Date,Purity,ReportID,Transection_ID,Pure_Gold,Cash,Labour) values" +
                         " " +
                    "( '" + txtProductID.Text + "', '" + cmdID.SelectedItem.ToString() + "','" + txtSupID.Text + "','" + txtSupname.Text + "','" + txtWeight.Text + "','" + txtQuantity.Text + "','" + Convert.ToDateTime(datePicker1.Value.Date).ToString("yyyy-MM-dd") + "','"
                    + rbNam + "','" + reportID + "','" + txtTransIDmain.Text + "','" + txtPure.Text + "','" + txtCash.Text + "','" +labourRs + "')";




                    int n = dataGridInventoryComfirm.Rows.Add();

                    dataGridInventoryComfirm.Rows[n].Cells[0].Value = txtProductID.Text;
                    dataGridInventoryComfirm.Rows[n].Cells[1].Value = cmdID.SelectedItem.ToString();
                    dataGridInventoryComfirm.Rows[n].Cells[2].Value = txtSupID.Text;
                    dataGridInventoryComfirm.Rows[n].Cells[3].Value = txtSupname.Text;
                    dataGridInventoryComfirm.Rows[n].Cells[4].Value = txtWeight.Text;
                    dataGridInventoryComfirm.Rows[n].Cells[5].Value = txtQuantity.Text;
                    dataGridInventoryComfirm.Rows[n].Cells[6].Value = Convert.ToDateTime(datePicker1.Value.Date).ToString("yyyy-MM-dd");
                    dataGridInventoryComfirm.Rows[n].Cells[7].Value = rbNam;




                    dataGridInventoryComfirm.Rows[n].Cells[8].Value = txtTransIDmain.Text;
                    dataGridInventoryComfirm.Rows[n].Cells[9].Value = pureGoldWeight;
                    dataGridInventoryComfirm.Rows[n].Cells[10].Value = labour;
                    dataGridInventoryComfirm.Rows[n].Cells[11].Value = labourRs;
                    dataGridInventoryComfirm.Rows[n].Cells[12].Value = txtTouchPouch.Text;
                    // dataGridInventoryComfirm.Rows[n].Cells[11].Value = txtCash.Text;














                    #region DABDHBFASFB
                    //using (SqlConnection con = new SqlConnection(conn))
                    //{

                    //    getCountMain();
                    //    count = 0;
                    //    select = "select Item_Name from Inventory where Item_Name='" + cmdID.SelectedItem.ToString() + "'";
                    //    cmd = new SqlCommand(select, con);

                    //    con.Open();
                    //    rdr = cmd.ExecuteReader();


                    //    while (rdr.Read())
                    //    {
                    //        count = count + 1;
                    //    }
                    //    con.Close();
                    //    if (count >= 1)
                    //    {
                    //        //MessageBox.Show("Product already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //        insertInventory = "update inventory set Item_Weight=Item_Weight-" + txtPure.Text + ", " +
                    //        "Total_Quantity=Total_Quantity-" + Convert.ToInt32(txtQuantity.Text) + " where Product_ID='" + txtProductID.Text + "'";
                    //    }

                    //    else
                    //    {
                    //        insertInventory = "insert into inventory(Product_Id,Item_Name,Item_Weight,Total_Quantity,Purity)" +
                    //            " values('" + txtProductID.Text + "','" + cmdID.SelectedItem.ToString() + "','" + txtPure.Text + "','" + txtQuantity.Text + "'" +
                    //            ",'" + rbNam + "')";
                    //    }
                    //     labour =Convert.ToDouble(txtWeight.Text) - Convert.ToDouble(txtPure.Text);
                    //    insert = "insert into InventoryDetails(Product_ID,Product_Name,Supplier_ID,Supplier_Name,Item_Weight,Item_Quantity,Date,Purity,ReportID,Transection_ID,Pure_Gold,Cash,Labour) values" +
                    //        " " +
                    //   "( '" + txtProductID.Text + "', '" + cmdID.SelectedItem.ToString() + "','" + txtSupID.Text + "','" + txtSupname.Text + "','" + txtWeight.Text + "','" + txtQuantity.Text + "','" + Convert.ToDateTime(datePicker1.Value.Date).ToString("yyyy-MM-dd") + "','" + radioInput + "','" + reportID + "','" + txtTransIDmain.Text + "','" + txtPure.Text + "','" + txtCash.Text + "','"+Convert.ToDouble(txtLabourRs.Text)+"')";
                    //    //  update = "update Supplier set Balance_Gold=Balance_Gold+" + Convert.ToDouble(FineGold) + " where Supplier_ID='" + txtSupID.Text + "'";

                    //    cmd = new SqlCommand(insert, con);

                    //    cmd1 = new SqlCommand(insertInventory, con);
                    //    cmd2 = new SqlCommand(update, con);
                    //    con.Open();
                    //    cmd.ExecuteNonQuery();
                    //    cmd1.ExecuteNonQuery();
                    //    //cmd2.ExecuteNonQuery();
                    //    con.Close();
                    //    rb14.Checked = false;
                    //    rb18.Checked = false;
                    //    rb14.Checked = false;
                    //    txtQuantity.Text = "";
                    //    txtProductID.Text = "";
                    //    cmdID.Text = "";
                    //    txtWeight.Text = "";
                    //    txtLabourRs.Text = "";
                    //    txtTouchPouch.Text = "";
                    //    txtLabour.Text = "";

                    //    GetInventoyDetails();

                    //    if (productCount == Convert.ToInt32(txtNoProduct.Text))
                    //    {
                    //        double calGold = Convert.ToDouble(txtGoldPaid.Text) - pureGold;

                    //        if(calGold>0)// Supplier Paid 100 and get 70 then Amount is added
                    //            update = "update Supplier set Balance_Gold=Balance_Gold+'" + calGold + "', Balance_Cash=Balance_Cash+'" + cash + "' where Supplier_ID='" + txtSupID.Text + "'  ";

                    //        else//Supplier Paid 100 and get 140 then Amount is subtrtacted from its quota
                    //            update = "update Supplier set Balance_Gold=Balance_Gold-'" + calGold + "', Balance_Cash=Balance_Cash-'" + cash + "' where Supplier_ID='" + txtSupID.Text + "'  ";


                    //        con.Open();
                    //        cmd = new SqlCommand(update, con);
                    //        cmd.ExecuteNonQuery();
                    //        con.Close();
                    //        DialogResult dialogResult = MessageBox.Show("RECORD INSERTED SUCCESSFULLY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //        if (dialogResult == DialogResult.OK)
                    //        {
                    //            cash = 0;
                    //            calGold = 0;
                    //            productCount = 0;
                    //            pureGold = 0;
                    //        }




                    //        panelInventory.Hide();
                    //        panelPremainInventory.Show();

                    //        TextBlankPreMainInventory();
                    //        getCountInitial();
                    //    }
                    //}

                    #endregion


                    //txtPure.Text = "";
                    //txtCash.Text = "";
                    // TextBlankPreMainInventory();
                    ProductToolStrip.Enabled = true;
                    InventoryToolStrip.Enabled = true;
                    supplierToolStripMenuItem.Enabled = true;
                    MainWindowComponents();
                    rowsCount++;
                }
            }
        }

        void ReadGridValues()
        {
            //while ()
        }
         void btnSubmitnew_Click(object sender, EventArgs e)
        {
            if (dataGridInventoryComfirm.Rows.Count <= 0)
            {
                MessageBox.Show("YOU MUST HAVE SOME PRODUCT IN YOUR CART", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                #region DABDHBFASFB



                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();

                    insert = "insert into SupplierTransection(Transection_ID,Supplier_ID,Gold_Paid,Date,Supplier_Name,Gold_Receive,Cash_Receive) values ('" + ID + "','" + txtID.Text + "'," +
                    " '" + txtGoldPaid.Text + "','" + Convert.ToDateTime(datePicker1.Value.Date).ToString("yyyy-MM-dd") + "','" + cmbSuplierName.Text + "'," + 0f + "," + 0f + ")";

                    //string update = "update Supplier set Cash_Paid='" + txtCashPaid.Text + "', Gold_Paid=" + txtGoldPaid.Text + ", Cash_Receive='" + txtCashReceive.Text + "', Gold_Receive= " + txtGoldReceive.Text + ",Balance_Cash='" + txtBalanceCash.Text + "', Balance_Gold=" + txtBalanceGold.Text + " where Supplier_ID='" + txtID.Text + "'";
                    cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                }




                for (int row = 0; row < dataGridInventoryComfirm.Rows.Count; row++)
                {
                    getCountMain();
                    double lab = 0.0f, cash = 0.0f;

                    string productID, productName, supplierID, supplierName, weight, quantity, date, radioinput, transectionID, currentPuregold,labRS,touchPouch ;
                    productID = dataGridInventoryComfirm.Rows[row].Cells[0].Value.ToString();
                    productName = dataGridInventoryComfirm.Rows[row].Cells[1].Value.ToString();
                    supplierID = dataGridInventoryComfirm.Rows[row].Cells[2].Value.ToString();
                    supplierName = dataGridInventoryComfirm.Rows[row].Cells[3].Value.ToString();
                    weight = dataGridInventoryComfirm.Rows[row].Cells[4].Value.ToString();
                    quantity = dataGridInventoryComfirm.Rows[row].Cells[5].Value.ToString();
                    date = dataGridInventoryComfirm.Rows[row].Cells[6].Value.ToString();
                    radioinput = dataGridInventoryComfirm.Rows[row].Cells[7].Value.ToString();
                    transectionID = dataGridInventoryComfirm.Rows[row].Cells[8].Value.ToString();
                    currentPuregold = dataGridInventoryComfirm.Rows[row].Cells[9].Value.ToString();
                    lab = Convert.ToDouble(dataGridInventoryComfirm.Rows[row].Cells[10].Value.ToString());
                    labRS = dataGridInventoryComfirm.Rows[row].Cells[11].Value.ToString();
                    touchPouch = (dataGridInventoryComfirm.Rows[row].Cells[12].Value.ToString());
                    /*ash = Convert.ToDouble(dataGridInventoryComfirm.Rows[row].Cells[13].Value.ToString*/
                    using (SqlConnection con = new SqlConnection(conn))
                    {
                        insert = "insert into InventoryDetails(Product_ID,Product_Name,Supplier_ID,Supplier_Name,Item_Weight,Item_Quantity,Date,Purity,ReportID,Transection_ID,Pure_Gold,Cash,Labour,LabourRS,Touch_Pouch) values" +
                        " " +
                   "( '" + productID + "', '" + productName + "','" + supplierID + "','" + supplierName + "','" + weight + "','" + quantity + "','" + date + "','" + radioinput + "','" + reportID + "','" + transectionID + "','" + currentPuregold + "','" + cash + "','" + lab + "','"+labRS+"','"+touchPouch+"')";

                        con.Open();
                        cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                    }


                    using (SqlConnection con = new SqlConnection(conn))
                    {

                        //getCountMain();
                        count = 0;
                        select = "select Item_Name from Inventory where Item_Name='" + productName + "'";
                        cmd = new SqlCommand(select, con);

                        con.Open();
                        rdr = cmd.ExecuteReader();


                        while (rdr.Read())
                        {
                            count = count + 1;
                        }
                        con.Close();
                        if (count >= 1)
                        {
                            //MessageBox.Show("Product already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            insertInventory = "update inventory set Item_Weight=Item_Weight+" + weight + ", " +
                            "Total_Quantity=Total_Quantity+" + quantity + " where Product_ID='" + productID + "'";
                        }

                        else
                        {
                            insertInventory = "insert into inventory(Product_Id,Item_Name,Item_Weight,Total_Quantity,Purity)" +
                                " values('" + productID + "','" + productName + "','" + weight + "','" + quantity + "'" +
                                ",'" + rbNam + "')";
                        }
                        cmd1 = new SqlCommand(insertInventory, con);
                        //   cmd2 = new SqlCommand(update, con);
                        con.Open();

                        cmd1.ExecuteNonQuery();
                        con.Close();


                    }
                }




                using (SqlConnection con = new SqlConnection(conn))
                {
                    int temp;
                    if ((txtCash.Text) == string.Empty)
                    {
                        temp = 0;
                    }
                    else
                        temp = Convert.ToInt32(txtCash.Text);


                    con.Open();

                    insert = "update SupplierTransection set Gold_Receive= '" + pureGold + "', Cash_Receive= '" + temp + "' where Transection_ID ='" + ID + "'";

                    //string update = "update Supplier set Cash_Paid='" + txtCashPaid.Text + "', Gold_Paid=" + txtGoldPaid.Text + ", Cash_Receive='" + txtCashReceive.Text + "', Gold_Receive= " + txtGoldReceive.Text + ",Balance_Cash='" + txtBalanceCash.Text + "', Balance_Gold=" + txtBalanceGold.Text + " where Supplier_ID='" + txtID.Text + "'";
                    cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                }


                rb14.Checked = false;
                rb18.Checked = false;
                rb14.Checked = false;
                txtQuantity.Text = "";
                txtProductID.Text = "";
                cmdID.Text = "";
                txtWeight.Text = "";
                txtLabourRs.Text = "";
                txtTouchPouch.Text = "";
                txtLabour.Text = "";

                GetInventoyDetails();


                double calGold = gold_Paid - pureGold;

                if (calGold > 0)// Supplier Paid 100 and get 70 then Amount is added
                    update = "update Supplier set Balance_Gold=Cast((Balance_Gold+'" + calGold + "') AS dec(10,3)), Balance_Cash=Cast((Balance_Cash+'" + cash + "') AS dec(10,3)) where Supplier_ID='" + txtSupID.Text + "'  ";

                else//Supplier Paid 100 and get 140 then Amount is subtrtacted from its quota
                    update = "update Supplier set Balance_Gold=Cast((Balance_Gold-'" + calGold + "') AS dec(10,3)), Balance_Cash=Cast((Balance_Cash-'" + cash + "') AS dec(10,3)) where Supplier_ID='" + txtSupID.Text + "'  ";

                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();

                }
                DialogResult dialogResult = MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    cash = 0;
                    calGold = 0;
                    productCount = 0;
                    pureGold = 0;
                }

                panelInventory.Hide();
                panelPremainInventory.Show();

                TextBlankPreMainInventory();
                getCountInitial();



                #endregion
                rowsCount = 0;
            }
        }
        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = datePicker1.Text;
            //   datePicker1.ResetText();
        }

        private void txtDate_MouseClick(object sender, MouseEventArgs e)
        {
            datePicker1.Enabled = true;
        }



        private void cmdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Value is " + cmdID.SelectedItem);
   
            SetComboProductName(cmdID.SelectedItem.ToString());
            listboxProduct.Visible = false;
        }


        void GettingcomboValue()
        {
            cmdID.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Distinct Product_Name from Product";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmdID.Items.Add(reader.GetString(0));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED!");
            }

        }
        //PANEL 3 
        // prODUCT RELATED OPERATIONS

        public string DBID = "";
        public static int ID_P = 0;
        string REGID = "";
        public static string Words = "SM/" + DateTime.Now.Year + "/";


        void CheckProduct()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                select = "select Product_Name from Product where Product_Name='" + txtProductName.Text + "'";
                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    count = count + 1;
                }
                if (count <= 1)
                {
                    MessageBox.Show("PRODUCT NAME ALREADY EXIST.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TextBoxProduct();
                }
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conn);
            if (txtProductName.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER PRODUCT NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else

                using (SqlConnection con = new SqlConnection(conn))
                {
                    count = 0;
                    string value = ID_P.ToString("00000");
                    REGID = Words + value;
                    con.Open();
                    select = "select Product_Name from Product where Product_Name='" + txtProductName.Text + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                    if (count >= 1)
                    {
                        MessageBox.Show("PRODUCT ALREADY EXIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        TextBoxProduct();
                    }

                    else
                    {
                        ID_P++;
                        value = ID_P.ToString("00000");
                        REGID = Words + value;
                        using (SqlConnection connn = new SqlConnection(conn))
                        {
                            string insert = "insert into Product values('" + REGID + "','" + _tempPurity + "','" + txtProductName.Text + "','" + txtDesc.Text + "')";
                            //   string insert1 = "insert into Inventory values('" + REGID + "','" + txtProductName.Text + "')";
                            cmd = new SqlCommand(insert, connn);
                            //cmd1 = new SqlCommand(insert1, connn);
                            connn.Open();
                            cmd.ExecuteNonQuery();
                            //cmd1.ExecuteNonQuery();

                            GetdataProduct();
                            TextBoxProduct();
                        }
                    }



                }
            // StyleProductGrid();
        }


        private void btnDisplay_Product_Click(object sender, EventArgs e)
        {

            GetdataProduct();
            // StyleProductGrid();
        }

        private void NOinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void FloatNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Characters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }



        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Print " + e.ColumnIndex);
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {

                dataGridProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                UpdateID = (dataGridProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtProductName.Text = (dataGridProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtDesc.Text = (dataGridProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
                UpdatePurity(dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                ButtonDisableProduct();
                btnUpdateProduct.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please CLICK ON CONTENT NOT ON Column Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Console.WriteLine("Print " + e.ColumnIndex + "      " + e.RowIndex);
            }


        }
        private void UpdatePurity(string purity)
        {
            if (purity.Contains("18"))
            {
                Krt18.Checked = true;
            }
            else if (purity.Contains("14"))
            {
                Krt14.Checked = true;
            }
            else if (purity.Contains("22"))
            {
                Krt22.Checked = true;
            }
        }
        void ButtonDisableProduct()
        {
            btnAddProduct.Enabled = false;
            //btnCancelProduct.Enabled = false;
            btnDisplayProduct.Enabled = false;
            btnUpdateProduct.Enabled = false;
        }


        void ButtonDisableSupplier()
        {
            btnAdd.Enabled = false;
            //btnCancel.Enabled = false;
            btnDisplay.Enabled = false;
            btnuupdate.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            this.Hide();
            ln.ShowDialog();
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            TextBoxProduct();
            btnUpdateProduct.Enabled = false;
            btnAddProduct.Enabled = true;
            btnDisplayProduct.Enabled = true;

        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER PRODUCT NAME.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                using (con = new SqlConnection(conn))
                {
                    con.Open();
                    select = "select Product_Name from Product where Product_Name='" + txtProductName.Text + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                }
            if (count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("PRODUCT NAME ALREADY EXIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TextBoxProduct();
                count = 0;
                if (dialogResult == DialogResult.OK)
                {

                    btnAddProduct.Enabled = true;
                    btnDisplayProduct.Enabled = true;
                    //btnCancelProduct.Enabled = true;
                    btnUpdateProduct.Enabled = false;

                }
            }
            else
            {
                using (con = new SqlConnection(conn))
                {
                    string update = "update Product set Product_Name='" + txtProductName.Text + "',Description='" + txtDesc.Text + "' where Product_ID='" + UpdateID + "'";
                    cmd = new SqlCommand(update, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    ButtonDisableProduct();
                    btnUpdateProduct.Enabled = false;
                    ResetTextBoxesSupplier();
                    btnAddProduct.Enabled = true;
                    // btnCancelProduct.Enabled = true;
                    btnDisplayProduct.Enabled = true;
                    GetdataProduct();

                }
                using (con = new SqlConnection(conn))
                {
                    string update = "update Purchase set Product_Name='" + txtProductName.Text + "' where Product_ID='" + UpdateID + "'";
                    cmd = new SqlCommand(update, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                using (con = new SqlConnection(conn))
                {
                    string update = "update Inventory set Item_Name='" + txtProductName.Text + "' where Product_Id='" + UpdateID + "'";
                    cmd = new SqlCommand(update, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                using (con = new SqlConnection(conn))
                {
                    string update = "update InventoryDetails set Product_Name='" + txtProductName.Text + "' where Product_ID='" + UpdateID + "'";
                    cmd = new SqlCommand(update, con);



                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                TextBoxProduct();


            }


        }
        void TextBoxProduct()
        {
            txtDesc.Text = "";
            txtProductName.Text = "";
        }
        void ProductRefresh()
        {
            TextBoxProduct();
            dataGridProduct.DataSource = "";
            btnAddProduct.Enabled = true;
            btnDisplay.Enabled = true;
            btnUpdateProduct.Enabled = false;

        }
        void SupplierRefresh()
        {
            SupplierRefreshTextBox();
            dataGridSupplier.DataSource = "";
            btnAdd.Enabled = true;
            btnuupdate.Enabled = false;
            btnDisplay.Enabled = true;
        }
        void getCountProduct()
        {
            con = new SqlConnection(conn);
            select = "SELECT TOP 1 Product_ID FROM Product ORDER BY Product_ID DESC";
            con.Open();

            cmd = new SqlCommand(select, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                DBID = (rdr[0]).ToString();
            }
            con.Close();
            if (DBID != string.Empty)
            {
                string temp = DBID.Substring(8, 5);
                ID_P = Convert.ToInt32(temp);
            }

        }
        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridInventoryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {

            }
            else
            {
                MessageBox.Show("Please CLICK ON CONTENT NOT on Column Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Console.WriteLine("Print " + e.ColumnIndex + "      " + e.RowIndex);
            }

        }



        private void TextChanged(object sender, EventArgs e)
        {
            rb22.Checked = false;
            rb18.Checked = false;
            rb14.Checked = false;

        }

        void StyleProductGrid()
        {
            dataGridProduct.ColumnHeadersDefaultCellStyle.Font =
     new Font("Microsoft Sans Serif", 11f, FontStyle.Bold);
            dataGridProduct.Columns["Product_Name"].Width = 130;
            dataGridProduct.Columns["Product_ID"].Width = 150;
            dataGridProduct.Columns["Description"].Width = 160;

            DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);

        }
        private void dgGridProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                boldStyle.ForeColor = Color.Red;
                dataGridProduct.Rows[e.RowIndex].DefaultCellStyle = boldStyle;
            }
            else
            {
                return;
            }
        }

        private void dgGridProduct_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            dataGridProduct.Rows[e.RowIndex].DefaultCellStyle = norStyle;


        }
        void StyleSupplierGrid()
        {
            dataGridSupplier.ColumnHeadersDefaultCellStyle.Font =
     new Font("Microsoft Sans Serif", 11f, FontStyle.Bold);
            dataGridSupplier.Columns["Supplier_ID"].Width = 110;
            dataGridSupplier.Columns["Email"].Width = 150;
            dataGridSupplier.Columns["Balance_Cash"].Width = 120;
            dataGridSupplier.Columns["Contact"].Width = 110;
            dataGridSupplier.Columns["Name"].Width = 110;
            dataGridSupplier.Columns["Balance_Gold"].Width = 120;

            DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);

        }


        private void dgGridSupplier_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                boldStyle.ForeColor = Color.Red;
                dataGridSupplier.Rows[e.RowIndex].DefaultCellStyle = boldStyle;
            }
            else
            {
                return;
            }
        }

        private void dgGridSupplier_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            dataGridSupplier.Rows[e.RowIndex].DefaultCellStyle = norStyle;


        }


        void StyleInventoryGrid()
        {
            dataGridInventoryComfirm.ColumnHeadersDefaultCellStyle.Font =
     new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
            dataGridInventoryComfirm.Columns["Product_Name"].Width = 130;
            dataGridInventoryComfirm.Columns["Product_ID"].Width = 140;
            dataGridInventoryComfirm.Columns["Supplier_ID"].Width = 120;
            dataGridInventoryComfirm.Columns["Supplier_Name"].Width = 130;
            dataGridInventoryComfirm.Columns["Item_Weight"].Width = 130;
            dataGridInventoryComfirm.Columns["Item_Quantity"].Width = 130;
            dataGridInventoryComfirm.Columns["Transection_ID"].Width = 130;

            DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
          

            boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);


        }
        private void dgGriInventory_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                boldStyle.ForeColor = Color.Red;
                dataGridInventoryComfirm.Rows[e.RowIndex].DefaultCellStyle = boldStyle;
            }
            else
            {
               
                return;
            }
        }

        private void dgGridInventory_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            dataGridInventoryComfirm.Rows[e.RowIndex].DefaultCellStyle = norStyle;


        }


        //Supplier@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#$$$$$$$$$$$$$$$$$#
        private void RadioButon_Click(object sender, EventArgs e)
        {


            if (txtLabour.Text == string.Empty)
            {
                MessageBox.Show("PLEASE PROVIDE LABOUR COST.", "Error", MessageBoxButtons.OK, MessageBoxIcon. Information);
                rb14.Checked = false;
                rb22.Checked = false;
                rb18.Checked = false;

            }
            else
            {
                float.TryParse(txtWeight.Text, out Gold_R);

                float.TryParse(txtLabour.Text, out Lab);
                float.TryParse(txtTouchPouch.Text, out touchPouch);
                total = Gold_R + touchPouch;


                txtLabourRs.Text = String.Format("{0:#,##0.000;($#,##0.000);Zero}", ((Gold_R * (Convert.ToDouble(txtLabour.Text) / 99.5)) * currentValue));


                if (rb22.Checked == true)
                {
                    rbNam = "22 Krt";
                    //float.TryParse(txtWeight.Text, out Gold_R);
                    //float.TryParse(txtLabour.Text, out Lab);
                    G_Receive = total * (92.7 + Lab) / 99.5;
                }
                else if (rb18.Checked == true)
                {
                    rbNam = "18 Krt";
                    //float.TryParse(txtWeight.Text, out Gold_R);
                    //float.TryParse(txtLabour.Text, out Lab);
                    G_Receive = total * (75.25 + Lab) / 99.5;
                }
                else if (rb14.Checked == true)
                {
                    rbNam = "14 Krt";
                    //float.TryParse(txtWeight.Text, out Gold_R);
                    //float.TryParse(txtLabour.Text, out Lab);
                    G_Receive = total * (50 + Lab) / 99.5;

                }
                txtPure.Text = String.Format("{0:#,##0.000;($#,##0.000);Zero}", G_Receive);
            }
            
            //string a=String.Format("{0:$#,##0.00;($#,##0.00);Zero}", (total * Convert.ToDouble(txtLabour.Text) / 100));


        }
        void ResetTextBoxesSupplier()
        {
            txtLoaction.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPure_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }



        private void lblDate_Click(object sender, EventArgs e)
        {

        }
        private void panelSupplier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPremainInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SummeryToolStrip_Click(object sender, EventArgs e)
        {
            Summery summ = new Summery();
            summ.ShowDialog();
        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SuplierEnableTextBox();
            ResetTextBoxesSupplier();
            btnDisplay.Enabled = true;
            btnAdd.Enabled = true;
            btnuupdate.Enabled = false;
        }

        private void cashOutToolStrip_Click(object sender, EventArgs e)
        {
            Cashout cashout = new Cashout();
            cashout.ShowDialog();
        }

        private void txtLabour_Leave(object sender, EventArgs e)
        {
            float.TryParse(txtWeight.Text, out Gold_R);
            float.TryParse(txtLabour.Text, out Lab);
            float.TryParse(txtTouchPouch.Text, out touchPouch);
            total = Gold_R + touchPouch;

        }

        private void btnCancelInventory_Click(object sender, EventArgs e)
        {
            //DeleteLastTransection();
            panelInventory.Hide();
            panelPremainInventory.Show();
            TextBlankPreMainInventory();
            getCountInitial();
        }


        void GetdataProduct()
        {

            DataTable dt = new DataTable();
            select = "select * from Product";

            SqlConnection con = new SqlConnection(conn);
            cmd = new SqlCommand(select, con);
            con.Open();
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            dataGridProduct.DataSource = dt;


            con.Close();

            //DataTable dr_art_line_2 = (DataTable)rdr["Product"];
            //for (int i = 0; i < dr_art_line_2.Rows.Count; i++)
            //{
            //    int temp = Convert.ToInt32(dr_art_line_2.Rows[i]["Product_ID"]);
            //}

            StyleProductGrid();

        }

        string SetComboProductName(string name)
        {
            using (con = new SqlConnection(conn))
            {
                try
                {

                    con.Open();
                    string query = "select Product_ID from Product where Product_Name='" + name + "'";
                    cmd = new SqlCommand(query, con);

                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        txtProductID.Text = (rdr.GetString(0));

                    }

                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!","CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            return name;
        }

        //$$$$$$$$$$$$$$$$$$$$$$$$$$$ PAnel 4 #############################

        void GetSupplierNameSearch()
        {
            try
            {
                i = 0;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Name from Supplier";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    collection[i] = (reader.GetString(0));
                    i++;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        void GetProductNameSearch()
        {
            try
            {
                i = 0;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Product_Name from Product";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    P_collection[i] = (reader.GetString(0));
                    i++;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void GetProductName()// panel 4
        {
            cmdID.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Product_Name from Product";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmdID.Items.Add(reader.GetString(0));

                }
                co_p = cmdID.Items.Count;
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmdID_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cmdID.Text.ToLower();
            listboxProduct.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in P_collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listboxProduct.Items.Clear(); // remember to Clear before Add
            listboxProduct.Items.AddRange(result);
            listboxProduct.Visible = true; // show the listbox ag
        }
        private void Purity_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Krt14.Checked == true)
            {
                _tempPurity = "14 KRT";
            }
            else if (Krt18.Checked == true)
            {
                _tempPurity = "18 KRT";
            }
            else if (Krt22.Checked == true)
            {
                _tempPurity = "KRT 22";
            }
        }
        //private void btnSubmitCheckout_Click(object sender, EventArgs e)
        //{
        //    if (txtGoldPaidchk.Text == string.Empty || txtgoldrecvchk.Text == string.Empty)
        //    {
        //        MessageBox.Show("FIELDS CANNOT BE EMPTY.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    else
        //    {

        //        #region DABDHBFASFB



        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            con.Open();

        //            insert = "insert into SupplierTransection(Transection_ID,Supplier_ID,Gold_Paid,Date,Supplier_Name,Gold_Receive,Cash_Receive) values ('" + ID + "','" + txtID.Text + "'," +
        //            " '" + txtGoldPaid.Text + "','" + Convert.ToDateTime(datePicker1.Value.Date).ToString("yyyy-MM-dd") + "','" + cmbSuplierName.Text + "'," + 0f + "," + 0f + ")";

        //            //string update = "update Supplier set Cash_Paid='" + txtCashPaid.Text + "', Gold_Paid=" + txtGoldPaid.Text + ", Cash_Receive='" + txtCashReceive.Text + "', Gold_Receive= " + txtGoldReceive.Text + ",Balance_Cash='" + txtBalanceCash.Text + "', Balance_Gold=" + txtBalanceGold.Text + " where Supplier_ID='" + txtID.Text + "'";
        //            cmd = new SqlCommand(insert, con);
        //            cmd.ExecuteNonQuery();
        //        }




        //        for (int row = 0; row < dataGridInventoryComfirm.Rows.Count; row++)
        //        {
        //            getCountMain();
        //            double lab = 0.0f, cash = 0.0f;

        //            string productID, productName, supplierID, supplierName, weight, quantity, date, radioinput, transectionID, currentPuregold, labRS, touchPouch;
        //            productID = dataGridInventoryComfirm.Rows[row].Cells[0].Value.ToString();
        //            productName = dataGridInventoryComfirm.Rows[row].Cells[1].Value.ToString();
        //            supplierID = dataGridInventoryComfirm.Rows[row].Cells[2].Value.ToString();
        //            supplierName = dataGridInventoryComfirm.Rows[row].Cells[3].Value.ToString();
        //            weight = dataGridInventoryComfirm.Rows[row].Cells[4].Value.ToString();
        //            quantity = dataGridInventoryComfirm.Rows[row].Cells[5].Value.ToString();
        //            date = dataGridInventoryComfirm.Rows[row].Cells[6].Value.ToString();
        //            radioinput = dataGridInventoryComfirm.Rows[row].Cells[7].Value.ToString();
        //            transectionID = dataGridInventoryComfirm.Rows[row].Cells[8].Value.ToString();
        //            currentPuregold = dataGridInventoryComfirm.Rows[row].Cells[9].Value.ToString();
        //            lab = Convert.ToDouble(dataGridInventoryComfirm.Rows[row].Cells[10].Value.ToString());
        //            labRS = dataGridInventoryComfirm.Rows[row].Cells[11].Value.ToString();
        //            touchPouch = (dataGridInventoryComfirm.Rows[row].Cells[12].Value.ToString());
        //            /*ash = Convert.ToDouble(dataGridInventoryComfirm.Rows[row].Cells[13].Value.ToString*/
        //            using (SqlConnection con = new SqlConnection(conn))
        //            {
        //                insert = "insert into InventoryDetails(Product_ID,Product_Name,Supplier_ID,Supplier_Name,Item_Weight,Item_Quantity,Date,Purity,ReportID,Transection_ID,Pure_Gold,Cash,Labour,LabourRS,Touch_Pouch) values" +
        //                " " +
        //           "( '" + productID + "', '" + productName + "','" + supplierID + "','" + supplierName + "','" + weight + "','" + quantity + "','" + date + "','" + radioinput + "','" + reportID + "','" + transectionID + "','" + currentPuregold + "','" + cash + "','" + lab + "','" + labRS + "','" + touchPouch + "')";

        //                con.Open();
        //                cmd = new SqlCommand(insert, con);
        //                cmd.ExecuteNonQuery();
        //            }


        //            using (SqlConnection con = new SqlConnection(conn))
        //            {

        //                //getCountMain();
        //                count = 0;
        //                select = "select Item_Name from Inventory where Item_Name='" + productName + "'";
        //                cmd = new SqlCommand(select, con);

        //                con.Open();
        //                rdr = cmd.ExecuteReader();


        //                while (rdr.Read())
        //                {
        //                    count = count + 1;
        //                }
        //                con.Close();
        //                if (count >= 1)
        //                {
        //                    //MessageBox.Show("Product already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                    insertInventory = "update inventory set Item_Weight=Item_Weight+" + weight + ", " +
        //                    "Total_Quantity=Total_Quantity+" + quantity + " where Product_ID='" + productID + "'";
        //                }

        //                else
        //                {
        //                    insertInventory = "insert into inventory(Product_Id,Item_Name,Item_Weight,Total_Quantity,Purity)" +
        //                        " values('" + productID + "','" + productName + "','" + weight + "','" + quantity + "'" +
        //                        ",'" + rbNam + "')";
        //                }
        //                cmd1 = new SqlCommand(insertInventory, con);
        //                //   cmd2 = new SqlCommand(update, con);
        //                con.Open();

        //                cmd1.ExecuteNonQuery();
        //                con.Close();


        //            }
        //        }




        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            con.Open();

        //            insert = "update SupplierTransection set Gold_Receive= '" + pureGold + "', Cash_Receive= '" + cash + "' where Transection_ID ='" + ID + "'";

        //            //string update = "update Supplier set Cash_Paid='" + txtCashPaid.Text + "', Gold_Paid=" + txtGoldPaid.Text + ", Cash_Receive='" + txtCashReceive.Text + "', Gold_Receive= " + txtGoldReceive.Text + ",Balance_Cash='" + txtBalanceCash.Text + "', Balance_Gold=" + txtBalanceGold.Text + " where Supplier_ID='" + txtID.Text + "'";
        //            cmd = new SqlCommand(insert, con);
        //            cmd.ExecuteNonQuery();
        //        }


        //        rb14.Checked = false;
        //        rb18.Checked = false;
        //        rb14.Checked = false;
        //        txtQuantity.Text = "";
        //        txtProductID.Text = "";
        //        cmdID.Text = "";
        //        txtWeight.Text = "";
        //        txtLabourRs.Text = "";
        //        txtTouchPouch.Text = "";
        //        txtLabour.Text = "";

        //        GetInventoyDetails();


        //        double calGold = gold_Paid - pureGold;

        //        if (calGold > 0)// Supplier Paid 100 and get 70 then Amount is added
        //            update = "update Supplier set Balance_Gold=Cast((Balance_Gold+'" + calGold + "') AS dec(10,3)), Balance_Cash=Cast((Balance_Cash+'" + cash + "') AS dec(10,3)) where Supplier_ID='" + txtSupID.Text + "'  ";

        //        else//Supplier Paid 100 and get 140 then Amount is subtrtacted from its quota
        //            update = "update Supplier set Balance_Gold=Cast((Balance_Gold-'" + calGold + "') AS dec(10,3)), Balance_Cash=Cast((Balance_Cash-'" + cash + "') AS dec(10,3)) where Supplier_ID='" + txtSupID.Text + "'  ";

        //        using (SqlConnection con = new SqlConnection(conn))
        //        {
        //            con.Open();
        //            cmd = new SqlCommand(update, con);
        //            cmd.ExecuteNonQuery();

        //        }
        //        DialogResult dialogResult = MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //        if (dialogResult == DialogResult.OK)
        //        {
        //            cash = 0;
        //            calGold = 0;
        //            productCount = 0;
        //            pureGold = 0;
        //        }

        //        panelInventory.Hide();
        //        panelPremainInventory.Show();

        //        TextBlankPreMainInventory();
        //        getCountInitial();



        //        #endregion
        //        rowsCount = 0;
        //    }





        //}

        private void listboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdID.SelectedItem= listboxProduct.SelectedItem;
            listboxProduct.Visible = false;
            SetComboProductName(cmdID.SelectedItem.ToString());
        }

        private void statementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierStatement supplierStatement = new SupplierStatement();
            supplierStatement.Show();
        }

        private void cmbSuplierName_TextChanged(object sender, EventArgs e)
        {
            // get the keyword to search
            string textToSearch = cmbSuplierName.Text.ToLower();
            listBox1.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listBox1.Items.Clear(); // remember to Clear before Add
            listBox1.Items.AddRange(result);
            listBox1.Visible = true; // show the listbox again
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbSuplierName.SelectedItem = listBox1.SelectedItem; listBox1.Visible = false;
            SetComboName(cmbSuplierName.SelectedItem.ToString());

        }

       

        private void cmbSuplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            SetComboName(cmbSuplierName.SelectedItem.ToString());
        }

        string SetComboName(string name)
        {
            using (con = new SqlConnection(conn))
            {
                try
                {

                    con.Open();
                    string query = "select Supplier_ID from Supplier where Name='" + name + "'";
                    cmd = new SqlCommand(query, con);

                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        txtID.Text = (rdr.GetString(0));

                    }

                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            return name;
        }

        void GetSupplierName()// panel 4
        {
            cmbSuplierName.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Name from Supplier";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbSuplierName.Items.Add(reader.GetString(0));

                }
                co = cmbSuplierName.Items.Count;
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void getCountInitial()
        {
            using (con = new SqlConnection(conn))
            {
                string temp = "";
                select = "SELECT TOP 1 Transection_ID FROM SupplierTransection ORDER BY Transection_ID DESC";
                con.Open();

                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();
                //rdr.IsDBNull
                while (rdr.Read())
                {
                    temp = (rdr[0]).ToString();
                }
                if (temp != string.Empty)
                {
                    string stringID = temp;

                    ID = Convert.ToInt32(stringID);
                    ID++;

                }
                else
                    ID = 1;
                txtTransIDpremain.Text = ID.ToString();

            }

        }
        void TextBlankPreMainInventory()
        {
            txtID.Text = "";
            txtTransIDpremain.Text = "";
            txtGoldPaid.Text = "";
            cmbSuplierName.SelectedItem = "";
            txtDatePremain.Text = "";
        }
        private void datePickPremain_ValueChanged(object sender, EventArgs e)
        {

            txtDatePremain.Text = datePickPremain.Text;
        }
        private void btnSubmitInitial_Click(object sender, EventArgs e)
        {
            GetProductName();
            P_collection = new string[co_p];
            GetProductNameSearch();
            listboxProduct.Visible = false;
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("KINDLY PLEASE SELECT SUPPLIER", "Attention", MessageBoxButtons.OK, MessageBoxIcon. Information);
            }
            else if (txtGoldPaid.Text == string.Empty)
            {
                MessageBox.Show("KINDLY ENTER GOLD PAID BY SUPPLIER ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDatePremain.Text == string.Empty)
            {
                MessageBox.Show("PLEASE SELECT DATE ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                count = 0;
                using (con = new SqlConnection(conn))
                {
                    con.Open();
                    select = "select Name from Supplier where " +
                        "Name='" + cmbSuplierName.Text + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("YOU MIGHT HAVE ENTERED WRONG SUPPLIER NAME.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    TextBlankPreMainInventory();
                    cmbSuplierName.Text = "";
                    getCountInitial();
                }


                else
                {

                    using (con = new SqlConnection(conn))
                    {
                        gold_Paid = Convert.ToDouble(txtGoldPaid.Text);
                        id_Supplier = txtID.Text;
                        nameSupplier = cmbSuplierName.Text;
                        date = Convert.ToDateTime(datePicker1.Value.Date).ToString("yyyy-MM-dd");
                        _completeTrans = true;
                

                        DialogResult result = MessageBox.Show("RECORD SAVED SUCCESSFULLY", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {

                            txtSupname.Text = cmbSuplierName.Text;
                            txtSupID.Text = txtID.Text;
                            txtTransIDmain.Text = (txtTransIDpremain.Text);
                            panelInventory.Show();
                            supplierToolStripMenuItem.Enabled = false;
                            InventoryToolStrip.Enabled = false;
                            ProductToolStrip.Enabled = false;
                            panelPremainInventory.Hide();




                        }
                        // groupBox1.Hide();

                    }
                }

            }

            using (con = new SqlConnection(conn))
            {
                select = "select Gold_Value from Gold_Rate where Date='" + Convert.ToDateTime(datePickPremain.Value.Date).ToString("yyyy-MM-dd") + "'";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    currentValue = rdr.GetDouble(0);
                }
            }
            if (currentValue == 0)
            {
                GoldLive_Popup goldLive_Popup = new GoldLive_Popup();
                goldLive_Popup.Show();
            }
            if (dataGridInventoryComfirm.Rows.Count != 0)
            {
                dataGridInventoryComfirm.Rows.Clear();
               
            }
        }  
    }
}
