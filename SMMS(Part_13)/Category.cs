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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMMS_Part_13_
{
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True");
        public Category()
        {
            InitializeComponent();
            DisplayRec();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Cat_id.Text) || string.IsNullOrWhiteSpace(Cat_Name.Text) || string.IsNullOrWhiteSpace(Cat_Discription.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into  List (Cat_id, Cat_Name, Cat_Discription) Values (@Cat_id, @Cat_Name, @Cat_Discription)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Cat_id", Cat_id.Text);
                    cmd.Parameters.AddWithValue("@Cat_Name", Cat_Name.Text);
                    cmd.Parameters.AddWithValue("@Cat_Discription", Cat_Discription.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Add Sucessfully..........");
                    DisplayRec();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from List";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cat_id.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Cat_Name.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Cat_Discription.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cat_id.Text) || string.IsNullOrWhiteSpace(Cat_Name.Text) || string.IsNullOrWhiteSpace(Cat_Discription.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update List set  Cat_Name=@Cat_Name, Cat_Discription=@Cat_Discription where Cat_id=@Cat_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Cat_id", Cat_id.Text);
                    cmd.Parameters.AddWithValue("@Cat_Name", Cat_Name.Text);
                    cmd.Parameters.AddWithValue("@Cat_Discription", Cat_Discription.Text);
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
            if (string.IsNullOrWhiteSpace(Cat_id.Text))
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM List WHERE Cat_id = @Cat_id"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Cat_id", Cat_id.Text); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete List Items....");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Show();
            this.Hide();
        }
    }
}
