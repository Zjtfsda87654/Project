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
using System.Security.Cryptography;
using Guna.UI.WinForms;

namespace SMMS_Part_13_
{
    public partial class Product : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True");
        public Product()
        {
            InitializeComponent();
            pop();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillcombo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Cat_Name FROM List", conn);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Cat_Name", typeof(string));
                    dt.Load(rdr);

                    Cat_Cb.ValueMember = "Cat_Name";
                    Cat_Cb.DisplayMember = "Cat_Name"; // Set DisplayMember if needed
                    Cat_Cb.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (you can log it, display an error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillcombo();
        }
        private void pop()
        {
            try
            {
                conn.Open();
                string query = "Select * from Prod";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                var ds = new DataSet();
                DataTable dataTable = new DataTable();
                sda.Fill(ds);
                gunaDataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pro_id.Text) || string.IsNullOrWhiteSpace(Pro_Name.Text) || string.IsNullOrWhiteSpace(Pro_Quant.Text) || string.IsNullOrWhiteSpace(Pro_Price.Text) || string.IsNullOrWhiteSpace(Cat_Cb.SelectedValue.ToString()))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Insert into  Prod  (Pro_id, Pro_Name ,Pro_Quant ,Pro_Price, Cat_Cb) Values (@Pro_id, @Pro_Name, @Pro_Quant, @Pro_Price, @Cat_Cb)";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Pro_id", Pro_id.Text);
                    com.Parameters.AddWithValue("@Pro_Name", Pro_Name.Text);
                    com.Parameters.AddWithValue("@Pro_Quant", Pro_Quant.Text);
                    com.Parameters.AddWithValue("@Pro_Price", Pro_Price.Text);
                    com.Parameters.AddWithValue("@Cat_Cb", Cat_Cb.Text);                   
                    com.ExecuteNonQuery();
                    MessageBox.Show("Infromation Update Sucessfully......");
                    conn.Close();
                    pop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pro_id.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Pro_Name.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Pro_Quant.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Pro_Price.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();   
            Cat_Cb.SelectedValue = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pro_id.Text) || string.IsNullOrWhiteSpace(Pro_Name.Text) || string.IsNullOrWhiteSpace(Pro_Quant.Text) || string.IsNullOrWhiteSpace(Pro_Price.Text) || string.IsNullOrWhiteSpace(Cat_Cb.SelectedValue.ToString()))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Update Prod set Pro_Name=@Pro_Name  , Pro_Quant= @Pro_Quant, Pro_Price=@Pro_Price, Cat_Cb=@Cat_Cb where Pro_id= @Pro_id";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Pro_Name", Pro_Name.Text);
                    com.Parameters.AddWithValue("@Pro_Quant", Pro_Quant.Text);
                    com.Parameters.AddWithValue("@Pro_Price", Pro_Price.Text);
                    com.Parameters.AddWithValue("@Cat_Cb", Cat_Cb.Text);
                    com.Parameters.AddWithValue("@Pro_id", Pro_id.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Infromation Update Sucessfully......");
                    conn.Close();
                    pop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Pro_id.Text == "")
            {
                MessageBox.Show("Fill the Information........");
            }
                else
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Prod WHERE Pro_id = @Pro_id"; // Corrected parameter name
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Pro_id", Pro_id); // Use the correct parameter name here
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Delete Product....");
                        pop();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Selr sel = new Selr();
            sel.Show();
            this.Hide();
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cat_Cb.SelectedItem != null)
            {
                if (Cat_Cb.SelectedValue != null)
                {
                    string selectedValue = Cat_Cb.SelectedValue.ToString();

                    if (!string.IsNullOrEmpty(selectedValue))
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True"))
                        {
                            conn.Open();
                            string query = "SELECT * FROM Prod WHERE Cat_Cb = @selectedValue";

                            // Use SqlCommand and SqlParameter to create a parameterized query
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@selectedValue", selectedValue);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            var ds = new DataSet();
                            sda.Fill(ds);

                            gunaDataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                    else
                    {
                        // Handle the case where SelectedValue is empty or null
                    }
                }
                else
                {
                    // Handle the case where SelectedValue itself is null
                }
            }
            else
            {
                // Handle the case where SelectedItem is null
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            pop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selr sel = new Selr();
            sel.Show();
            this.Hide();
        }

    }
}
