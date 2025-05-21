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
    public partial class dashboardPanel : UserControl
    {
        public dashboardPanel()
        {
            InitializeComponent();
            LoadServiceInformation();
            LoadDashboardStats();
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

        private void dashboardPanel_Load(object sender, EventArgs e)
        {

        }

        private void addServiceBtn_Click_1(object sender, EventArgs e)
        {
            customerInfoForm customerForm = new customerInfoForm();
            customerForm.ShowDialog();
        }

        private void LoadServiceInformation()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM service_information LIMIT 9";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    serviceHistoryView.DataSource = dt;
                    serviceHistoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service information: " + ex.Message);
            }
        }

        private void serviceHistoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < serviceHistoryView.Rows.Count)
            {
                DataGridViewRow row = serviceHistoryView.Rows[e.RowIndex];

                string company = row.Cells["vehicle_company"].Value?.ToString() ?? string.Empty;
                string model = row.Cells["vehicle_model"].Value?.ToString() ?? string.Empty;
                string year = row.Cells["model_year"].Value?.ToString() ?? string.Empty;
                string customerFName = row.Cells["customer_FName"].Value?.ToString() ?? string.Empty;
                string customerLName = row.Cells["customer_LName"].Value?.ToString() ?? string.Empty;
                string service = row.Cells["service_acquired"].Value?.ToString() ?? string.Empty;
            }
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    // Total Customers
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM customers", conn))
                    {
                        int totalCustomers = Convert.ToInt32(cmd.ExecuteScalar());
                        totalCustomerLabel.Text = totalCustomers.ToString();
                    }

                    // Total Bookings
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM bookings", conn))
                    {
                        int totalBookings = Convert.ToInt32(cmd.ExecuteScalar());
                        totalBookingsLabel.Text = totalBookings.ToString();
                    }

                    // Total Company Expenses
                    using (var cmd = new MySqlCommand("SELECT SUM(total_salary_expenses) FROM company_expenses", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal totalExpenses = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        totalExpensesLabel.Text = "₱ " + totalExpenses.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message);
            }
        }


        private void totalCustomerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalExpensesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalBookingsPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void reportList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
