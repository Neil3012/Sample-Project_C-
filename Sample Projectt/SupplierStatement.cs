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
    // is not printed.
    
    public partial class SupplierStatement : Form
    {
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();
        private string stringToPrint;

        private string documentContents;
          object obj;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        DataTable dt;
        SqlCommand command;
        SqlConnection con;
        SqlDataReader reader;
        string[] collection;
        int co;
        int disQuantity, disTotalight, disPure;

        public SupplierStatement()
        {
            InitializeComponent();
            printDocument1.PrintPage +=
              new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void SupplierStatement_Load(object sender, EventArgs e)
        {
            listBoxSuppName.Visible = false;
            GetSupplierName();
            collection = new string[co];
            lblDate.Text = DateTime.Now.ToShortDateString();
            GetClientNameSearch();
        }
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetName(cmbSupplier.SelectedItem.ToString());
            listBoxSuppName.Visible = false;
        }

        private void listBoxSuppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSupplier.SelectedItem = listBoxSuppName.SelectedItem;
            SetName(cmbSupplier.SelectedItem.ToString());
            listBoxSuppName.Visible = false;
        }

        private void cmbSupplier_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cmbSupplier.Text.ToLower();
            listBoxSuppName.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listBoxSuppName.Items.Clear(); // remember to Clear before Add
            listBoxSuppName.Items.AddRange(result);
            listBoxSuppName.Visible = true; // show the
        }
        string SetName(string name)
        {
            try
            {
                con = new SqlConnection(conn);
                con.Open();
                string query = "select * from Supplier where Name='" + cmbSupplier.SelectedItem.ToString() + "' ";
                command = new SqlCommand(query, con);

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lblMobile.Text = reader.GetValue(2).ToString();
                    lblAdd.Text = reader.GetString(4).ToString();

                }

                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }

            using (con = new SqlConnection(conn))
            {
                con.Open();
                dt = new DataTable();
                string query = "select Product_Name,Supplier_Name,Item_Weight,Item_Quantity,Pure_Gold,Cash,Date from InventoryDetails where Supplier_Name='" + cmbSupplier.SelectedItem.ToString() + "' ";

                string sum1 = "select Sum(Item_Weight) from InventoryDetails where Supplier_Name='" + cmbSupplier.SelectedItem.ToString() + "'";
                string sum2 = "select Sum(Item_Quantity) from InventoryDetails where Supplier_Name='" + cmbSupplier.SelectedItem.ToString() + "'";
                //string query = "select sum( from ClientTransectionHistory where Customer_Name='" + cmbClient.SelectedItem.ToString() + "' ";
                string sum3 = "select Sum(Pure_Gold) from InventoryDetails where Supplier_Name='" + cmbSupplier.SelectedItem.ToString() + "'";

                string sum4 = "select Sum(Cash) from InventoryDetails where Supplier_Name='" + cmbSupplier.SelectedItem.ToString() + "'";


                command = new SqlCommand(query, con);

                reader = command.ExecuteReader();
                dt.Load(reader);

                command = new SqlCommand(sum1, con);
                 obj=(command.ExecuteScalar());
                lblItm.Text = obj.ToString();

                command = new SqlCommand(sum2, con);
                obj = (command.ExecuteScalar());
                lblQuantity.Text = obj.ToString();

                command = new SqlCommand(sum3, con);
                obj = (command.ExecuteScalar());
                lblPurGold.Text = obj.ToString();

                command = new SqlCommand(sum4, con);
                obj = (command.ExecuteScalar());
                lblCash.Text = obj.ToString();

                dataGridView2.DataSource = dt;



            }

            return name;
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        void GetSupplierName()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Distinct Name from Supplier";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbSupplier.Items.Add(reader.GetString(0));

                }
                co = cmbSupplier.Items.Count;
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }

        }
        void GetClientNameSearch()
        {
            try
            {
                int i = 0;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select Name from Supplier";
                SqlCommand command = new SqlCommand(query, con);
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    collection[i] = (reader.GetString(0));
                    i++;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error Occured!");
            }
        }
    }
}
