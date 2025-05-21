using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Service
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            string loginInput = username.Text.Trim();    // Username or email
            string passwordInput = password.Text.Trim(); // Raw password

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT password FROM users WHERE username = @loginInput";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@loginInput", loginInput);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string storedPassword = reader.GetString("password");

                        if (passwordInput == storedPassword)
                        {
                            MessageBox.Show("Login successful!");

                            this.Hide();
                            dashboardWindow dashboard = new dashboardWindow();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or email.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransparentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordReset PasswordReset = new PasswordReset();
            PasswordReset.Show();
        }
    }
}
