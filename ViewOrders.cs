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

namespace InventoryManagement
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristina\Documents\Invetorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void PopulateOrders()
        {
            try
            {
                Con.Open();
                string query = "select * from Orderstable ";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ordersGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch
            {

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            PopulateOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ordersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventHandler e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold),Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order ID: " + ordersGV.SelectedRows[0].Cells[0].ToString(), new Font("Century", 25, FontStyle.Regular),Brushes.Red, new Point(80,100));
            e.Graphics.DrawString("Customer ID: " + ordersGV.SelectedRows[0].Cells[1].ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Red, new Point(80, 140));
            e.Graphics.DrawString("Customer Name : " + ordersGV.SelectedRows[0].Cells[2].ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Red, new Point(80, 160));
            e.Graphics.DrawString("Order Date: " + ordersGV.SelectedRows[0].Cells[3].ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Red, new Point(80, 180));
            e.Graphics.DrawString("Total Amount: " + ordersGV.SelectedRows[0].Cells[4].ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Red, new Point(80, 200));
            e.Graphics.DrawString("CR", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));

        }

    }
}
