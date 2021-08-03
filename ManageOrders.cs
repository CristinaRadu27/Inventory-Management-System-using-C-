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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristina\Documents\Invetorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Producttable ";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customerGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch
            {

            }
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;
        int flag = 0;
        int stock;


        void PopulateProducts()
        {
            try
            {
                Con.Open();
                string query = "select * from Producttable ";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                productGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch
            {

            }
        }
        private void CustomerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustID.Text = customerGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellCancelEventArgs e)
        {
            product = productGV.SelectedRows[0].Cells[1].Value.ToString();
            qty = Convert.ToInt32(QauntityBox.Text);
            stock = Convert.ToInt32(productGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(productGV.SelectedRows[0].Cells[3].Value.ToString());
            totprice = qty * uprice;
            flag = 1;
        }
        void fillCategory()
        {
            string query = "select * from Categorytable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.dataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();

            }
            catch
            {

            }
        }

        void updateProduct()
        {
            Con.Open();
            int ID = Convert.ToInt32(productGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQuantity = stock - Convert.ToInt32(quantityBox.Text);
            if (newQuantity < 0)
            {
                MessageBox.Show("Operation failed!");

            }
            else
            {
                Con.Open();
                string quety = "update Producttable set ProductQuantity = " + newQuantity + "where ProductID = " + ID + ";";
                SqlCommand cmd = SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                PopulateProducts();
            }
        }


        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            PopulateProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (quantityBox.Text == "")
            {
                MessageBox.Show("Enter the Quantity of Products");

            }
            else if (flag == 0)
            {

                MessageBox.Show("Select The Product");
            }
            else if (Convert.ToInt32(Convert.ToInt32(quantityBox.Text)) > stock)
            {
                MessageBox.Show("Not Enough Stock Available!");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(quantityBox.Text);
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSoruce = table;
                flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = "Rs" sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OrderIDTable.text == "" || CustomerID == "" || CustomerName.Text == "" || TotalAmount.Text == "")
            {
                MessageBox.Show("Fill the data correctly!");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Ordertable values('" + OrderIDBox.Text + "','" + CustomerIDBox.Text + "','" + customerNameBox + "','" + OrderDateBox.Text + "','" + ToatalAmountBox.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfully Added!");
                    Con.Close();
                   // populate();
                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
