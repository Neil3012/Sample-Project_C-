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
    public partial class GoldLive_Popup : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        string select;
        public static double curr = 0.0f;

        public GoldLive_Popup()
        {
            InitializeComponent();
        }

        private void btnSubmitInitial_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(conn))
            {
                dateTimePicker1.Text = DateTime.Now.Date.ToShortDateString() ;
                string select = "insert into Gold_Rate(Date,Gold_Value) values('" + Convert.ToDateTime(dateTimePicker1.Value.Date).ToString("yyyy-MM-dd") + "','"+txtDatePremain.Text+"')";
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                AdminWindow.currentValue = Convert.ToDouble(txtDatePremain.Text);
        MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }
    }
}
