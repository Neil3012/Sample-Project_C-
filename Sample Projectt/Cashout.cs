using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Projectt
{
    public partial class Cashout : Form
    {
        int co;

        SqlCommand cmd;
        string select;
        SqlDataReader rdr;
        string[] collection;
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        string reportid;
        bool found;
        public Cashout()
        {
            InitializeComponent();
        }

        private void cmbSuplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSupplier.Visible = false;
            SetName(cmbSuplierName.SelectedItem.ToString());
            TransID();
            cmbTransctionID.Text = "";
            txtCurrent.Text = "";
            txtPureGold.Text = "";
           
        }
        string SetName(string name)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    DataTable dt = new DataTable();
                    select = "select * from Supplier where Name ='" + name + "' ";
                    cmd = new SqlCommand(select, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    //dataGridView1.DataSource = dt;

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtId.Text = dr["Supplier_ID"].ToString();
                        txtTotalCash.Text = dr["Balance_Cash"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return name;
            }
        }
        void TransID()
        {
            cmbTransctionID.Items.Clear();
            try
            {
                con = new SqlConnection(conn);
                con.Open();
                string query = "select distinct Transection_ID from InventoryDetails where Supplier_Name='" + cmbSuplierName.SelectedItem.ToString() + "'";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbTransctionID.Items.Add(reader.GetValue(0));

                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("" + ex);
            }
        }
        void GettingcomboValue()
        {
            cmbSuplierName.Items.Clear();
            try
            {
                con = new SqlConnection(conn);
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
                MessageBox.Show("Error occured!");
            }

        }
        void GetData()
        {

            DataTable dt = new DataTable();
            select = "select * from Supplier ";

            con = new SqlConnection(conn);
            cmd = new SqlCommand(select, con);
            con.Open();
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);

            dataGridView1.DataSource = dt;

            con.Close();

            //DataTable dr_art_line_2 = (DataTable)rdr["Product"];
            //for (int i = 0; i < dr_art_line_2.Rows.Count; i++)
            //{
            //    int temp = Convert.ToInt32(dr_art_line_2.Rows[i]["Product_ID"]);
            //}

        }

        private void Cashout_Load(object sender, EventArgs e)
        {
            found = false;
            GettingcomboValue();
            listBoxSupplier.Visible = false;
            collection= new string[co];
            GetSupplierNameSearch();

        }

        private void cmbTransctionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    DataTable dt = new DataTable();
                    select = "select * from InventoryDetails where Transection_ID ='" + cmbTransctionID.SelectedItem.ToString() + "' ";
                    string select1 = "select * from InventoryDetails Where Transection_ID=" + cmbTransctionID.SelectedItem.ToString();
                    
                    cmd = new SqlCommand(select, con);
                    SqlCommand cmd1 = new SqlCommand(select1, con);

                    con.Open();
                    rdr= cmd1.ExecuteReader();
                    dt.Load(rdr);
                    dataGridView1.DataSource = dt;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                       
            if (txtCurrent.Text == string.Empty || txtTotalCash.Text == string.Empty||txtPureGold.Text==string.Empty)
            {
                MessageBox.Show("CASHOUT IS NOT POSSIBLE", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(Convert.ToInt32(txtCurrent.Text)==0)
            {
                MessageBox.Show("CASHOUT IS NOT POSSIBLE", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBlank();
            }
            else
            {
                for (int i = 0; i < cmbSuplierName.Items.Count; i++)
                {
                    if(collection[i]==cmbSuplierName.Text)
                    {
                        found=true;
                    }
                   
                }

                if (found == true)
                {

                    using (con = new SqlConnection(conn))
                    {
                        //string str = "update Supplier set Balance_Cash=Balance_Cash-'" + Convert.ToInt32(txtCurrent.Text) + "'where Name='" + cmbSuplierName.SelectedItem.ToString() + "'";
                        //cmd = new SqlCommand(str, con);
                        //con.Open();
                        //int ch = cmd.ExecuteNonQuery();
                        //con.Close();
                        //if (ch == 1)
                        {
                            string str1 = "update SupplierTransection" +
                          " set Cash_Receive=Cash_Receive-'" + txtCurrent.Text + "' where Transection_ID='" + reportid + "'";
                            cmd = new SqlCommand(str1, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    using (con = new SqlConnection(conn))
                    {
                        string str = "update Supplier set Balance_Gold=Balance_Gold+'" + Convert.ToInt32(txtPureGold.Text) + "'where Supplier_ID='" + txtId.Text + "'";
                        cmd = new SqlCommand(str, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("RECORDS HAS BEEN UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("YOU HAVE ENTERED WRONG SUPPLIER NAME", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
         
            TextBlank();
            found = false;
        }
      
        void TextBlank()
        {
            txtCurrent.Text = "";
            txtId.Text = "";
            txtTotalCash.Text = "";
            cmbSuplierName.Text = "";
            cmbTransctionID.Text = "";
            txtPureGold.Text = "";
            lblDate.Text = "";
            lblRate.Text = "";
            dataGridView1.DataSource = "";

        }
        private void NOinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
      )
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

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (con = new SqlConnection(conn))
            {
                string str = "select Gold_Value from Gold_Rate where Date='" + lblDate.Text + "'";
                cmd = new SqlCommand(str, con);
                con.Open();
                rdr=cmd.ExecuteReader();
               while(rdr.Read())
                {
                    lblRate.Text = rdr["Gold_Value"].ToString();
                }
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtCurrent.Text = (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
                lblDate.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                reportid = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                //txtContact.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (lblDate.Text != null)
                {
                    DateTime lblDAte = Convert.ToDateTime(lblDate.Text);
                    using (con = new SqlConnection(conn))
                    {
                        string str = "select Gold_Value from Gold_Rate where Date='" + lblDAte.ToString("yyyy-MM-dd") + "'";
                        cmd = new SqlCommand(str, con);
                        con.Open();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            lblRate.Text = rdr["Gold_Value"].ToString();
                        }
                        con.Close();
                    }
                }
                using (con = new SqlConnection(conn))
                {
                    string temp = "";
                    select = "SELECT Cash_Receive FROM SupplierTransection where Transection_ID ='" + reportid + "'";
                    con.Open();

                    cmd = new SqlCommand(select, con);
                    rdr = cmd.ExecuteReader();
                    //rdr.IsDBNull
                    while (rdr.Read())
                    {
                        txtCurrent.Text = (rdr[0]).ToString();
                    }


                }

            }
            else
            {
                MessageBox.Show("PLEASE CLICK ON VALUES NOT COLUMN HEADER", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Console.WriteLine("Print " + e.ColumnIndex + "      " + e.RowIndex);
            }
        }

        private void listBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSuplierName.SelectedItem=listBoxSupplier.SelectedItem;
            SetName(cmbSuplierName.SelectedItem.ToString());
            listBoxSupplier.Visible = false;
        }
        void GetSupplierNameSearch()
        {
            try
            {
                int i = 0;
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
                MessageBox.Show("Error Occured!");
            }
        }
        private void cmbSuplierName_TextChanged(object sender, EventArgs e)
        {
            
                // get the keyword to search
                string textToSearch = cmbSuplierName.Text.ToLower();
                listBoxSupplier.Visible = false; // hide the listbox, see below for why doing that
                if (String.IsNullOrEmpty(textToSearch))
                    return; // return with listbox hidden if the keyword is empty
                            //search
                string[] result = (from j in collection
                                   where j.ToLower().Contains(textToSearch)
                                   select j).ToArray();
                if (result.Length == 0)
                    return; // return with listbox hidden if nothing found

                listBoxSupplier.Items.Clear(); // remember to Clear before Add
                listBoxSupplier.Items.AddRange(result);
                listBoxSupplier.Visible = true; // show the listbox again
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPureGold_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCurrent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
