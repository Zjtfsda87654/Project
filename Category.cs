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

namespace SMMS_part_11_
{
    public partial class Category : Form
    {
        /*public Category()
        {
           InitializeComponent();
        }*/

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\Zohaib.mdf;Integrated Security=True;Connect Timeout=30");

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Category (CatId, CatName, CatDiscp) VALUES (@CatId, @CatName, @CatDiscp)";

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@CatId", CatId.Text);
                com.Parameters.AddWithValue("@CatName", CatName.Text);
                com.Parameters.AddWithValue("@CatDiscp", CatDiscp.Text);

                com.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                //populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            try
            {
                con.Open();
                string query = "Select * from Category";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                sda.Fill(ds);
                gunaDataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Category()
        {
            InitializeComponent();
            populate(); // Call populate() here to load data when the form is initialized
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CatDiscp.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatId.Text == "")
                {
                    MessageBox.Show("Select the Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM Category WHERE CatId = @CatId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CatId", CatId.Text);
                    cmd.BeginExecuteNonQuery();
                    MessageBox.Show("Category Delete Sucessfully");
                    con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId.Text == "" || CatName.Text == "" || CatDiscp.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Your_Connection_String"))
                    {
                        con.Open();
                        string query = "UPDATE Category SET CatName=@CatName, CatDiscp=@CatDiscp WHERE CatId=@CatId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@CatName", CatName.Text);
                        cmd.Parameters.AddWithValue("@CatDiscp", CatDiscp.Text);
                        cmd.Parameters.AddWithValue("@CatId", CatId.Text);
                        cmd.BeginExecuteNonQuery();
                        MessageBox.Show("Category Successfully Updated");
                        con.Close();
                    }
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

    }
}
