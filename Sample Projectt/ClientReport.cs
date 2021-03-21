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
    public partial class ClientReport : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection sql;
        SqlDataReader rdr;
        SqlCommand cmd;


        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;
        public ClientReport()
        {
            InitializeComponent(); printDocument1.PrintPage +=
                new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {
            GetSupplierNameCombo();
        }
        
       

       
        void GetSupplierNameCombo()
        {
            cmbClient.Items.Clear();
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Distinct Customer_Name from ClientTransectionHistory";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbClient.Items.Add(reader.GetValue(0));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error Occured!");
            }
        }

     
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlConnection con;
            SqlCommand cmd, cmd1;
            string select = "select * from ClientTransectionHistory where Customer_Name ='" + cmbClient .SelectedItem + "' ";

            using (con = new SqlConnection(conn))
            {
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //foreach (DataRow dr in dt.Rows)
                //{
                //     txtClintNam.Text = dr["Customer_Name"].ToString();
                //}
                con.Close();
            }
            string select1 = "select Purchase_ID,Client_Name,Product_Name,Sold_Quantity,Sold_Weight,Cash_Amount,Pure_Gold,Purchase_Date,Client_Transection from Purchase where Client_Name ='" + cmbClient.SelectedItem + "' ";

            using (con = new SqlConnection(conn))
            {
                cmd1 = new SqlCommand(select1, con);
                con.Open();
                rdr = cmd1.ExecuteReader();
                dt1.Load(rdr);
                con.Close();
                dt1.Columns["Purchase_Date"].ColumnName = "Date";
                dt1.Columns["Cash_Amount"].ColumnName = "Cash";
                DataSet dsDataset = new DataSet();
                //Add two DataTables in Dataset   
                dsDataset.Tables.Add(dt);
                dsDataset.Tables.Add(dt1);

                DataRelation Datatablerelation = new DataRelation("DETAIL TRANSECTION", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[8], false);
                dsDataset.Relations.Add(Datatablerelation);
                //dataGrid1.Columns["Client_Transection"].Width = 130;
                dataGrid1.DataSource = dsDataset.Tables[0];

            }

            //DataTable dt = new DataTable();
            //string select = "select * from Purchase where Client_Name ='" + cmbClient.SelectedItem + "' ";
            ////            /// string select = "select Supplier.Supplier_ID,Supplier.Name,Supplier.Contact,Supplier.Gold,Supplier.Cash,InventoryDetails.Date  from Supplier outer join InventoryDetails on '" + cmbSupplier.SelectedItem+ "'  =  '"+cmbSupplier.SelectedItem+"' ";

            //SqlConnection con = new SqlConnection(conn);
            //cmd = new SqlCommand(select, con);
            //con.Open();
            //rdr = cmd.ExecuteReader();
            //dt.Load(rdr);
            //dataGridClint.DataSource = dt;

            con.Close();
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

    }
}
