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
    public partial class Current_Inventory : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlConnection con;
        DataTable dt;
        public Current_Inventory()
        {
            InitializeComponent();
        }

        private void Current_Inventory_Load(object sender, EventArgs e)
        {
            using (con=new SqlConnection(conn))
            {
                dt = new DataTable();
                string select = "Select * from Inventory";
                con.Open();
                cmd = new SqlCommand(select, con);
                rdr=cmd.ExecuteReader();
                dt.Load(rdr);
                dt.Columns["Product_Id"].ColumnName = "ID";               
                dt.Columns["Purity"].ColumnName = "PURITY";
                dt.Columns["Item_Weight"].ColumnName = "WEIGHT";
                dt.Columns["Total_Quantity"].ColumnName = "QUANTITY";
                dt.Columns["Item_Name"].ColumnName = "PRODUCT";






                currentGrid.DataSource = dt; currentGrid.Width = 1000;
                
                // GridStyle();
            }
        }
    }
}
