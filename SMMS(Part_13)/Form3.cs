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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=SMMSPro;Integrated Security=True");
        private static string Sellernamee = "";
        public string Seller_Name { get; private set; }
        public static string Seller_namee { get; internal set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == " " || Username.Text == " " || Email.Text == " " || Password.Text == " ")
            {
                MessageBox.Show("Please Enter all Fields.....");
            }
            else
            {

                try
                {
                    con.Open();

                    string checkusername = "SELECT * FROM Signup WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(checkusername, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show(Username.Text + "Try Again! Enter Info....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertdata = "INSERT INTO Signup (FirstName, Username, Email, Password) VALUES (@FirstName, @Username, @Email, @Password)";
                            using (SqlCommand cmdd = new SqlCommand(insertdata, con))
                            {
                                cmdd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                                cmdd.Parameters.AddWithValue("@Username", Username.Text);
                                cmdd.Parameters.AddWithValue("@Email", Email.Text);
                                cmdd.Parameters.AddWithValue("@Password", Password.Text);
                                cmdd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 sel = new Form1();
                                sel.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }         
        }

        private void signup_show_CheckedChanged(object sender, EventArgs e)
        {
                if (signup_show.Checked)
                {
                    Password.PasswordChar = '\0';
                }
                else
                {
                    Password.PasswordChar = '*';
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
