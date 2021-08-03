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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristina\Documents\Invetorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Customertable ";
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Customertable values('" + customerIDBox.Text + "','" + customerNameBox.Text + "','" + customerPhoneBox + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (customerIDBox.Text == "")
            {
                MessageBox.Show("Enter the customers Id number: ");
            }
            else
            {
                Con.Open();
                string query = "delete from Customertable where CustomerID = '" + customerIDBox.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted!");
                Con.Close();
                populate();
            }
        }

        private void customerGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIDBox.Text = customerGV.SelectedRows[0].Cells[0].Value.ToString();
            customerNameBox.Text = customerGV.SelectedRows[0].Cells[1].Value.ToString();
            customerPhoneBox.Text = customerGV.SelectedRows[0].Cells[2].Value.ToString();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Count(*) from Ordertable where CustomerID =" + customerID.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda1 = new SqlDataAdapter(" select Sum(TotalAmount) from Ordertable where CustomerID =" + customerID.Text + "", Con);
            
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Enabled.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter(" select Max(OrderDate) from Ordertable where CustomerID =" + customerID.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda1.Fill(dt2);
            DateLabel.Enabled.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update Customertable values('" + customerIDBox.Text + "','" + customerNameBox.Text + "','" + customerPhoneBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customerNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
