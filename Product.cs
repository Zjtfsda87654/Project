using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMMS_part_11_
{
    public partial class Product : Form
    {

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\Zohaib.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillCombo()
        {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CatName FROM Category", con); // Assuming Category table has CatName
                    SqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CatName", typeof(string));
                    dt.Load(rdr);

                    ProdCat.ValueMember = "CatName";
                    ProdCat.DataSource = dt;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }
        private void Product_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void Cat_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Product (ProdId, ProdName, ProdPrice, ProdQuant, ProdCat) VALUES (@ProdId, @ProdName, @ProdPrice, @ProdQuant, @ProdCat)";

                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@ProdId", ProdId.Text); // Corrected parameter name
                    com.Parameters.AddWithValue("@ProdName", ProdName.Text);
                    com.Parameters.AddWithValue("@ProdPrice", ProdPrice.Text);
                    com.Parameters.AddWithValue("@ProdQuant", ProdQuant.Text);
                    com.Parameters.AddWithValue("@ProdCat", ProdCat.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully");
                    con.Close();
                populate();
                FillCombo();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
       private void populate()
        {
            try
            {
                con.Open();
                string query = "Select * from Product";
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

        public Product()
        {
            InitializeComponent();
            populate(); // Call populate() here to load data when the form is initialized
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ProdPrice.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ProdQuant.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ProdCat.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select the Product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM Product WHERE ProdId = @ProdId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProdId", ProdId.Text);
                    cmd.BeginExecuteNonQuery();
                    MessageBox.Show("Product Delete Sucessfully");
                    con.Close();
                    populate();
                    FillCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdPrice.Text == "" || ProdQuant.Text == "" || ProdCat.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Your_Connection_String"))
                    {
                        con.Open();
                        string query = "UPDATE Product SET ProdName=@ProdName, ProdPrice=@ProdPrice , ProdQuant=@ProdQuant , ProdCat=@ProdCat WHERE ProdId=@ProdId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ProdId", ProdId.Text);
                        cmd.Parameters.AddWithValue("@ProdName", ProdName.Text);
                        cmd.Parameters.AddWithValue("@ProdPrice", ProdPrice.Text);
                        cmd.Parameters.AddWithValue("@ProdQuant", ProdQuant.Text);
                        cmd.Parameters.AddWithValue("@ProdCat", ProdCat.Text);
                        cmd.BeginExecuteNonQuery();
                        MessageBox.Show("Product Successfully Updated");
                        con.Close();
                    }
                    populate();
                    FillCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

