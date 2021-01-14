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
using System.Drawing.Printing;

namespace Sample_Projectt
{
    public partial class Report : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd, cmd1;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        public Report()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            string select = "select * from SupplierTransection where Transection_ID ='"+cmbSupplier.SelectedItem+"' ";

            using (con = new SqlConnection(conn))
            { 
                cmd = new SqlCommand(select, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                foreach (DataRow dr in dt.Rows)
                {
                    txtSupName.Text = dr["Supplier_Name"].ToString();
                }
                con.Close();
            }
            string select1 = "select ReportID,Product_Name,Supplier_Name,Item_Weight,Item_Quantity,Date,Pure_Gold,Cash,Labour,Transection_ID from InventoryDetails where Transection_ID ='" + cmbSupplier.SelectedItem + "' ";

            using (con = new SqlConnection(conn))
            {
                cmd1 = new SqlCommand(select1, con);
                con.Open();
                rdr = cmd1.ExecuteReader();
                dt1.Load(rdr);
                dt1.Columns["Item_Weight"].ColumnName = "Weight";
                dt1.Columns["Item_Quantity"].ColumnName = "Quantity";
                dt1.Columns["Supplier_Name"].ColumnName = "Name";
                con.Close();
          
                DataSet dsDataset = new DataSet();
                //Add two DataTables in Dataset   
                dsDataset.Tables.Add(dt);
                dsDataset.Tables.Add(dt1);

                DataRelation Datatablerelation = new DataRelation("DETAIL TRANSECTION", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[9], false);
                dsDataset.Relations.Add(Datatablerelation);
                dataGrid1.DataSource = dsDataset.Tables[0];
                //7dataGrid1.HeaderRow.Cells[0].Attributes["Width"] = "100px";
              
            }
        }
        //void GetSupplierNameCombo()
        //{
        //    cmbSupplier.Items.Clear();
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(conn);
        //        con.Open();
        //        string query = "select Name from Supplier";
        //        SqlCommand command = new SqlCommand(query, con);
        //        //using (SqlDataReader reader = command.ExecuteReader())
        //        //{
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            //cmbSupplier.Items.Add(reader.GetString(0));
        //            txtSupName.Text = reader.GetString(0);
        //        }
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        // write exception info to log or anything else
        //        MessageBox.Show("Error Occured!");
        //    }
        //}
        void GetTRansectionCombo()
        {
            cmbSupplier.Items.Clear();

            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    string query = "select Transection_ID from SupplierTransection";
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        cmbSupplier.Items.Add(reader.GetValue(0));
                    }
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Blank");
                }
            }
        }



        private void Report_Load(object sender, EventArgs e)
        {
            // GetSupplierNameCombo();
            //DataGrid = 12;
            GetTRansectionCombo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    }
}
