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
    public partial class dashboardPanel : UserControl
    {
        public dashboardPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardPanel_Load(object sender, EventArgs e)
        {

        }

        private void addServiceBtn_Click_1(object sender, EventArgs e)
        {
            customerInfoForm customerForm = new customerInfoForm();
            customerForm.ShowDialog();
        }

        private void addBookingBtn_Click_1(object sender, EventArgs e)
        {
            bookingForm bookingForm = new bookingForm();
            bookingForm.ShowDialog();
        }
    }
}
