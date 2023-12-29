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
    public partial class Selr : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True");
        public Selr()
        {
            InitializeComponent();
            DisplayRec();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }
        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from Buyer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Seller_id.Text) || string.IsNullOrWhiteSpace(Seller_Name.Text) || string.IsNullOrWhiteSpace(Seller_Account.Text) || string.IsNullOrWhiteSpace(Seller_Email.Text) || string.IsNullOrWhiteSpace(Seller_Password.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into  Buyer (Seller_id, Seller_Name, Seller_Account, Seller_Email, Seller_Password) Values (@Seller_id, @Seller_Name, @Seller_Account, @Seller_Email, @Seller_Password)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Seller_id", Seller_id.Text);
                    cmd.Parameters.AddWithValue("@Seller_Name", Seller_Name.Text);
                    cmd.Parameters.AddWithValue("@Seller_Account", Seller_Account.Text);
                    cmd.Parameters.AddWithValue("@Seller_Email", Seller_Email.Text);
                    cmd.Parameters.AddWithValue("@Seller_Password", Seller_Password.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Add Sucessfully..........");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Seller_id.Text) || string.IsNullOrWhiteSpace(Seller_Name.Text) || string.IsNullOrWhiteSpace(Seller_Account.Text) || string.IsNullOrWhiteSpace(Seller_Email.Text) || string.IsNullOrWhiteSpace(Seller_Password.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                Selling pro = new Selling();
                pro.Show();
                this.Hide();
            }          
        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seller_id.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Seller_Name.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Seller_Account.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Seller_Email.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Seller_Password.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Seller_id.Text) || string.IsNullOrWhiteSpace(Seller_Name.Text) || string.IsNullOrWhiteSpace(Seller_Account.Text) || string.IsNullOrWhiteSpace(Seller_Email.Text) || string.IsNullOrWhiteSpace(Seller_Password.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Buyer set  Seller_Name= @Seller_Name, Seller_Account=@Seller_Account, Seller_Email=@Seller_Email, Seller_Password=@Seller_Password where Seller_id=@Seller_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Seller_id", Seller_id.Text);
                    cmd.Parameters.AddWithValue("@Seller_Name", Seller_Name.Text);
                    cmd.Parameters.AddWithValue("@Seller_Account", Seller_Account.Text);
                    cmd.Parameters.AddWithValue("@Seller_Email", Seller_Email.Text);
                    cmd.Parameters.AddWithValue("@Seller_Password", Seller_Password.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Infromation Update Sucessfully......");
                    con.Close();
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Seller_id.Text))
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Buyer WHERE Seller_id = @Seller_id"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Seller_id", Seller_id.Text); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Customer Info....");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
