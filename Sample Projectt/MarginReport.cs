using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Projectt
{
    public partial class MarginReport : Form
    {
        string dateTo;
        string dateFrom;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        string select, selectCT;
        DataTable dt;
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        private string documentContents;
        private string stringToPrint;

        bool day;
        public MarginReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dateFrom = Convert.ToDateTime(datePickFrom.Value.Date).ToString("yyyy-MM-dd");
            dateTo = Convert.ToDateTime(datePickTo.Value.Date).ToString("yyyy-MM-dd");
            if (day == true)
            {
                selectCT = "select  * from ClientTransectionHistory where Date='" + dateFrom + "'";
            }
            if (day == false)
            {
                selectCT = "select DISTINCT * from ClientTransectionHistory where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }

            GetClientTransection();
            gridClientTransectionDetails.Show();
            SumMarginInventory();
            GridStyle();
        }

        void SumMarginInventory()
        {
            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Margin) from ClientTransectionHistory where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Margin) from ClientTransectionHistory where Date= '" + dateFrom + "'";

            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblMargin.Text = cmd.ExecuteScalar().ToString();
            }


        }
        void GridStyle()
        {
            gridClientTransectionDetails.ColumnHeadersDefaultCellStyle.Font =
      new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold);
            gridClientTransectionDetails.Columns["CC"].Name = "Cash Clear";
        



        }
        void GetClientTransection()
        {
            gridClientTransectionDetails.DataSource = "";
            using (con = new SqlConnection(conn))
            {
                dt = new DataTable();
                cmd = new SqlCommand(selectCT, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                gridClientTransectionDetails.DataSource = dt;
            

            }
        }
        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            day = true;
            datePickTo.Hide();
            datePickFrom.Show();
            lblFrom.Hide();
            lblTo.Hide();

        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            day = false;
            datePickTo.Show();
            datePickFrom.Show();
            lblFrom.Show();
            lblTo.Show();
        }

        private void MarginReport_Load(object sender, EventArgs e)
        {
            datePickFrom.Hide();
            datePickTo.Hide();
            lblFrom.Hide();
            lblTo.Hide();
            gridClientTransectionDetails.Hide();
            //gridPurchasedetails.Hide();

            //GetInventoryDetails();
            //GetSupplierTransection();
            //GetPurchase();
            rbDay.Checked = false;
            rbMonth.Checked = false;

        }
    }
}
