using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InventoryManagement
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristina\Documents\Invetorydb.mdf;Integrated Security=True;Connect Timeout=30");
        
        void fillcategory()
        {
            string query = "select * from Categorytable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                categoryCombo.ValueMember = "CategoryName";
                categoryCombo.DataSoruce = dt;
                Con.Close();
            }
            catch
            {

            }

        }
        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void telephoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();

      
        }
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
                productGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Producttable values('" + productIDBox.Text + "','" + productNameBox.Text + "','" + productQuantityBox.Text + "' ,'" + productPriceBox.Text + "' ,'" + productDescriptionBox.Text + "','" + categoryCombo.SelectedValue.ToString() +  "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update Producttable values('" + productIDBox.Text + "','" + productNameBox.Text + "','" + productQuantityBox.Text + "','" + productPriceBox.Text + "','" + productDescriptionBox.text + categoryCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void productGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productIDBox.Text = productGV.SelectedRows[0].Cells[0].Value.ToString();
            productNameBox.Text = productGV.SelectedRows[0].Cells[1].Value.ToString();
            productQuantityBox.Text = productGV.SelectedRows[0].Cells[2].Value.ToString();
            productPriceBox.Text = productGV.SelectedRows[0].Cells[3].Value.ToString();
            productDescriptionBox.Text = productGV.SelectedRows[0].Cells[4].Value.ToString();
            categoryCombo.SelectedValue = productGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (productIDBox.Text == "")
            {
                MessageBox.Show("Enter the products Id number: ");
            }
            else
            {
                Con.Open();
                string query = "delete from Producttable where ProductID = '" + productIDBox.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Succesfully Deleted!!");
                Con.Close();
                populate();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
