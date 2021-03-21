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
    public partial class ClientStatement : Form
    {
        object obj;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        DataTable dt;
        SqlCommand command;
        SqlConnection con;
        SqlDataReader reader;
        string[] collection;
        int co;

        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();
        private string stringToPrint;

        private string documentContents;
        public ClientStatement()
        {
            InitializeComponent(); printDocument1.PrintPage +=
            new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void ClientStatement_Load(object sender, EventArgs e)
        {
            listBoxCustName.Visible = false;
            GetClientName();
            collection = new string[co];
            lblDate.Text = DateTime.Now.ToShortDateString();
            GetClientNameSearch();

            
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetName(cmbClient.SelectedItem.ToString()); StyleInventoryGrid();
            listBoxCustName.Visible = false;
            using (con = new SqlConnection(conn))
            {
                string select = "select Balance_Cash from Client where Customer_Name='" + cmbClient.SelectedItem.ToString() + "'";

                command = new SqlCommand(select,con);
                con.Open();
                reader= command.ExecuteReader();
                while(reader.Read())
                {
                    lblCash.Text = reader.GetValue(0).ToString();
                }


            }
        }
        void GetClientName()
        {
                try
                {
                    SqlConnection con = new SqlConnection(conn);
                    con.Open();
                    string query = "select Distinct Client_Name from Purchase";
                    SqlCommand command = new SqlCommand(query, con);
                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbClient.Items.Add(reader.GetString(0));

                    }
              co=  cmbClient.Items.Count;
                    con.Close();
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }

        }

        private void listBoxCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClient.SelectedItem = listBoxCustName.SelectedItem;
            SetName(cmbClient.SelectedItem.ToString());
            listBoxCustName.Visible = false;
        }
        string SetName(string name)
        {
            try
            {
                con = new SqlConnection(conn);
                con.Open();
                string query = "select * from Client where Customer_Name='" + cmbClient.SelectedItem.ToString() + "' ";
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
                string sum1 = "select Sum(Sold_Weight) from Purchase where Client_Name='" + cmbClient.SelectedItem.ToString() + "'";
                string sum2 = "select Sum(Sold_Quantity) from Purchase where Client_Name='" + cmbClient.SelectedItem.ToString() + "'";
                //string query = "select sum( from ClientTransectionHistory where Customer_Name='" + cmbClient.SelectedItem.ToString() + "' ";
                string sum3 = "select Sum(Pure_Gold) from Purchase where Client_Name='" + cmbClient.SelectedItem.ToString() + "'";

                string sum4 = "select Sum(Cash_Amount) from Purchase where Client_Name='" + cmbClient.SelectedItem.ToString() + "'";
                string query = "select Client_Name,Product_Name,Sold_Quantity,Sold_Weight,Cash_Amount,Pure_Gold,Purchase_Date,Labour,Client_Transection from Purchase where Client_Name='" + cmbClient.SelectedItem.ToString() + "' ";
                //string query = "select sum( from ClientTransectionHistory where Customer_Name='" + cmbClient.SelectedItem.ToString() + "' ";
                command = new SqlCommand(query, con);

                reader = command.ExecuteReader();
              



                dt.Load(reader);
                dt.Columns["Client_Name"].ColumnName = "Name";
                dt.Columns["Sold_Quantity"].ColumnName = "Quantity";
                dt.Columns["Sold_Weight"].ColumnName = "Weight";
                dt.Columns["Cash_Amount"].ColumnName = "Cash";
                dt.Columns["Purchase_Date"].ColumnName = "Date";


                command = new SqlCommand(sum1, con);
                obj = (command.ExecuteScalar());
                lblItm.Text = obj.ToString();

                command = new SqlCommand(sum2, con);
                obj = (command.ExecuteScalar());
                lblQuantity.Text = obj.ToString();

                command = new SqlCommand(sum3, con);
                obj = (command.ExecuteScalar());
                 lblPurGold.Text = (Convert.ToDouble(String.Format("{0:#,##0.000;(#,##0.000);Zero}", obj))).ToString(); 
                
               

                command = new SqlCommand(sum4, con);
                obj = (command.ExecuteScalar());
                lblCash.Text = obj.ToString();
                dataGridView2.DataSource = dt;


            }
            return name;
        }

        private void cmbClient_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cmbClient.Text.ToLower();
            listBoxCustName.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox hidden if the keyword is empty
                        //search
            string[] result = (from j in collection
                               where j.ToLower().Contains(textToSearch)
                               select j).ToArray();
            if (result.Length == 0)
                return; // return with listbox hidden if nothing found

            listBoxCustName.Items.Clear(); // remember to Clear before Add
            listBoxCustName.Items.AddRange(result);
            listBoxCustName.Visible = true; // show the
        }
        void GetClientNameSearch()
        {
            try
            {
                int i = 0;
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                string query = "select distinct Client_Name from Purchase";
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
        void StyleInventoryGrid()
        {
     //       dataGridView2.ColumnHeadersDefaultCellStyle.Font =
     //new Font("Microsoft Sans Serif", 11f, FontStyle.Bold);
            dataGridView2.Columns["Client_Transection"].Width = 130;
            //dataGridView2.Columns["Client_ID"].Width = 140;
            //dataGridView2.Columns["Cash_Amount"].Width = 120;
            //dataGridView2.Columns["Client_Name"].Width = 130;
            dataGridView2.Columns["Pure_Gold"].Width = 130;
            //dataGridView2.Columns["Sold_Quantity"].Width = 130;
            //dataGridView2.Columns["Sold_Weight"].Width = 130;

            //DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            //boldStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);




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

       
    }
}
