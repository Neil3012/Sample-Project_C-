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
    public partial class Login : Form
    {

        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        string select, insert, update;
        SqlDataReader rdr;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int count = 0;

        private void btnSubmitEmp_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (string.IsNullOrEmpty(txtEuser.Text))
            {
                MessageBox.Show("Please Enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(txtEpass.Text))
            {
                MessageBox.Show("Please Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                using (con = new SqlConnection(conn))
                {
                    select = "select * from Employee where EmpUsername ='" + txtEuser.Text + "' and EmpPassword='" + txtEpass.Text + "' ";



                    cmd = new SqlCommand(select, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        this.Visible = false;
                        ParentClient parentClient = new ParentClient();
                        parentClient.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("USERNAME And PASSWORD Are Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtApass.Text = "";
                    }

                }
            }
        }

        private void lblhead_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            GettingGoldCurrent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void LivePriceDatePicker_ValueChanged(object sender, EventArgs e)
        {

            txtGoldLive.Text = "";
            GettingGoldCurrent();
            if (txtGoldLive.Text == string.Empty)
            {
                btnSubmitLive.Text = "&Submit";
            }
            else
                btnSubmitLive.Text = "&Update";




        }
      
       
        void GettingGoldCurrent()
        {
            using (con = new SqlConnection(conn))
            {

                select = "select Gold_Value from Gold_Rate where Date='" + LivePriceDatePicker.Value.Date.ToString("yyyy-MM-dd") + "'";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        txtGoldLive.Text = rdr["Gold_Value"].ToString();
                    }
                }
            }
        }
        private void btnSubmitLive_Click(object sender, EventArgs e)
        {
           // Button btn = (Button)sender;

            //if (btnSubmitLive.Text == "&Submit")
                PriceGoldToday();
            //if (btnSubmitLive.Text == "&Update")
            //    UpdateGoldToday();

        }
        void UpdateGoldToday()
        {
           
        }
        void PriceGoldToday()
        {
            if (txtGoldLive.Text != string.Empty)
            {
                using (con = new SqlConnection(conn))
                {
                    string select = "select Gold_Value from Gold_Rate where Date='" + LivePriceDatePicker.Value.Date.ToString("yyyy-MM-dd") + "'";
                    cmd = new SqlCommand(select, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    con.Close();
                    if (rdr == null)
                    {
                        using (con = new SqlConnection(conn))
                        {
                            string tmp = "insert into Gold_Rate(Date,Gold_Value) values('" + LivePriceDatePicker.Value.Date.ToString("yyyy-MM-dd") + "','" + txtGoldLive.Text + "')";
                            cmd = new SqlCommand(tmp, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("YOU HAVE INSERTED GOLD RATE SUCCESSFULLY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else

                        using (con = new SqlConnection(conn))
                        {
                            string tmp = "update Gold_Rate set Gold_Value='" + txtGoldLive.Text + "' where Date='" + LivePriceDatePicker.Value.Date.ToString("yyyy-MM-dd") + "'";
                            cmd = new SqlCommand(tmp, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("YOU HAVE UPDATED GOLD RATE SUCCESSFULLY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          //  btnSubmitLive.Text = "&Submit";
                        }
                }

               

            }
            else
            {
                MessageBox.Show("YOU MUST HAVE TO ENTER TODAY'S GOLD RATE.", "Cant't be NULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void NOinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            int count = 0;
            if (string.IsNullOrEmpty(txtAuser.Text))
            {
                MessageBox.Show("Please Enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                using (con = new SqlConnection(conn))
                {
                    select = "select * from Admin where username ='" + txtAuser.Text + "' and password='" + txtApass.Text + "' ";



                    cmd = new SqlCommand(select, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        this.Visible = false;

                        AdminWindow adminWindow = new AdminWindow();

                        adminWindow.ShowDialog();



                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtEpass.Text = "";

                    }

                }
            }
        }
    }
}
