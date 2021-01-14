using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace Sample_Projectt
{
    public partial class PopupClientForm : Form
    {
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        string insert, select;
        public static int ID = 0;
        public PopupClientForm()
        {
            InitializeComponent();
        }

      public  void GetLastID()
        {
            con = new SqlConnection(conn);
            select = "SELECT TOP 1 Client_Transection FROM ClientTransectionHistory ORDER BY Client_Transection DESC";
            con.Open();

            cmd = new SqlCommand(select, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                ID = Convert.ToInt32(rdr.GetValue(0));
            }
            con.Close();
            if (ID != 0)
            {
                ID++;
            }
            else
            {
                ID = 1;
            }
            txtTransectionid.Text = ID.ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtdate.Text == string.Empty|| txtGold.Text == string.Empty) {
                MessageBox.Show("All Fields Are Necesary", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
           
            else
            using (con = new SqlConnection(conn))
            {
                insert = "insert into ClientTransectionHistory(Client_Transection,Client_ID,Customer_Name,Date,Gold_Paid,Cash_Paid,Gold_Receive,Cash_Receive) values" +
                        "('"+txtTransectionid.Text+"','" + txtID.Text + "','" + txtName.Text + "','" + Convert.ToDateTime(txtdate.Text).ToString("yyyy-MM-dd") + "','" + txtGold.Text + "','" + txtCashPaid.Text + "','"+0+"','"+0+"')";
                con.Open();
                cmd = new SqlCommand(insert, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                    this.Hide();
            }
        }

        private void PopupClientForm_Load(object sender, EventArgs e)
        {
            txtName.Text = ParentClient.nameClient;
            txtID.Text = ParentClient.ClientId;
            
            GetLastID();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCashPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTransectionid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGold_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = dateTimePicker1.Text;
        }
    }
}
