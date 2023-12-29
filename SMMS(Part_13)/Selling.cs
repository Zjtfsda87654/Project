using Guna.UI.WinForms;
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

namespace SMMS_Part_13_
{
    public partial class Selling : Form
    {
        int grdtotal;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True");
        public Selling()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            Bill_Date.Text = DateTime.Now.ToString() + "/" + DateTime.Today.Month.ToString();
            Sellernamee.Text = Form1.Seller_Name;
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pro_Name.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Pro_Price.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            flag = 1;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pop()
        {
            try
            {
                conn.Open();
                string query = "Select Pro_Name, Pro_Price from Prod";
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
        private void popBill()
        {
            try
            {
                conn.Open();
                string query = "Select * from Bill";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                var ds = new DataSet();
                DataTable dataTable = new DataTable();
                sda.Fill(ds);
                gunaDataGridView2.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int gradetotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming Pro_Price and Pro_Qunat are TextBox controls containing price and quantity respectively

            if (Pro_Name.Text == "" || Pro_Qunat.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int price = Convert.ToInt32(Pro_Price.Text);
                int quantity = Convert.ToInt32(Pro_Qunat.Text);
                int totalPrice = price * quantity;
                Guna.UI.WinForms.GunaDataGridView data = OrderGDV;
                int rowIndex = data.Rows.Add(); // Adding a new row directly and getting its index
                DataGridViewRow row = data.Rows[rowIndex];

                row.Cells[0].Value = rowIndex + 1; // Incremented index for display
                row.Cells[1].Value = Pro_Name.Text;
                row.Cells[2].Value = quantity.ToString(); // Displaying price
                row.Cells[3].Value = price.ToString(); // Displaying quantity
                row.Cells[4].Value = totalPrice; // Assigning the calculated total for this product

                if (!OrderGDV.Rows.Contains(row))
                {
                    // Add the row to the DataGridView
                    OrderGDV.Rows.Add(row);
                }

                gradetotal = gradetotal + totalPrice; // Add the current product's total to the overall accumulated total
                Amount.Text = "Rs: " + gradetotal; // Update the label with the accumulated total  
            }

        }
        private void Selling_Load(object sender, EventArgs e)
        {
            pop();
            popBill();
            fillcombo();
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Bill_id.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Bill (Bill_id, Seller_Name, Amount, Bill_Date) VALUES (@Bill_id, @Seller_Name, @Amount, @Bill_Date)";

                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Bill_id", Bill_id.Text);
                    com.Parameters.AddWithValue("@Seller_Name", Sellernamee.Text);
                    // Convert the text to an integer before assigning it to the parameter
                    int totalAmount = 0;
                    if (int.TryParse(Amount.Text.Replace("Rs: ", ""), out totalAmount))
                    {
                        com.Parameters.AddWithValue("@Amount", totalAmount);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Amount"); // Notify the user if conversion fails
                    }
                    com.Parameters.AddWithValue("@Bill_Date", Bill_Date.Text);
                    com.ExecuteNonQuery();
                    conn.Close();
                    popBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int flag = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILY SUPERMARKET SYSTEM", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.DarkRed, new Point(230));
            e.Graphics.DrawString("Bill_ID: " + gunaDataGridView2.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 70));
            e.Graphics.DrawString("Seller_Name: " + gunaDataGridView2.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            e.Graphics.DrawString("Amount: " + gunaDataGridView2.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("Bill_Date: " + gunaDataGridView2.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.DarkRed, new Point(270, 230));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pop();
        }

        private void Cat_Cb_SelectionChangeCommitted(object sender, EventArgs e)
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
                            string query = "SELECT Pro_Name, Pro_Quant FROM Prod WHERE Cat_Cb = @selectedValue";

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
        private void fillcombo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Cat_Name from List", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Cat_Name", typeof(string));
            dt.Load(rdr);
            Cat_Cb.ValueMember = "Cat_Name";
            Cat_Cb.DataSource = dt;
            conn.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

    }
}
