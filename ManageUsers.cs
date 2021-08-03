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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristina\Documents\Invetorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    
            
            userNameBox.Text = userGV.SelectedRows[0].Cells[0].Value.ToString();
            fullnameBox.Text = userGV.SelectedRows[0].Cells[1].Value.ToString();
            passwordBox.Text = userGV.SelectedRows[0].Cells[2].Value.ToString();
            telephoneBox.Text = userGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void label2_Click( object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Usertable ";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                userGV.DataSource = ds.Tables[0];
                Con.Close();
                
                    
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Usertable values('" + userNameBox.Text + "','" + fullnameBox.Text + "','" + passwordBox.Text + "','" + telephoneBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" User Successfully Added!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(telephoneBox.Text == "")
            {
                MessageBox.Show("Enter the users Phone Number: ");
            }
            else
            {
                Con.Open();
                string query = "delete from Usertable where UPhonenumber = '" + telephoneBox.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted!");
                Con.Close();
                populate();
            }
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update Usertable values('" + userNameBox.Text + "','" + fullnameBox.Text + "','" + passwordBox.Text + "','" + telephoneBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" User Successfully Updated!");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
    }
}
