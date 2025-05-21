using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Service
{
    public partial class PasswordReset : Form
    {
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void Password_Reset_Load(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text.Trim();
            string newPassword = newPasswordBox.Text.Trim();
            string confirmPassword = confPasswordBox.Text.Trim();

            // Check if email is valid and fields are filled
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Check if new password and confirmation password match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new password and confirmation password do not match.");
                return;
            }

            // Check if email exists in the database
            if (EmailExistsInDatabase(email))
            {

                // Update the password in the database
                UpdatePasswordInDatabase(email, newPassword);

                MessageBox.Show("Password has been successfully reset.");
            }
            else
            {
                MessageBox.Show("Email does not exist in the system.");
            }
        }
        private bool EmailExistsInDatabase(string email)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE email = @email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int userExists = Convert.ToInt32(cmd.ExecuteScalar());
                    return userExists > 0;
                }
            }
        }

        private void UpdatePasswordInDatabase(string email, string newPassword)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE users SET password = @password WHERE email = @email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@password", newPassword);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void confPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
