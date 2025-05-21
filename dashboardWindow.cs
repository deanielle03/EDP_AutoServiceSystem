using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Auto_Service
{
    public partial class dashboardWindow : Form
    {
        public dashboardWindow()
        {
            InitializeComponent();
            loadUserControl(new dashboardPanel());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your logic here
        }
        private void recordsForm_Load(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadUserControl(new dashboardPanel());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Navigate back to login screen
            this.Hide();  // Hides the main form
            Login loginForm = new Login();
            loginForm.Show();
        }

        customerInfoForm customerForm = new customerInfoForm();

        private void loadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }


        private void recordsBtn_Click(Object sender, EventArgs e)
        {
            loadUserControl(new recordsManagement());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serviceHistoryBtn_Click(object sender, EventArgs e)
        {
            loadUserControl(new serviceHistory());
        }

        private void bookingQBtn_Click(object sender, EventArgs e)
        {
            loadUserControl(new booking());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            loadUserControl(new productsManagement());
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            loadUserControl(new employeeManagement());
        }
    }
}
