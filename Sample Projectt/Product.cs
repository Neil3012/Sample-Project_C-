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
    public partial class Product : Form
    {
        public string DBID="";
        public static int ID = 0;
        string REGID = "";
        public static string Word = "SM/" + DateTime.Now.Year+"/";

        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        string select, insert,update;
        SqlCommand cmd,cmd1;
        public SqlDataReader rdr;
        DataTable dt;


      
        SqlDataAdapter adap;
        SqlCommandBuilder sqlbuild;
        DataSet ds;
        private void Product_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);

            getCount();
        }

        public Product()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "&Update")
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
                btn.Text = "&OK";
            }
            else if(btn.Text=="&OK")
            {
                adap = new SqlDataAdapter("select Product_ID,Product_Name,Description from Product", con);
                sqlbuild = new SqlCommandBuilder(adap);
                adap.Update(dt);
                btn.Text = "&Update";
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }




         
        
        }

     

        //for getting Countine of registered user
        void getCount()
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
            string temp = DBID.Substring(8, 5);
            ID = Convert.ToInt32(temp);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            con = new SqlConnection(conn);
            if (!(txtName.Text == string.Empty))
            {
                ID++;
                string value = ID.ToString("00000");
                REGID = Word + value;

                string insert = "insert into Product values('" + REGID + "','" + txtName.Text + "','" + txtDesc.Text + "')";
                string insert1 = "insert into Inventory values('" + REGID + "','" + txtName.Text + "')";
                cmd = new SqlCommand(insert, con);
                cmd1 = new SqlCommand(insert1, con);
                con.Open();
                cmd.ExecuteNonQuery();
                //cmd1.ExecuteNonQuery();
                con.Close();
                GetData();            
            }
        }
        
      void GetData()
        {
           
            dt = new DataTable();
            select = "select * from Product";

      
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
    }
}
