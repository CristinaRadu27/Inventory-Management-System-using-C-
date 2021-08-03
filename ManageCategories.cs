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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristina\Documents\Invetorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from Categorytable ";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                categoryGV.DataSource = ds.Tables[0];
                Con.Close();


            }
            catch
            {

            }
        }

            private void label3_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

            


            private void button1_Click(object sender, EventArgs e)
        {
             try
                {
                 Con.Open();
                 SqlCommand cmd = new SqlCommand("Insert into Categorytable values('" + categoryIDBox.Text + "','" + categoryNameBox.Text +  "')", Con);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Category Successfully Added!");
                 Con.Close();
                 populate();
                }
              catch
              {

              }

        }
       


        private void deleteCategoryButton_Click(object sender, EventArgs e)
                {
                    if (categoryIDBox.Text == "")
                    {
                        MessageBox.Show("Enter the category's Id number: ");
                    }
                    else
                    {
                        Con.Open();
                        string query = "delete from Categorytable where CategoryID = '" + categoryIDBox.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Successfully Deleted!");
                        Con.Close();
                        populate();
                    }
                }

        private void categoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryIDBox.Text = categoryGV.SelectedRows[0].Cells[0].Value.ToString();
            categoryNameBox.Text = categoryGV.SelectedRows[0].Cells[1].Value.ToString();
        }


        private void editCategoryButton_Click(object sender, EventArgs e)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Categorytable values('" + categoryIDBox.Text + "','" + categoryNameBox.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated!");
                    Con.Close();
                    populate();
                }
                catch
                {

                }
            }
         private button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        }
}
