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
    public partial class SuppilerPopUP : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        string select, insert;
       public static int ID;
       public static string SupNam = "", Sup_ID="";
        SqlCommand cmd;
 string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public SuppilerPopUP()
        {
            InitializeComponent();
        }

        private void SuppilerPopUP_Load(object sender, EventArgs e)
        {
            getCountInitial();
            GetSupplierNameCombo();
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
                    txtTransID.Text = "T" + ID;
                }
                else
                    ID = 1;
                txtTransID.Text = "T" + ID;

            }

        }
        private void cmbSpplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                //supplierName = cmbSpplierName.SelectedItem.ToString();
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
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            
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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
                if (txtID.Text == string.Empty)
                {
                    MessageBox.Show("Please enter All Fields", "Success", MessageBoxButtons.OK);
                }
                else if (txtCashPaid.Text == string.Empty|| txtGoldPaid.Text == string.Empty)
                {
                    MessageBox.Show("Please enter All Fields", "Success", MessageBoxButtons.OK);
                }
               
                else
                {

                    using (con = new SqlConnection(conn))
                    {
                         con.Open();
                        insert = "insert into SupplierTransection(Transection_ID,Supplier_ID,Cash_Paid,Gold_Paid) values ('"+ID+"','"+ txtID.Text + "'," +
                        "'" + txtCashPaid.Text + "', '" + txtGoldPaid.Text + "')";

                        //string update = "update Supplier set Cash_Paid='" + txtCashPaid.Text + "', Gold_Paid=" + txtGoldPaid.Text + ", Cash_Receive='" + txtCashReceive.Text + "', Gold_Receive= " + txtGoldReceive.Text + ",Balance_Cash='" + txtBalanceCash.Text + "', Balance_Gold=" + txtBalanceGold.Text + " where Supplier_ID='" + txtID.Text + "'";
                        SqlCommand cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                    Sup_ID = txtID.Text;
                    SupNam = cmbSpplierName.SelectedItem.ToString();


                        MessageBox.Show("Records Inserted Successfully", "Success", MessageBoxButtons.OK);
                    // groupBox1.Hide();
                    AdminWindow admin = new AdminWindow();
                    admin.ShowDialog();
                    this.Close();
                    }


                   

             
                }


            
        }
    }
}
