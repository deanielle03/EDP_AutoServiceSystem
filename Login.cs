using System;
using System.Collections.Generic;
using System.Linq;
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

        private void lgnbtn_Click(object sender, EventArgs e)
        {

            // Hide the login form
            this.Hide();

            // Create and show the dashboard form
            dashboardWindow dashboard = new dashboardWindow();
            dashboard.FormClosed += (s, args) => this.Close(); // Ensures app closes when dashboard is closed
            dashboard.Show();

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
    }
}
