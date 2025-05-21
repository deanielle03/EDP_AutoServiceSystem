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
    public partial class recordsManagement : UserControl
    {
        public recordsManagement()
        {
            InitializeComponent();
            LoadCustomers();
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == customerstab)
            {
                LoadCustomers();
            }
            else if (tabControl.SelectedTab == expensestab)
            {
                LoadExpenses();
            }
            else if (tabControl.SelectedTab == repairstab)
            {
                LoadRepairs();
            }
            else if (tabControl.SelectedTab == servicestab)
            {
                LoadServices();
            }
            else if (tabControl.SelectedTab == vehiclestab)
            {
                LoadVehicles();
            }
        }


        private void recordsManagement_Load(object sender, EventArgs e)
        {

        }
        private void LoadCustomers()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM customers";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    customersView.DataSource = dt;
                    customersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        private void LoadExpenses()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM company_expenses";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    expensesView.DataSource = dt;
                    expensesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading repairs: " + ex.Message);
            }
        }

        private void LoadRepairs()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM repairs";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    repairsView.DataSource = dt;
                    repairsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading repairs: " + ex.Message);
            }
        }


        private void LoadServices()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM services";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    servicesView.DataSource = dt;
                    servicesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
        }

        private void LoadVehicles()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM vehicles";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    vehiclesView.DataSource = dt;
                    vehiclesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
        }


        private void customersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersView.Rows[e.RowIndex];

                // Extract column values
                string customerId = row.Cells["customer_id"].Value?.ToString();
                string firstName = row.Cells["first_name"].Value?.ToString();
                string lastName = row.Cells["last_name"].Value?.ToString();
                string phone = row.Cells["phone_number"].Value?.ToString();
                string email = row.Cells["email"].Value?.ToString();
                string address = row.Cells["address"].Value?.ToString();
            }
        }

        private void expensesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = expensesView.Rows[e.RowIndex];

                // Extract column values
                string expenseId = row.Cells["id"].Value?.ToString();
                string expenseName = row.Cells["expense_name"].Value?.ToString();
                string totalSalary = row.Cells["total_salary_expenses"].Value?.ToString();
            }
        }

        private void repairsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = repairsView.Rows[e.RowIndex];

            // Extract column values
            string repairId = row.Cells["repair_id"].Value?.ToString();
            string vehicleId = row.Cells["vehicle_id"].Value?.ToString();
            string repairDate = row.Cells["repair_date"].Value?.ToString();
            string technicianId = row.Cells["technician_id"].Value?.ToString();
        }

        private void servicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = servicesView.Rows[e.RowIndex];

            // Extract column values
            string serviceId = row.Cells["service_id"].Value?.ToString();
            string serviceName = row.Cells["service_name"].Value?.ToString();
            string serviceCost = row.Cells["service_cost"].Value?.ToString();
            string serviceDuration = row.Cells["service_duration"].Value?.ToString();
        }

        private void vehiclesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = vehiclesView.Rows[e.RowIndex];

            // Extract column values
            string vehicleId = row.Cells["vehicle_id"].Value?.ToString();
            string customerId = row.Cells["customer_id"].Value?.ToString();
            string make = row.Cells["make"].Value?.ToString();
            string model = row.Cells["model"].Value?.ToString();
            string year = row.Cells["year"].Value?.ToString();
            string vin = row.Cells["vin"].Value?.ToString();
        }

        private void repairsView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
