using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Projectt
{
    public partial class ParentClient : Form
    {
        string[] collection, P_collection;
        int co, co_P;
        bool found;

        public static string nameClient = "";
        double FinegoldTotal = 0.0f;
        float Gold_R = 0f;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlConnection con;
        double G_Receive, _totalGoldIterations, _totalFineGoldIterations, _masterGold, _masterFinal, _CombineGoldCash;

        double labour;
        float Lab;
        int cash = 0;
        string UpdateID = "";//This isd is used for updateing the database

        int Numb_count = 0;
        public static int ID = 0;
        double _tempCash = 0, perGram = 0, _equiGold = 0;


        public static string Word = "CLIENT-";
        public string DBID = "";
        string REGID = "";
        public static int CID = 0;
        double P_Weight;
        int P_Quantity;


        string name, insert, select, update;
        //
        //Second Form Contents

        public static string ClientId = "";
        string ProductId = "";



        //Checkout Content
        double currentValue = 0.0f, _Cash = 0.0f, _Gold = 0.0f;


        public ParentClient()
        {
            InitializeComponent();


            gridRecord.Columns.Add("Client_ID", "Client_ID");
            gridRecord.Columns.Add("Client_Name", "Client_Name");
            gridRecord.Columns.Add("Product_ID", "Product_ID");
            gridRecord.Columns.Add("Product_Name", "Product_Name");
            gridRecord.Columns.Add("Sold_Quantity", "Sold_Quantity");
            gridRecord.Columns.Add("Sold_Weight", "Sold_Weight");
            gridRecord.Columns.Add("Cash_Amount", "Cash_Amount");
            gridRecord.Columns.Add("Pure_Gold", "Pure_Gold");
            gridRecord.Columns.Add("Purchase_Date", "Purchase_Date");
            gridRecord.Columns.Add("Client_Transection", "Client_Transection");
            gridRecord.Columns.Add("Labour", "Labour");
            gridRecord.Columns.Add("Labour[RS]", "LabourRS");
        }



        void ButtonsDisable()
        {
            btnClientAdd.Enabled = false;
            btnDisplay.Enabled = false;
            btnUpdate.Enabled = false;
        }
        void ButtonsEnable()
        {
            btnClientAdd.Enabled = true;
            btnDisplay.Enabled = true;
            btnUpdate.Enabled = false;
        }

        void TextboxClinetBlank()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtLocation.Text = "";
        }
        void GetClientDetails()
        {
            using (con = new SqlConnection(conn))
            {
                DataTable dt = new DataTable();
                string select = "SELECT * FROM Client ORDER BY Client_ID DESC ";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();

                dt.Load(rdr);
                gridClientInfo.DataSource = dt;
                GridStyle();
            }
        }



        void UPDATE()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER NAME", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER PHONE NUMBER.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                con = new SqlConnection(conn);
                int count = 0;
                con.Open();
                select = "select Customer_Name from Client where Customer_Name='" + txtName.Text + "'and Client_ID !='" + UpdateID + "'";
                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    count = count + 1;
                }
                con.Close();
                if (count >= 1)
                {
                    MessageBox.Show("CUSTOMER NAME ALREADY EXIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    count = 0;
                }
                else
                {
                    using (con = new SqlConnection(conn))
                    {
                        string update = "update Client set Customer_Name='" + txtName.Text + "',Phone=" + txtPhone.Text + ",Email='" + txtEmail.Text + "',Location='" + txtLocation.Text + "'where Client_ID='" + UpdateID + "'";
                        cmd = new SqlCommand(update, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        btnClientAdd.Enabled = true;
                        btnDisplay.Enabled = true;
                        btnUpdate.Enabled = false;


                    }
                    using (con = new SqlConnection(conn))
                    {
                        string update = "update Purchase set Client_Name='" + txtName.Text + "' where Client_ID='" + UpdateID + "'";
                        cmd = new SqlCommand(update, con);
                        con.Open();
                        cmd.ExecuteNonQuery();


                    }
                }
            }
            TextboxClinetBlank();
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        void Create()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER PHONE NUMBER.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    int count = 0;
                    con.Open();
                    select = "select Customer_Name from Client where Customer_Name='" + txtName.Text + "'";
                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                    con.Close();
                    if (count >= 1)
                    {
                        MessageBox.Show("CUSTOMER NAME ALREADY EXIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        count = 0;
                    }
                    else
                    {
                        // con = new SqlConnection(conn);
                        string value = CID.ToString("00000");
                        REGID = Word + value;
                        con.Open();

                        insert = "insert into Client(Client_ID,Customer_Name,Phone,Email,Location,Balance_Gold,Balance_Cash) values('" + REGID + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtLocation.Text + "','" + 0 + "','" + 0 + "' )  ";
                        cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetClientDetails();
                    }
                }
                TextboxClinetBlank();

            }

        }
        void getCount()
        {
            string temp;
            con = new SqlConnection(conn);
            select = "SELECT TOP 1 Client_ID FROM Client ORDER BY Client_ID DESC";
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
                string stringID = DBID;

                temp = DBID.Substring(7, 5);
                CID = Convert.ToInt32(temp);
                CID++;
            }
            else
                CID = 1;

        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            getCount();
            Create();
            ClientComboFill();

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GetClientDetails();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UPDATE();
            GetClientDetails();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ParentClient_Load(object sender, EventArgs e)
        {
            ClientComboFill();
            collection = new string[co];
            P_collection = new string[co_P];
            GetClientNameSearch();

            found = false;
            panelcheckout.Hide();
            getCount();
            panelClient.Show();

            panelPost.Hide();
            btnUpdate.Enabled = false;
            ProductComboFill();
        }
        void GridStyle()
        {
            gridClientInfo.ColumnHeadersDefaultCellStyle.Font =
      new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold);

            gridClientInfo.Columns["Customer_Name"].Width = 132;

            //gridClientInfo.Columns["Gold_Paid"].Width = 120;


        }
        private void btnAddCART_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbProductName.Items.Count; i++)
            {
                if (P_collection[i] == cmbProductName.Text)
                {
                    found = true;
                }
            }



            if (cmbClientNamePre1.SelectedItem == null)
            {
                MessageBox.Show("PLEASE SELECT CLIENT NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbProductName.SelectedItem == null)
            {
                MessageBox.Show("PLEASE SELECT PRODUCT.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER QUANTITY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtWeight.Text == string.Empty || txtLabour.Text == string.Empty || txtFinalGold.Text == string.Empty || txtDate.Text == string.Empty)
            {
                MessageBox.Show("PLEASE FILL ALL RECORDDS.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (found == true)
                {
                    using (con = new SqlConnection(conn))
                    {
                        select = "select Gold_Value from Gold_Rate where Date='" + Convert.ToDateTime(datePickerPost.Value.Date).ToString("yyyy-MM-dd") + "'";
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
                }
                labour = /*String.Format("{0:#,##0.000;($#,##0.000);Zero}",*/ (Gold_R * (Convert.ToDouble(txtLabour.Text) / 99.5)) * currentValue;
                labour = Math.Round(labour, 2);
                Math.Round(((Gold_R * (Convert.ToDouble(txtLabour.Text) / 99.5)) * currentValue), 2);
                FinegoldTotal = Convert.ToDouble(txtFinalGold.Text);

                _totalFineGoldIterations += FinegoldTotal;
                int n = gridRecord.Rows.Add();

                gridRecord.Rows[n].Cells[0].Value = txtIDPost.Text;
                gridRecord.Rows[n].Cells[1].Value = cmbClientNamePre1.SelectedItem.ToString(); /*cmdID.SelectedItem.ToString()*/;
                gridRecord.Rows[n].Cells[2].Value = ProductId;
                gridRecord.Rows[n].Cells[3].Value = cmbProductName.SelectedItem.ToString();
                gridRecord.Rows[n].Cells[4].Value = txtQuantity.Text;
                gridRecord.Rows[n].Cells[5].Value = txtWeight.Text;
                gridRecord.Rows[n].Cells[6].Value = "0";
                gridRecord.Rows[n].Cells[7].Value = txtFinalGold.Text;
                gridRecord.Rows[n].Cells[8].Value = txtDate.Text;
                gridRecord.Rows[n].Cells[9].Value = txtTransectionID.Text;
                gridRecord.Rows[n].Cells[10].Value = labour;
                gridRecord.Rows[n].Cells[11].Value = txtLabourRS.Text;

                _masterFinal += _masterGold;
                _totalGoldIterations += Convert.ToDouble(txtWeight.Text);
                txtWeight.Text = "";
                txtQuantity.Text = "";
                txtLabour.Text = "";
                txtLabourRS.Text = "";
                txtFinalGold.Text = "";
                //txtCashBalance.Text = "";
                //txtGoldBalalnce.Text = "";
                cmbProductName.Text = "";
                labour = 0.0f;
                rb14.Checked = false; rb18.Checked = false; rb22.Checked = false;
                cmbClientNamePre1.Enabled = false;
               
            }
        }

        string _Cid = "", _Cname = "", _Pid = "", _Pname = "", _Quantity = "", _Weight = "", _CashAmount = "", _Puregold = "", _date = "", _Tid = "", _lab = "", _labRS = "";


        void DataUpdate()
        {
            for (int n = 0; n < gridRecord.Rows.Count; n++)
            {
                _Cid = gridRecord.Rows[n].Cells[0].Value.ToString();
                _Cname = gridRecord.Rows[n].Cells[1].Value.ToString();
                _Pid = gridRecord.Rows[n].Cells[2].Value.ToString();
                _Pname = gridRecord.Rows[n].Cells[3].Value.ToString();
                _Quantity = gridRecord.Rows[n].Cells[4].Value.ToString();
                _Weight = gridRecord.Rows[n].Cells[5].Value.ToString();
                _CashAmount = gridRecord.Rows[n].Cells[6].Value.ToString();
                _Puregold = gridRecord.Rows[n].Cells[7].Value.ToString();
                _date = gridRecord.Rows[n].Cells[8].Value.ToString();
                _Tid = gridRecord.Rows[n].Cells[9].Value.ToString();
                _lab = gridRecord.Rows[n].Cells[10].Value.ToString();
                _labRS = gridRecord.Rows[n].Cells[11].Value.ToString();
                using (con = new SqlConnection(conn))
                {

                    con.Open();


                    // tempGold = tempGold + G_Receive;

                    insert = "insert into Purchase(Client_ID,Client_Name,Product_ID,Product_Name," +
                        "Sold_Quantity,Sold_Weight,Purchase_Date,Pure_Gold,Client_Transection,Labour,LabourRS" +
                        ") values ('" + _Cid + "','" + _Cname + "','" + _Pid + "','" + _Pname + "'," +
                        "" + _Quantity + "," + _Weight + ",'" + Convert.ToDateTime(_date).ToString("yyyy-MM-dd") + "','" + _Puregold + "','" + _Tid + "','" + _lab + "','" + _labRS + "')";
                    cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();



                    // GetRecordDetails();
                }
                using (con = new SqlConnection(conn))
                {
                    con.Open();
                    string update = "update inventory set Total_Quantity=Total_Quantity- " + _Quantity + ",Item_Weight=Item_Weight-"
                        + _Weight + " where Item_Name='" + _Pname + "'";
                    cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();
                }
            }

            // JamaBalanceSupplier();

            cash = 0;
            Numb_count = 0;
            //  txtcashRcvchk.Enabled = false;



            found = false;
            //    DialogResult result = MessageBox.Show("RECORD SAVED SUCCESSFULLY", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //   if (result == DialogResult.OK)
            {
                // TextBoxPanelPostBlank();
                txtTransectionID.Text = GetLastID();
            }


        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (gridRecord.RowCount <= 0)
            {
                MessageBox.Show("YOU MUST HAVE SOME PRODUCT IN YOUR CART!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTranIdcheck.Text = txtTransectionID.Text;
                txtCusIDPost.Text = txtIDPost.Text;
                txtCNPost.Text = cmbClientNamePre1.SelectedItem.ToString();
                // ClientComboFillPost();
                panelPost.Hide();
                panelcheckout.Show();
                //DataUpdate();
            }

            cmbClientNamePre1.Enabled = true;
        }
        void JamaBalanceSupplier()
        {
            using (con = new SqlConnection(conn))
            {
                con.Open();
                update = "update Client set Balance_Gold=Balance_Gold + " +(Convert.ToDouble(txtgoldrecvchk.Text)- _totalFineGoldIterations) + " where Client_ID ='" + _Cid + "'";
                cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        void UdharBalanceSupplier()
        {
            using (con = new SqlConnection(conn))
            {
                con.Open();
                update = "update Client set Balance_Gold=Balance_Gold - " + _CombineGoldCash + " where Client_ID ='" + _Cid + "'";
                cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        Decimal GetClientBalance(string _id)
        {
            Decimal _data = 0;
            using (con = new SqlConnection(conn))
            {
                select = "select Balance_Gold from Client where Client_ID='" + _id + "'";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    _data = rdr.GetDecimal(0);
                }
                con.Close();
                return _data;

            }

        }

        private void RadioButton_Click(object sender, EventArgs e)
        {

            if (rb22.Checked == true)
            {
                float.TryParse(txtWeight.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (92 + Lab) / 99.5;
                _masterGold = Gold_R * (92) / 99.5;
            }
            else if (rb18.Checked == true)
            {
                float.TryParse(txtWeight.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (75.60 + Lab) / 99.5;
                _masterGold = Gold_R * (75.60) / 99.5;
            }
            else if (rb14.Checked == true)
            {
                float.TryParse(txtWeight.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (59 + Lab) / 99.5;
                _masterGold = Gold_R * (59) / 99.5;

            }
            _masterGold = Math.Round(_masterGold, 2);
            double var = Math.Round(G_Receive, 2);
            txtFinalGold.Text = var.ToString();
        }


        #region No tchnical

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
        }

        private void FloatNumbersReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void FloatNumbersPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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
        #endregion

        // Second From For Buying Product
        //void GetRecordDetails()
        //{
        //    using (con = new SqlConnection(conn))
        //    {
        //        DataTable dt = new DataTable();
        //        string select = "select * from Purchase where Client_ID='" + lblCID.Text + "'" +
        //            " and Client_Transection='" + txtTransectionID.Text + "'";
        //        cmd = new SqlCommand(select, con);
        //        con.Open();
        //        rdr = cmd.ExecuteReader();
        //        dt.Load(rdr);
        //        gridRecord.DataSource = dt;
        //    }
        //}


        private void buyProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  panelPre.Show();
            //panelcheckout.Hide();
            //panelPost.Show();
            //TextBoxPanelPreBlank();
            //ClientComboFill();

            //panelClient.Hide();
            //refresh();     
            GetLastID();

            //listBoxClientPre.Visible = false;
            //ClientComboFill();
            //P_collection = new string[co_P];
            //GetClientNameSearch();

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCount();
            panelPost.Hide();
            panelcheckout.Hide();
            panelClient.Show();


            ButtonsEnable();
            gridClientInfo.DataSource = null;
            TextboxClinetBlank();
        }
        string SetProductName(string name)
        {
            select = "select Product_Id,Total_Quantity,Item_Weight from Inventory where Item_Name='" + cmbProductName.SelectedItem.ToString() + "'";
            using (con = new SqlConnection(conn))
            {
                con.Open();
                cmd = new SqlCommand(select, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ProductId = rdr.GetString(0);
                    P_Quantity = rdr.GetInt32(1);
                    P_Weight = rdr.GetDouble(2);
                }

            }
            return name;
        }
        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetProductName(cmbProductName.SelectedItem.ToString());
            listBoxProductInven.Visible = false;

        }
        void GetProductNameSearch()
        {
            try
            {
                int i = 0;
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
        void getCountInitial()
        {
            using (con = new SqlConnection(conn))
            {
                string temp = "";
                select = "SELECT TOP 1 Client_Transection FROM ClientTransectionHistory ORDER BY Client_Transection DESC";
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
                //   txtTransectionIDPre.Text = ID.ToString();

            }

        }
        private void cmbProductName_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cmbProductName.Text.ToLower();
            listBoxProductInven.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in P_collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listBoxProductInven.Items.Clear(); // remember to Clear before Add
            listBoxProductInven.Items.AddRange(result);
            listBoxProductInven.Visible = true; // show the
        }

        private void listBoxProductInven_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductName.SelectedItem = listBoxProductInven.SelectedItem;
            SetProductName(cmbProductName.SelectedItem.ToString());
            listBoxProductInven.Visible = false;
        }


        void ProductComboFill()
        {
            cmbProductName.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Product_ID,Product_Name from Product";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    //ProductId = reader.GetString(0);
                    cmbProductName.Items.Add(reader.GetString(1));
                }
                co_P = cmbProductName.Items.Count;
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }









        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReport rpt = new ClientReport();
            rpt.ShowDialog();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {

            }
            else
              if (P_Quantity < Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show("You have only Quantity. " +
                    "You have only " + P_Quantity + " Pieces Left", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Text = "";
            }

        }

        private void txtIght_Leave(object sender, EventArgs e)
        {
            if (txtWeight.Text == string.Empty)
            {

            }
            else
                 if (P_Weight < Convert.ToDouble(txtWeight.Text))
            {
                MessageBox.Show("You don't have Enough Weight. " +
                    "You have only " + P_Weight + " total weight Left", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Text = "";
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void gridClientInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {


                gridClientInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                UpdateID = (gridClientInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = (gridClientInfo.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtPhone.Text = (gridClientInfo.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtEmail.Text = (gridClientInfo.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtLocation.Text = (gridClientInfo.Rows[e.RowIndex].Cells[4].Value.ToString());
                btnUpdate.Enabled = true;
                btnClientAdd.Enabled = false;
                btnDisplay.Enabled = false;
            }
            else
            {
                MessageBox.Show("PLEASE CLICK ON DATA NOT ON HEADER!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Console.WriteLine("Print " + e.ColumnIndex + "      " + e.RowIndex);
            }






        }

        private void gridRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {

            }
            else
            {
                MessageBox.Show("PLEASE CLICK ON DATA NOT ON HEADER!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Console.WriteLine("Print " + e.ColumnIndex + "      " + e.RowIndex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            this.Hide();
            ln.ShowDialog();
        }

        private void rb22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLabour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (cmbClientNamePre1.SelectedItem == null)
            {
                MessageBox.Show("PLEASE SELECT CLIENT NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cmbProductName.SelectedItem == null)
            {
                MessageBox.Show("PLEASE SELECT PRODUCT.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbProductName.Text = "";
                txtQuantity.Text = "";
                txtWeight.Text = "";
            }

            rb22.Checked = false;
            rb18.Checked = false;
            rb14.Checked = false;



        }

        private void reportToolStrip_Click(object sender, EventArgs e)
        {
            ClientReport clientReport = new ClientReport();
            clientReport.ShowDialog();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void datePickerPost_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = datePickerPost.Text;
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxPanelCheckoutBlank();
            txtTranIdcheck.Text = GetLastID();


            //    ClientComboFillPost();
            panelClient.Hide();
            panelcheckout.Show();
            panelPost.Hide();
        }

        private void cmbClientPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtCusIDPost.Text = SetName(cmbClientPost.SelectedItem.ToString());
            //listClientPost.Visible = false;
        }

        private void cmbClientPost_TextChanged(object sender, EventArgs e)
        {
            //string textToSearch = cmbClientPost.Text.ToLower();
            //listClientPost.Visible = false; // hide the listbox, see below for why doing that
            //if (String.IsNullOrEmpty(textToSearch))
            //    return; // return with listbox hidden if the keyword is empty
            //            //search
            //string[] result = (from j in collection
            //                   where j.ToLower().Contains(textToSearch)
            //                   select j).ToArray();
            //if (result.Length == 0)
            //    return; // return with listbox hidden if nothing found

            //listClientPost.Items.Clear(); // remember to Clear before Add
            //listClientPost.Items.AddRange(result);
            //listClientPost.Visible = true; // show the
        }

        private void listClientPost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }








        //premain

        private void cmbClientNamePre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    SetName(cmbClientNamePre.SelectedItem.ToString());
            //    listBoxClientPre.Visible = false;
            txtIDPost.Text = SetName(cmbClientNamePre1.SelectedItem.ToString());
            listBoxClientPre1.Visible = false;
            GetCandG(cmbClientNamePre1.SelectedItem.ToString());

        }

        private void txtcashRcvchk_Leave(object sender, EventArgs e)
        {
            if (txtcashRcvchk.Text != string.Empty)
                _tempCash = Convert.ToDouble(txtcashRcvchk.Text);
            if (currentValue != 0)
            {
                perGram = currentValue / 10;
            }
            // if (_tempCash != 0)
            {
                _equiGold = _tempCash / perGram;
            }
            if (txtgoldrecvchk.Text != string.Empty)
                _CombineGoldCash = Convert.ToDouble(txtgoldrecvchk.Text) + _equiGold;
        }

        private void datePost_ValueChanged(object sender, EventArgs e)
        {
            txtDateCheck.Text = dateCheck.Text;
        }

        private void DT_Summery_Click(object sender, EventArgs e)
        {
            Summery sum = new Summery();
            sum.ShowDialog();
        }
        private void Margin_Summery_Click(object sender, EventArgs e)
        {
            MarginReport sum = new MarginReport();
            sum.ShowDialog();
        }

        void GetCandG(string _A)
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "select Balance_Gold,Balance_Cash from Client where Customer_Name='" + _A + "'";
            cmd = new SqlCommand(query, con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                txtGoldBalalnce.Text = Convert.ToString(rdr.GetDecimal(0));
                txtCashBalance.Text = Convert.ToString(rdr.GetDouble(1));

            }
            con.Close();
        }


        private void clientStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientStatement state = new ClientStatement();
            state.Show();
        }

        private void btnSubmitCheckout_Click(object sender, EventArgs e)
        {
            if (txtDateCheck.Text == string.Empty || txtgoldrecvchk.Text == string.Empty)
            {
                MessageBox.Show("FIELDS CANNOT BE EMPTY.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double _margin = Math.Round((_totalFineGoldIterations - _masterFinal), 2);
                //double tempCash = 0.0f, tempGold = 0.0f;
                //UdharBalanceSupplier(txtCusIDPost.Text);
                DataUpdate();
                JamaBalanceSupplier();
             //  UdharBalanceSupplier();
                using (SqlConnection con = new SqlConnection(conn))
                {

                    insert = "insert into ClientTransectionHistory(Client_Transection,Client_Id,Customer_Name,Date,Gold_Paid,Cash_Paid,Gold_Receive,Cash_Receive,PureGold,Jama,Udhar,Balance,Margin,CC) values ('" + _Tid + "'," +
                        "'" + _Cid + "','" + _Cname + "','" + Convert.ToDateTime(_date).ToString("yyyy-MM-dd") + "','"
                        + _totalFineGoldIterations + "','" + 0 + "','" + txtgoldrecvchk.Text + "','" + txtcashRcvchk.Text + "','" + _masterFinal + "','" + 0 + "','" + 0 + "','" + GetClientBalance(_Cid) + "','" + _margin + "','" + 0 + "')";
                    cmd = new SqlCommand(insert, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                using (con = new SqlConnection(conn))
                {
                    update = "update MasterTable set Gold=Gold+'" + _margin + "'";
                    cmd = new SqlCommand(update, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }

                //using (SqlConnection con = new SqlConnection(conn))
                //{
                //    select = "insert into ClientTransectionHistory(Client_Transection,Client_Id,Customer_Name,Date,Gold_Paid,Cash_Paid,Gold_Receive,Cash_Receive,PureGold,Jama,Udhar,Balance) values ('" + txtTranIdcheck.Text + 
                //        "','" + txtCusIDPost.Text + "','" + cmbClientPost.SelectedItem.ToString() + "','" + Convert.ToDateTime(txtDateCheck.Text).ToString("yyyy-MM-dd") + "'," +
                //                  "'" + 0+ "','" + 0 + "','" + txtgoldrecvchk.Text + "','" + txtcashRcvchk.Text + "','" + txtgoldrecvchk.Text + "','"+0+"','"+txtgoldrecvchk.Text+"','"+GetClientBalance(txtCusIDPost.Text)+"')";

                //    cmd = new SqlCommand(select, con);
                //    con.Open();
                //    rdr = cmd.ExecuteReader();
                //}
                _masterFinal = 0; _totalFineGoldIterations = 0; _masterGold = 0;
                DialogResult result = MessageBox.Show("RECORD SAVED SUCCESSFULLY", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    TextBoxPanelCheckoutBlank();
                    txtTranIdcheck.Text = GetLastID();
                }
                #region OLD CODE
                //double ab = 0.0f, ba = 0.0f;
                //if (txtCashPaidchk.Text == string.Empty)
                //{
                //    ab = 0.0f;
                //}
                //else
                //    ab = Math.Round(Convert.ToDouble(txtCashPaidchk.Text));
                //if (txtcashRcvchk.Text == string.Empty)
                //{
                //    ba = 0.0f;
                //}
                //else
                //    ba = Math.Round(Convert.ToDouble(txtcashRcvchk.Text));



                //if (txtcashRcvchk.Text == string.Empty && txtCashPaidchk.Text == string.Empty || txtcashRcvchk.Text == "0" && txtCashPaidchk.Text == "0")
                //{
                //    tempGold = (Convert.ToDouble(txtgoldrecvchk.Text) - Convert.ToDouble(txtDateCheck.Text));
                //    tempCash = 0;
                //}

                //else if (_Cash != 0 && ab != 0)
                //{
                //    _Cash = Math.Round(_Cash);
                //    tempCash = _Cash - (Convert.ToDouble(txtCashPaidchk.Text));
                //    if (tempCash == 0 && ab != 0)
                //    {
                //        tempGold = 0;
                //    }
                //    else
                //    {
                //        tempCash = _Cash - ab;

                //    }
                //}
                //else if (_Cash != 0 && ba != 0)
                //{
                //    _Cash = Math.Round(_Cash);
                //    _Cash = -(_Cash);
                //    tempCash = _Cash - (Convert.ToDouble(txtcashRcvchk.Text));
                //    if (tempCash == 0 && ba != 0)
                //    {
                //        tempGold = 0;
                //    }
                //    else
                //    {
                //        tempCash = _Cash - ba;
                //    }
                //}
                //using (SqlConnection con = new SqlConnection(conn))
                //{
                //    select = "update Client set Jama_Gold=Jama_Gold+ '" + tempGold + "' where Client_ID='" + txtCusIDPost.Text + "'";
                //    cmd = new SqlCommand(select, con);
                //    con.Open();
                //    rdr = cmd.ExecuteReader();
                //}
                //using (SqlConnection con = new SqlConnection(conn))
                //{
                //    select = "update Client set Jama_Cash=Jama_Cash+ '" + tempCash + "' where Client_ID='" + txtCusIDPost.Text + "'";
                //    cmd = new SqlCommand(select, con);
                //    con.Open();
                //    rdr = cmd.ExecuteReader();
                //}
                //MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtTranIdcheck.Text = "";
                //cmbClientPost.SelectedItem = "";
                //txtCusIDPost.Text = "";
                //txtgoldrecvchk.Text = "";
                //txtgoldrecvchk.Text = "";
                //txtcashRcvchk.Text = "";
                //txtCashPaidchk.Text = "";
                //panelcheckout.Hide();

                //getCountInitial();
                //G_Receive = 0; tempGold = 0;
                #endregion
            }

        }


        private void listBoxClientPre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClientNamePre1.Text = listBoxClientPre1.Text;
            //SetName(cmbClientNamePre.SelectedItem.ToString());
            listBoxClientPre1.Visible = false;
        }

        private void panelcheckout_Paint(object sender, PaintEventArgs e)
        {

        }
        void GetClientNameSearch()
        {
            try
            {
                int i = 0;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Customer_Name from Client";
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

        private void cmbClientNamePre_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cmbClientNamePre1.Text.ToLower();
            listBoxClientPre1.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listBoxClientPre1.Items.Clear(); // remember to Clear before Add
            listBoxClientPre1.Items.AddRange(result);
            listBoxClientPre1.Visible = true; // show the
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TextboxClinetBlank();
            btnUpdate.Enabled = false;
            btnClientAdd.Enabled = true;
            btnDisplay.Enabled = true;
        }

        private void cashoutToolStrip_Click(object sender, EventArgs e)
        {
            CashoutClint cashoutClint = new CashoutClint();
            //cashoutClint.GetSupplierNameSearch();
            //cashoutClint.GettingcomboValue();
            cashoutClint.ShowDialog();
        }

        private void txtCashPaidchk_TextChanged(object sender, EventArgs e)
        {

        }

        double _balGold = 0;
        private void txtgoldrecvchk_Leave(object sender, EventArgs e)
        {

            using (con = new SqlConnection(conn))
            {
                select = "select Gold_Value from Gold_Rate where Date='" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "'";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    currentValue = rdr.GetDouble(0);
                }
            }
            if (txtgoldrecvchk.Text != string.Empty)
            {
                _balGold = Convert.ToDouble(txtgoldrecvchk.Text) - _totalFineGoldIterations;
            }


        }

        string SetName(string name)
        {
            using (con = new SqlConnection(conn))
            {
                // select = "SELECT TOP 1 Client_Transection FROM ClientTransectionHistory where ='" + cmbClientNamePre.SelectedItem.ToString() + "'";

                select = "select Client_ID from Client where Customer_Name='" + name + "'";
                con.Open();

                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    name = (rdr[0]).ToString();
                }
            }


            return name;
        }
        public string GetLastID()
        {
            using (con = new SqlConnection(conn))
            {
                string temp = "";
                select = "SELECT TOP 1 Client_Transection FROM ClientTransectionHistory ORDER BY Client_Transection DESC";
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
                return ID.ToString();



            }

        }


        public void TextBoxPanelPostBlank()
        {
            txtDate.Text = "";
            //  txtClientName.Text = "";
            cmbProductName.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            txtLabour.Text = "";
            //  cmbClientNamePre1.Text = "";
            // txtIDPost.Text = "";
            txtFinalGold.Text = "";
            txtGoldBalalnce.Text = "";
            txtCashBalance.Text = "";
            listBoxClientPre1.Visible = false;
            listBoxProductInven.Visible = false;
            gridRecord.Rows.Clear();
            rb22.Checked = false;
            rb18.Checked = false;
            rb14.Checked = false;
            //GetTransectionID();
        }
        void TextBoxPanelCheckoutBlank()
        {
            txtCusIDPost.Text = "";
            txtcashRcvchk.Text = "";
            txtgoldrecvchk.Text = "";
            txtgoldrecvchk.Text = "";
            txtTranIdcheck.Text = "";
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxPanelPostBlank();
            txtTransectionID.Text = GetLastID();
            ClientComboFill();
            panelClient.Hide();
            panelcheckout.Hide();
            panelPost.Show();

            //txtClientName.Text = cmbClientNamePre.Text;
            //txtTransectionID.Text = txtTransectionIDPre.Text;
            //txtDate.Text = txtDatePre.Text;
            //lblCID.Text = txtIDPre.Text;
            found = false;



            ProductComboFill();
            P_collection = new string[co_P];
            GetProductNameSearch();
        }
        private void TextChanged(object sender, EventArgs e)
        {
            rb22.Checked = false;
            rb18.Checked = false;
            rb14.Checked = false;

        }

        void ClientComboFill()
        {
            cmbClientNamePre1.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Client_ID,Customer_Name from Client";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //  ClientId = reader.GetString(0);
                    cmbClientNamePre1.Items.Add(reader.GetString(1));
                }
                co = cmbClientNamePre1.Items.Count;
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("ERROR OCCURED DUE TO UNAVAILBILITY OF DATA!", "CHECK DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
