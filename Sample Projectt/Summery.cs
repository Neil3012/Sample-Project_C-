using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Projectt
{
    public partial class Summery : Form
    {
        string dateTo;
        string dateFrom;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        string select, selectInventory, selectSupplier, selectProduct;
        DataTable dt;
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();
        
        private string documentContents;
        private string stringToPrint;

        bool day;
        public Summery()
        {
            InitializeComponent();
            printDocument1.PrintPage +=
                new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void Summery_Load(object sender, EventArgs e)
        {
            datePickFrom.Hide();
            datePickTo.Hide();
            lblFrom.Hide();
            lblTo.Hide();
            gridInventoryDetails.Hide();
            gridPurchasedetails.Hide();
            
            //GetInventoryDetails();
            //GetSupplierTransection();
            //GetPurchase();
            rbDay.Checked = false;
            rbMonth.Checked = false;

            //GridStyle();
        }
        void GridStyle()
        {
            gridInventoryDetails.ColumnHeadersDefaultCellStyle.Font =
      new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold);
            gridInventoryDetails.Columns["Product_Name"].Width = 110;
            gridInventoryDetails.Columns["Supplier_Name"].Width = 120;

            gridPurchasedetails.ColumnHeadersDefaultCellStyle.Font =
      new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold);
            gridPurchasedetails.Columns["Client_Name"].Width = 110;
            gridPurchasedetails.Columns["Product_Name"].Width = 110;
            gridPurchasedetails.Columns["Purchase_Date"].Width = 120;


        }
        private void btnCal_Click(object sender, EventArgs e)
        {
            //String columnName = this.gridInventoryDetails.Columns[e.ColumnIndex].Name;

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

        private void btnShow_Click(object sender, EventArgs e)
        {
           dateFrom= Convert.ToDateTime(datePickFrom.Value.Date).ToString("yyyy-MM-dd");
             dateTo = Convert.ToDateTime(datePickTo.Value.Date).ToString("yyyy-MM-dd");
            if (day == true)
            {
                selectSupplier = "select  * from SupplierTransection where Date='" + dateFrom + "'";
                selectInventory = "select  ReportID,Product_Name,Supplier_Name,Item_Weight,Item_Quantity,Pure_Gold,Date,Labour,LabourRS from InventoryDetails where Date='" + dateFrom + "'";
                selectProduct = "select  Purchase_ID,Client_Name,Product_Name,Sold_Quantity,Sold_Weight,Pure_Gold,Purchase_Date,Labour,LabourRS from Purchase where Purchase_Date='" + dateFrom + "'";
            }
            if (day == false)
            {
                selectSupplier = "select DISTINCT * from SupplierTransection where Date between '" + dateFrom + "' and '" + dateTo + "'";
                selectInventory = "select DISTINCT  ReportID,Product_Name,Supplier_Name,Item_Weight,Item_Quantity,Pure_Gold,Date,Labour,LabourRS from InventoryDetails where Date between '" + dateFrom + "' and '" + dateTo + "'";
                selectProduct = "select DISTINCT Purchase_ID,Client_Name,Product_Name,Sold_Quantity,Sold_Weight,Pure_Gold,Purchase_Date,Labour,LabourRS from Purchase where Purchase_Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            GetSupplierTransection();
            GetInventoryDetails();
            GetPurchase();
            gridInventoryDetails.Show();
            gridPurchasedetails.Show();
            //gridSupplierTransection.Show();
            SumcalInventory();
            SumCalPurchase();
            SumMarginInventory();
            //SumCalSuplierTransection();
            GridStyle();




        }
        void SumCalSuplierTransection()
        {
            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Gold_Paid) from SupplierTransection where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Gold_Paid) from SupplierTransection where Date= '" + dateFrom + "'";

            //using (con = new SqlConnection(conn))
            //{
            //    cmd = new SqlCommand(select, con);
            //    con.Open();
            //    //lblSupGoldPaid.Text = cmd.ExecuteScalar().ToString();
            //}


            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Gold_Receive) from SupplierTransection where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Gold_Receive) from SupplierTransection where Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
              //  lblSupGoldReceive.Text = cmd.ExecuteScalar().ToString();
            }


        }
        void SumCalPurchase()
        {
            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Pure_Gold) from Purchase where Purchase_Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Pure_Gold) from Purchase where Purchase_Date= '" + dateFrom + "'";

            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblPurchasepure.Text = cmd.ExecuteScalar().ToString();
            }


            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Sold_Quantity) from Purchase where Purchase_Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Sold_Quantity) from Purchase where Purchase_Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblPurchaseQuantity.Text = cmd.ExecuteScalar().ToString();
            }



            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Sold_Weight) from Purchase where Purchase_Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Sold_Weight) from Purchase where Purchase_Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblPurchaseWeight.Text = cmd.ExecuteScalar().ToString();
            }

            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Pure_Gold) from Purchase where Purchase_Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Pure_Gold) from Purchase where Purchase_Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblFinePurchase.Text = cmd.ExecuteScalar().ToString();
            }

        }
        void SumcalInventory()
        {
            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Pure_Gold) from InventoryDetails where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Pure_Gold) from InventoryDetails where Date= '" + dateFrom + "'";

            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblfine.Text = cmd.ExecuteScalar().ToString();
            }


            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Item_Weight) from InventoryDetails where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Item_Weight) from InventoryDetails where Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lbltotal.Text = cmd.ExecuteScalar().ToString();
            }



            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Item_Quantity) from InventoryDetails where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Item_Quantity) from InventoryDetails where Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblQuantity.Text = cmd.ExecuteScalar().ToString();
            }



            if (rbMonth.Enabled == true)
            {
                select = "select Sum(Pure_Gold) from InventoryDetails where Date between '" + dateFrom + "' and '" + dateTo + "'";
            }
            else if (rbDay.Enabled == true)
                select = "select Sum(Pure_Gold) from InventoryDetails where Date= '" + dateFrom + "'";
            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                lblfine.Text = cmd.ExecuteScalar().ToString();
            }
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
        private void dgInvent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                boldStyle.ForeColor = Color.Red;
                gridInventoryDetails.Rows[e.RowIndex].DefaultCellStyle = boldStyle;
            }

            else
            {
                return;
            }

        }

        private void dgInvent_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);

            gridInventoryDetails.Rows[e.RowIndex].DefaultCellStyle = norStyle;


        }


        void GetSupplierTransection()
        {
            gridInventoryDetails.DataSource = "";
            using (con = new SqlConnection(conn))
            {
                dt = new DataTable();
                cmd = new SqlCommand(selectSupplier, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

               // gridSupplierTransection.DataSource = dt;

            }
        }
        private void dgSup_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                boldStyle.ForeColor = Color.Red;
               //gridSupplierTransection.Rows[e.RowIndex].DefaultCellStyle = boldStyle;
            }

            else
            {
                return;
            }

        }

        private void dgSup_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);

          //  gridSupplierTransection.Rows[e.RowIndex].DefaultCellStyle = norStyle;


        }
        void GetInventoryDetails()
        {

            using (con = new SqlConnection(conn))
            {
                dt = new DataTable();
                gridInventoryDetails.DataSource = 0;
                cmd = new SqlCommand(selectInventory, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                gridInventoryDetails.DataSource = dt;

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void ReadDocument()
        {
            string docName = "testPage.txt";
            string docPath = @"e:\";
            printDocument1.DocumentName = docName;
            using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                documentContents = reader.ReadToEnd();
            }
            stringToPrint = documentContents;
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void printPreviewButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        void GetPurchase()
        {
            using (con = new SqlConnection(conn))
            {
                dt = new DataTable();
                cmd = new SqlCommand(selectProduct, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                gridPurchasedetails.DataSource = dt;

            }
        }
        private void dg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
                boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                boldStyle.ForeColor = Color.Red;
                gridPurchasedetails.Rows[e.RowIndex].DefaultCellStyle = boldStyle;
            }

            else
            {
                return;
            }
        }

        private void dg_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);

            gridPurchasedetails.Rows[e.RowIndex].DefaultCellStyle = norStyle;


        }
    }
}
