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
        double G_Receive,_totalGoldIterations,_totalFineGoldIterations;

        double labour;
        float Lab;
        int cash = 0;
        string UpdateID = "";//This isd is used for updateing the database

        int Numb_count = 0;
        public static int ID = 0;



        public static string Word = "Client/" + DateTime.Now.Year + "/";
        public string DBID = "";
        string REGID = "";
        public static int CID = 0;
        double P_Weight;
        int P_Quantity;


        string name, insert, select;
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

                        insert = "insert into Client(Client_ID,Customer_Name,Phone,Email,Location,Jama_Gold,Jama_Cash) values('" + REGID + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtLocation.Text + "','" + 0 + "','" + 0 + "' )  ";
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

                temp = stringID.Substring(12, 5);
                CID = Convert.ToInt32(temp);
                CID++;
            }
            else
                CID = 1;

        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            Create();
            ClientComboFill();
            getCount();
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
            panelPre.Hide();
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



            if (txtClientName.Text == null)
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
            else if (txtWeight.Text == string.Empty || txtLabour.Text == string.Empty || txtFinalGold.Text == string.Empty)
            {
                MessageBox.Show("PLEASE FILL ALL RECORDDS.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (found == true)
                {
                    using (con = new SqlConnection(conn))
                    {
                        select = "select Gold_Value from Gold_Rate where Date='" + Convert.ToDateTime(dateTimePicker2.Value.Date).ToString("yyyy-MM-dd") + "'";
                        cmd = new SqlCommand(select, con);
                        con.Open();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            currentValue = rdr.GetDouble(0);
                        }
                    }
                }
                labour = /*String.Format("{0:#,##0.000;($#,##0.000);Zero}",*/ (Gold_R * (Convert.ToDouble(txtLabour.Text) / 99.5)) * currentValue;
                labour = Math.Round(labour, 3);
                Math.Round(((Gold_R * (Convert.ToDouble(txtLabour.Text) / 99.5)) * currentValue), 3);
                FinegoldTotal = Convert.ToDouble(txtFinalGold.Text);

                _totalFineGoldIterations += FinegoldTotal;
                int n = gridRecord.Rows.Add();

                gridRecord.Rows[n].Cells[0].Value = lblCID.Text;
                gridRecord.Rows[n].Cells[1].Value = txtClientName.Text; /*cmdID.SelectedItem.ToString()*/;
                gridRecord.Rows[n].Cells[2].Value = ProductId;
                gridRecord.Rows[n].Cells[3].Value = cmbProductName.SelectedItem.ToString();
                gridRecord.Rows[n].Cells[4].Value = txtQuantity.Text;
                gridRecord.Rows[n].Cells[5].Value = txtWeight.Text;
                gridRecord.Rows[n].Cells[6].Value = "0";
                gridRecord.Rows[n].Cells[7].Value = txtFinalGold.Text;
                gridRecord.Rows[n].Cells[8].Value = txtDate.Text;
                gridRecord.Rows[n].Cells[9].Value = txtTransectionID.Text;
                gridRecord.Rows[n].Cells[10].Value = labour;
                _totalGoldIterations += Convert.ToDouble(txtWeight.Text);
                txtWeight.Text = "";
                txtQuantity.Text = "";
                txtLabour.Text = "";

                txtFinalGold.Text = "";
                //txtCashBalance.Text = "";
                //txtGoldBalalnce.Text = "";
                cmbProductName.Text = "";
                labour = 0.0f;
                rb14.Checked = false; rb18.Checked = false; rb22.Checked = false;
            }
        }

        string _Cid = "", _Cname = "", _Pid = "", _Pname = "", _Quantity = "", _Weight = "", _CashAmount = "", _Puregold = "", _date = "", _Tid = "", _lab = "";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (gridRecord.RowCount <= 0)
            {
                MessageBox.Show("YOU MUST HAVE SOME PRODUCT IN YOUR CART!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                {
                    panelcheckout.Show();
                 panelPost.Hide();   
                    RefreshMAin();
                    cash = 0;
                    Numb_count = 0;
                    txtcashRcvchk.Enabled = false;
                    txtCashPaidchk.Enabled = false;
                }
                found = false;
            }
    

        }
        void RefreshMAin()
        {
            txtTranIdcheck.Text = txtTransectionID.Text;
            txtNamechk.Text = txtClientName.Text;
            txtcusIdchk.Text = txtIDPre.Text;
            txtGoldPaidchk.Text = _totalGoldIterations.ToString();
           // gridRecord.DataSource = "";
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {

            if (rb22.Checked == true)
            {
                float.TryParse(txtWeight.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (92 + Lab) / 99.5;
            }
            else if (rb18.Checked == true)
            {
                float.TryParse(txtWeight.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (75.60 + Lab) / 99.5;
            }
            else if (rb14.Checked == true)
            {
                float.TryParse(txtWeight.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (59 + Lab) / 99.5;

            }
            double var=Math.Round(G_Receive, 3);
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
        void GetRecordDetails()
        {
            using (con = new SqlConnection(conn))
            {
                DataTable dt = new DataTable();
                string select = "select * from Purchase where Client_ID='" + lblCID.Text + "'" +
                    " and Client_Transection='" + txtTransectionID.Text + "'";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                gridRecord.DataSource = dt;
            }
        }



        public void TextBoxPanelPostBlank()
        {
            txtDate.Text = "";
            txtClientName.Text = "";
            cmbProductName.Text = "";
            txtQuantity.Text = "";
            txtWeight.Text = "";
            txtLabour.Text = "";

            txtFinalGold.Text = "";
            txtGoldBalalnce.Text = "";
            txtCashBalance.Text = "";

            rb22.Checked = false;
            rb18.Checked = false;
            rb14.Checked = false;
            //GetTransectionID();
        }
        void TextBoxPanelCheckoutBlank()
        {
            txtCashPaidchk.Text = "";
            txtcusIdchk.Text = "";
            txtcashRcvchk.Text = "";
            txtgoldrecvchk.Text = "";
            txtgoldrecvchk.Text = "";
            txtNamechk.Text = "";
            txtTranIdcheck.Text = "";
        }
        void TextBoxPanelPreBlank()
        {
            txtTransectionIDPre.Text = "";
            cmbClientNamePre.Text = "";
           
            txtIDPre.Text = "";
            txtDatePre.Text = "";
        }
        private void buyProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPre.Show();
            panelcheckout.Hide();
            panelPost.Hide();
            TextBoxPanelPreBlank();
            ClientComboFill();
          
            panelClient.Hide();
            //refresh();     
            GetLastID();

            listBoxClientPre.Visible = false;
            ClientComboFill();
            P_collection = new string[co_P];
            GetClientNameSearch();

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCount();
            panelClient.Show();
            panelPost.Hide();
            panelPre.Hide();
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
                txtTransectionIDPre.Text = ID.ToString();

            }

        }
        private void cmbProductName_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cmbProductName.Text.ToLower();
            listBoxProductInven.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in collection
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
            if (txtClientName.Text == null)
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








        //premain

        private void cmbClientNamePre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetName(cmbClientNamePre.SelectedItem.ToString());
            listBoxClientPre.Visible = false;

        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtDatePre.Text = dateTimePicker2.Text;
        }

        private void clientStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientStatement state = new ClientStatement();
            state.Show();
        }

        private void btnSubmitCheckout_Click(object sender, EventArgs e)
        {
            if (txtGoldPaidchk.Text == string.Empty || txtgoldrecvchk.Text == string.Empty)
            {
                MessageBox.Show("FIELDS CANNOT BE EMPTY.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                    using (con = new SqlConnection(conn))
                    {

                        con.Open();


                        // tempGold = tempGold + G_Receive;

                        insert = "insert into Purchase(Client_ID,Client_Name,Product_ID,Product_Name," +
                            "Sold_Quantity,Sold_Weight,Purchase_Date,Pure_Gold,Client_Transection,Labour) values ('" + _Cid + "','" + _Cname + "','" + _Pid + "','" + _Pname + "'," +
                            "" + _Quantity + "," + _Weight + ",'" + Convert.ToDateTime(_date).ToString("yyyy-MM-dd") + "','" + _Puregold + "','" + _Tid + "','" + _lab + "')";
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



                double tempCash = 0.0f, tempGold = 0.0f;
                using (SqlConnection con = new SqlConnection(conn))
                {
                    select = "insert into ClientTransectionHistory(Client_Transection,Client_ID,Customer_Name,Date,Gold_Paid,Cash_Paid,Gold_Receive,Cash_Receive,PureGold) values" +
                                  "('" + txtTransectionIDPre.Text + "','" + txtIDPre.Text + "','" + cmbClientNamePre.SelectedItem + "','" + Convert.ToDateTime(txtDatePre.Text).ToString("yyyy-MM-dd") + "'," +
                                  "'" + txtGoldPaidchk.Text + "','" + txtCashPaidchk.Text + "','" + txtgoldrecvchk.Text + "','" + txtcashRcvchk.Text + "','" + _totalFineGoldIterations + "')";

                    cmd = new SqlCommand(select, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                }
                double ab = 0.0f, ba = 0.0f;
                if (txtCashPaidchk.Text == string.Empty)
                {
                    ab = 0.0f;
                }
                else
                    ab = Math.Round(Convert.ToDouble(txtCashPaidchk.Text));
                if (txtcashRcvchk.Text == string.Empty)
                {
                    ba = 0.0f;
                }
                else
                    ba = Math.Round(Convert.ToDouble(txtcashRcvchk.Text));



                if (txtcashRcvchk.Text == string.Empty && txtCashPaidchk.Text == string.Empty || txtcashRcvchk.Text == "0" && txtCashPaidchk.Text == "0")
                {
                    tempGold = (Convert.ToDouble(txtgoldrecvchk.Text) - Convert.ToDouble(txtGoldPaidchk.Text));
                    tempCash = 0;
                }

                else if (_Cash != 0 && ab != 0)
                {
                    _Cash = Math.Round(_Cash);
                    tempCash = _Cash - (Convert.ToDouble(txtCashPaidchk.Text));
                    if (tempCash == 0 && ab != 0)
                    {
                        tempGold = 0;
                    }
                    else
                    {
                        tempCash = _Cash - ab;

                    }
                }
                else if (_Cash != 0 && ba != 0)
                {
                    _Cash = Math.Round(_Cash);
                    _Cash = -(_Cash);
                    tempCash = _Cash - (Convert.ToDouble(txtcashRcvchk.Text));
                    if (tempCash == 0 && ba != 0)
                    {
                        tempGold = 0;
                    }
                    else
                    {
                        tempCash = _Cash - ba;
                    }
                }
                using (SqlConnection con = new SqlConnection(conn))
                {
                    select = "update Client set Jama_Gold=Jama_Gold+ '" + tempGold + "' where Client_ID='" + txtcusIdchk.Text + "'";
                    cmd = new SqlCommand(select, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                }
                using (SqlConnection con = new SqlConnection(conn))
                {
                    select = "update Client set Jama_Cash=Jama_Cash+ '" + tempCash + "' where Client_ID='" + txtcusIdchk.Text + "'";
                    cmd = new SqlCommand(select, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                }
                MessageBox.Show("RECORD INSERTED SUCCESSFULLY.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTranIdcheck.Text = "";
                txtNamechk.Text = "";
                txtcusIdchk.Text = "";
                txtgoldrecvchk.Text = "";
                txtgoldrecvchk.Text = "";
                txtcashRcvchk.Text = "";
                txtCashPaidchk.Text = "";
                panelcheckout.Hide();
                panelPre.Show();
                cmbClientNamePre.Text = "";
             
                txtIDPre.Text = "";
                getCountInitial();
                G_Receive = 0; tempGold = 0;
            }

        }
        private void listBoxClientPre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClientNamePre.Text = listBoxClientPre.Text;
            //SetName(cmbClientNamePre.SelectedItem.ToString());
            listBoxClientPre.Visible = false;
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
            string textToSearch = cmbClientNamePre.Text.ToLower();
            listBoxClientPre.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listBoxClientPre.Items.Clear(); // remember to Clear before Add
            listBoxClientPre.Items.AddRange(result);
            listBoxClientPre.Visible = true; // show the
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


        private void txtgoldrecvchk_Leave(object sender, EventArgs e)
        {
            lblRate.Text = "";
            lblRateClient.Text = "";
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
            if (txtCashPaidchk.Text == "" || Convert.ToInt32(txtCashPaidchk.Text)==0 && txtcashRcvchk.Text == "" || Convert.ToInt32(txtcashRcvchk.Text) == 0)
                if (txtgoldrecvchk.Text != string.Empty)
                {
                    _Cash = ((Convert.ToDouble(txtgoldrecvchk.Text) - Convert.ToDouble(txtGoldPaidchk.Text)) * currentValue);
                    if (_Cash > 0)
                    {
                        lblRate.Text = "----";
                        lblRate.Text = Math.Round(Convert.ToDouble(_Cash)).ToString();
                        txtCashPaidchk.Enabled = true;
                        txtcashRcvchk.Enabled = false;

                    }

                    else if (_Cash < 0)
                    {
                        lblRateClient.Text = "----";
                        lblRateClient.Text = (-Math.Round(Convert.ToDouble(_Cash))).ToString();
                        txtcashRcvchk.Enabled = true;
                        txtCashPaidchk.Enabled = false;

                    }
                }
            txtCashPaidchk.Text = "";
            txtcashRcvchk.Text = "";
        }

        string SetName(string name)
        {
            using (con = new SqlConnection(conn))
            {
                // select = "SELECT TOP 1 Client_Transection FROM ClientTransectionHistory where ='" + cmbClientNamePre.SelectedItem.ToString() + "'";

                select = "select Client_ID from Client where Customer_Name='" + cmbClientNamePre.SelectedItem.ToString() + "'";
                con.Open();

                cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtIDPre.Text = (rdr[0]).ToString();
                }
            }
       
           
            return name;
        }
        public void GetLastID()
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
                txtTransectionIDPre.Text = ID.ToString();



            }
        
        }



        private void btnSubmitPremain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbClientNamePre.Items.Count; i++)
            {
               
                if (collection[i] == cmbClientNamePre.Text)
                {
                    found = true;
                }
            }

            if (txtDatePre.Text == string.Empty)
            {
                MessageBox.Show("PLEASE SELECT DATE.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
                if (found == true)
            {
                using (con = new SqlConnection(conn))
                {
                    //insert = "insert into ClientTransectionHistory(Client_Transection,Client_ID,Customer_Name,Date,Gold_Paid,Cash_Paid,Gold_Receive,Cash_Receive) values" +
                    //        "('" + txtTransectionIDPre.Text + "','" + txtIDPre.Text + "','" + cmbClientNamePre.SelectedItem + "','" + Convert.ToDateTime(txtDatePre.Text).ToString("yyyy-MM-dd") + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')";
                    //con.Open();
                    //cmd = new SqlCommand(insert, con);
                    //SqlDataReader rdr = cmd.ExecuteReader();
                   
                    panelPre.Hide();
                    using (con = new SqlConnection(conn))
                    {
                        select = "select Jama_Gold, Jama_Cash from Client where Client_ID='" + txtIDPre.Text + "'";
                        con.Open();
                        cmd = new SqlCommand(select, con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            txtGoldBalalnce.Text = rdr.GetValue(0).ToString();
                            txtCashBalance.Text = rdr.GetValue(1).ToString();
                        }



                    }
                    panelPost.Show();
                    txtClientName.Text = cmbClientNamePre.Text;
                    txtTransectionID.Text = txtTransectionIDPre.Text;
                    txtDate.Text = txtDatePre.Text;
                    lblCID.Text = txtIDPre.Text;
                    found = false;


                    listBoxProductInven.Visible = false;
                    ProductComboFill();
                    P_collection = new string[co_P];
                    GetProductNameSearch();


                }
                
            }
            else
            {
                MessageBox.Show("YOU MAY HAVE SUPPLIED WRONG NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbClientNamePre.Text = "";
                txtIDPre.Text = "";
            
            }

            using (con = new SqlConnection(conn))
            {
                select = "select Gold_Value from Gold_Rate where Date='" + Convert.ToDateTime(dateTimePicker2.Value.Date).ToString("yyyy-MM-dd") + "'";
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
                goldLive_Popup.ShowDialog();
            }
            RefreshMAin();
            if (gridRecord.RowCount >= 0)
                gridRecord.Rows.Clear();

        }
        private void TextChanged(object sender, EventArgs e)
        {
            rb22.Checked = false;
            rb18.Checked = false;
            rb14.Checked = false;

        }

        void ClientComboFill()
        {
            cmbClientNamePre.Items.Clear();
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
                    cmbClientNamePre.Items.Add(reader.GetString(1));
                }
                co = cmbClientNamePre.Items.Count;
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
