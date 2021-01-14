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
    public partial class TransectionSupplier : Form
    {
        public static string supplierName = "", supplierID = "";
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        string select, insert, update;
        SqlDataAdapter adap;
        SqlCommand cmd, cmd1;
        double G_Paid, G_Receive, Bal_Gold;
        int C_Paid, C_Receive, Bal_Cash;
        float Gold_R;
        float Lab;
        string radioValue = "";
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Please enter All Fields", "Success", MessageBoxButtons.OK);
            }
            else if (txtBalanceCash.Text == string.Empty)
            {
                MessageBox.Show("Please enter All Fields", "Success", MessageBoxButtons.OK);
            }
            else if (rb24.Checked == false || rb22.Checked == false || rb18.Checked == false)
            {
                MessageBox.Show("Please select How much Karat it is!");
            }
            else
            {
               
                using (con = new SqlConnection(conn))
                {

                   

                  
                            con.Open();
                    insert = "insert into SupplierTransection(Supplier_ID,Supplier_Name,Cash_Paid,Gold_Paid," +
                    "Cash_Receive,Gold_Receive,Balance_Gold,Balance_Cash) values ('" + txtID.Text + "','" + cmbSpplierName.SelectedItem.ToString() + "' ," +
                    "'" + txtCashPaid.Text + "', '" + txtGoldPaid.Text + "' ,'" + txtCashReceive.Text + "','" + txtGoldReceive.Text + "','" + Bal_Gold + "'," +
                    "'" + Bal_Cash + "')";

                    //string update = "update Supplier set Cash_Paid='" + txtCashPaid.Text + "', Gold_Paid=" + txtGoldPaid.Text + ", Cash_Receive='" + txtCashReceive.Text + "', Gold_Receive= " + txtGoldReceive.Text + ",Balance_Cash='" + txtBalanceCash.Text + "', Balance_Gold=" + txtBalanceGold.Text + " where Supplier_ID='" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Records Inserted Successfully", "Success", MessageBoxButtons.OK);
                    // groupBox1.Hide();
                }


                using (con = new SqlConnection(conn))
                {
                    {
                        con.Open();
                        update = "update Supplier set Balance_Cash=Balance_Cash+'" + Bal_Cash + "', " +
                            "Balance_Gold=Balance_Gold+" + Bal_Gold + "" +
                            " where Supplier_ID='" + txtID.Text + "'";
                        cmd = new SqlCommand(update, con);
                        cmd.ExecuteNonQuery();
                    }

                }


                this.Close();
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //private void txtGoldPaid_TextChanged(object sender, EventArgs e)
        //{
        //    using (con = new SqlConnection(conn))
        //    {
        //        con.Open();
        //        // update = "update Supplier set Balance_Cash=Balance_Cash +'" + txtBalanceCash.Text + "', Balance_Gold=Balance_Gold+" + txtBalanceGold.Text + 

        //        select= "select Balance_Gold from SupplierTransection where Supplier_ID = '" + txtID.Text + "'";
        //         SqlCommand cmd = new SqlCommand(select, con);
        //       rdr= cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            label8.Text = rdr["Balance_Gold"].ToString();

        //        }
        //        //
        //        //     MessageBox.Show("Records Updated Successfully", "Success", MessageBoxButtons.OK);
        //        // groupBox1.Hide();
        //    }


        //}
        void BalanceUpdate()
        {
            using (con = new SqlConnection(conn))
            {
                con.Open();
                // update = "update Supplier set Balance_Cash=Balance_Cash +'" + txtBalanceCash.Text + "', Balance_Gold=Balance_Gold+" + txtBalanceGold.Text + 

                select = "select Balance_Gold,Balance_Cash from Supplier where Supplier_ID = '" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label8.Text = rdr["Balance_Gold"].ToString();
                    label9.Text = rdr["Balance_Cash"].ToString();



                }
            }
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(conn))
            {

                double a = Convert.ToDouble(label9.Text);
                if (a <= 0)
                {
                    MessageBox.Show("Cash Out is Not Possible", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult rslt = MessageBox.Show("Are You sure want to cash out ", "Success", MessageBoxButtons.YesNo);
                    if (rslt == DialogResult.Yes)
                    {
                        double b = Convert.ToDouble(label9.Text);
                        double c = a - b;
                        //txtGoldPaid.Text = (label8.Text);
                        //txtGoldReceive.Text = (label9.Text);
                        //txtBalanceGold.Text = c.ToString();
                        con.Open();
                        update = "update Supplier set Balance_Cash=Balance_Cash-'" + a + "' where Supplier_ID='" + txtID.Text + "'";
                        cmd = new SqlCommand(update, con);
                        cmd.ExecuteNonQuery();
                        BalanceUpdate();












                    }



                }
            }
        }

        private void rb24_Click(object sender, EventArgs e)
        {
          if(rb24.Checked==true)
            {
                float.TryParse(txtGoldReceive.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (99.5 + Lab) / 99.5;
            }
            else if (rb22.Checked == true)
            {
                float.TryParse(txtGoldReceive.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (92.7 + Lab) / 99.5;
            }
            else if (rb18.Checked == true)
            {
                float.TryParse(txtGoldReceive.Text, out Gold_R);
                float.TryParse(txtLabour.Text, out Lab);
                G_Receive = Gold_R * (75.25 + Lab) / 99.5;
            
            }
            txtpureGold.Text = G_Receive.ToString();
        }

      
        private void txtGoldReceive_TextChanged_1(object sender, EventArgs e)
        {
            rb18.Checked = false;
            rb22.Checked = false;
            rb24.Checked = false;
        }

        private void txtGoldPaid_MouseClick(object sender, MouseEventArgs e)
        {

            BalanceUpdate();
            //     MessageBox.Show("Records Updated Successfully", "Success", MessageBoxButtons.OK);
            btnck.Enabled = true;
            btnCashout.Enabled = true;

        }

        private void btnck_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(conn))
            {

                double a = Convert.ToDouble(label8.Text);
                if (a <= 0)
                {
                    MessageBox.Show("CheckOut is Not Possible", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult rslt = MessageBox.Show("Are You sure want to checkout ", "Success", MessageBoxButtons.YesNo);
                    if (rslt == DialogResult.Yes)
                    {
                        double b = Convert.ToDouble(label9.Text);
                        double c = a - b;
                        //txtGoldPaid.Text = (label8.Text);
                        //txtGoldReceive.Text = (label9.Text);
                        //txtBalanceGold.Text = c.ToString();
                        con.Open();
                        update = "update Supplier set Balance_Gold=Balance_Gold-'" + a + "' where Supplier_ID='" + txtID.Text + "'";
                        cmd = new SqlCommand(update, con);
                        cmd.ExecuteNonQuery();
                        BalanceUpdate();












                        }



                }
            }
        }

        private void txtGoldPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;


            }
        }

        private void txtCashReceive_Leave(object sender, EventArgs e)
        {

            G_Paid = Convert.ToDouble(txtGoldPaid.Text);
            G_Receive = Convert.ToDouble(txtGoldReceive.Text);
            Bal_Gold = (G_Paid - G_Receive);
            txtBalanceGold.Text = Bal_Gold.ToString();

            C_Paid = Convert.ToInt32(txtCashPaid.Text);
            C_Receive = Convert.ToInt32(txtCashReceive.Text);
            Bal_Cash = (C_Paid - C_Receive);
            txtBalanceCash.Text = Bal_Cash.ToString();

        }

        private void cmbSpplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierName = cmbSpplierName.SelectedItem.ToString();
            //    Console.WriteLine("Value is " + cmdSupplier.SelectedItem);
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    select = "select * from Supplier where Name ='" + cmbSpplierName.SelectedItem.ToString() + "' ";
                    cmd = new SqlCommand(select, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    //dt.Load(rdr);
                    while (rdr.Read())
                    {
                        txtID.Text = rdr["Supplier_Id"].ToString();
                        supplierID = txtID.Text;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
       public TransectionSupplier()
        {
            InitializeComponent();
        }

        private void TransectionSupplier_Load(object sender, EventArgs e)
        {
            GetSupplierNameCombo();
            btnck.Enabled = false;
            btnCashout.Enabled = false;
        }
        void GetSupplierNameCombo()
        {
            cmbSpplierName.Items.Clear();
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
                    cmbSpplierName.Items.Add(reader.GetString(0));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error Occured!");
            }
        }
    }
}
