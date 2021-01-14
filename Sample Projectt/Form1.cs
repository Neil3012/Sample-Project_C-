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
    public partial class Form1 : Form
    {
        public static int CID = 0;
        string vc = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlCommand cmd;
        SqlDataReader rdr;
        string a, b, c;
        SqlConnection con;
        string name, insert;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(vc);
            // TODO: This line of code loads data into the 'goldDataSet.Inventory' table. You can move, or remove it, as needed.
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            insert = "insert into Purchase(Sold_Quantity,Sold_Weight,Balance_Gold,Cash) value('" + txtSold.Text + "','" + txtWeight.Text + "','" + txtBalance.Text + "','" + txtCash.Text + "') ";
            cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            string select = "select * from ";
        }

        void Create()
        {
            CID++;
            con.Open();
        name = textBox1.Text + textBox2.Text + textBox3.Text;
           insert = "insert into Client(CID,CustomerName,Phone,Email,Location) values("+CID+",'" + name + "','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"'  )  ";
           cmd = new SqlCommand(insert, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = "select * from Inventory where Item_Name='"+ cmbItem.SelectedValue+"'";
            con.Open();
                 cmd = new SqlCommand(select, con);
           rdr= cmd.ExecuteReader();
            while (rdr.Read())
            {
                a =rdr["Item_Weight"].ToString();
                b = rdr["Total_Quantity"].ToString(); ;
            }
            con.Close();
          //  Console.WriteLine("value "+a);
            txtItem.Text = a;
            txtQuantity.Text = b;
        }
    }
}
