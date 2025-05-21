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
    public partial class customerInfoForm : Form
    {
        public customerInfoForm()
        {
            InitializeComponent();
            LoadServiceDropdown();
            LoadProductDropdown();
            LoadTechnicianDropdown();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadServiceDropdown()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DISTINCT service_name FROM services";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        serviceName.Items.Clear(); // Clear any existing items

                        while (reader.Read())
                        {
                            serviceName.Items.Add(reader.GetString("service_name"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service names: " + ex.Message);
            }
        }

        private Dictionary<string, (int productId, decimal productPrice)> productMap = new Dictionary<string, (int, decimal)>();

        private void LoadProductDropdown()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT product_id, product_name, product_price FROM products";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        productName.Items.Clear();
                        productMap.Clear();

                        while (reader.Read())
                        {
                            string name = reader.GetString("product_name");
                            int id = reader.GetInt32("product_id");
                            decimal price = reader.GetDecimal("product_price");

                            productName.Items.Add(name);
                            productMap[name] = (id, price);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product names: " + ex.Message);
            }
        }


        private Dictionary<string, int> technicianMap = new Dictionary<string, int>();

        private void LoadTechnicianDropdown()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT employee_id, CONCAT(first_name, ' ', last_name) AS full_name FROM employees WHERE role = 'technician'";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        technicianName.Items.Clear();
                        technicianMap.Clear();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32("employee_id");
                            string name = reader.GetString("full_name");

                            technicianName.Items.Add(name); // display name
                            technicianMap[name] = id;       // map name to ID
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading technician names: " + ex.Message);
            }
        }



        private void submitBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert into customers
                    string insertCustomerQuery = @"INSERT INTO customers 
                    (first_name, last_name, phone_number, email, address) 
                    VALUES (@first, @last, @phone, @email, @address)";

                    MySqlCommand customerCmd = new MySqlCommand(insertCustomerQuery, conn, transaction);
                    customerCmd.Parameters.AddWithValue("@first", fName.Text.Trim());
                    customerCmd.Parameters.AddWithValue("@last", lName.Text.Trim());
                    customerCmd.Parameters.AddWithValue("@phone", mobileNum.Text.Trim());
                    customerCmd.Parameters.AddWithValue("@email", emailText.Text.Trim());
                    customerCmd.Parameters.AddWithValue("@address", addressText.Text.Trim());
                    customerCmd.ExecuteNonQuery();

                    int customerId = (int)customerCmd.LastInsertedId;

                    // 2. Insert into vehicles
                    string insertVehicleQuery = @"INSERT INTO vehicles 
                    (customer_id, make, model, year, vin) 
                    VALUES (@custId, @make, @model, @year, @vin)";

                    MySqlCommand vehicleCmd = new MySqlCommand(insertVehicleQuery, conn, transaction);
                    vehicleCmd.Parameters.AddWithValue("@custId", customerId);
                    vehicleCmd.Parameters.AddWithValue("@make", manuText.Text.Trim());
                    vehicleCmd.Parameters.AddWithValue("@model", modelText.Text.Trim());
                    vehicleCmd.Parameters.AddWithValue("@year", int.Parse(yearText.Text.Trim()));
                    vehicleCmd.Parameters.AddWithValue("@vin", vinText.Text.Trim());
                    vehicleCmd.ExecuteNonQuery();

                    int vehicleId = (int)vehicleCmd.LastInsertedId;

                    // 3. Insert into repairs
                    if (technicianName.SelectedItem == null)
                    {
                        throw new Exception("Please select a technician.");
                    }

                    string selectedTechName = technicianName.SelectedItem.ToString();

                    if (!technicianMap.ContainsKey(selectedTechName))
                    {
                        throw new Exception("Selected technician is invalid.");
                    }

                    int technicianId = technicianMap[selectedTechName];

                    string insertRepairQuery = @"INSERT INTO repairs 
                    (vehicle_id, repair_date, technician_id) 
                    VALUES (@vehicleId, @repairDate, @techId)";

                    MySqlCommand repairCmd = new MySqlCommand(insertRepairQuery, conn, transaction);
                    repairCmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                    repairCmd.Parameters.AddWithValue("@repairDate", DateTime.Now);
                    repairCmd.Parameters.AddWithValue("@techId", technicianId);
                    repairCmd.ExecuteNonQuery();

                    int repairId = (int)repairCmd.LastInsertedId;

                    // 4. Insert into repairparts
                    string insertPartQuery = @"INSERT INTO repairparts 
                    (repair_id, product_id, quantity_used, product_total_cost) 
                    VALUES (@repairId, @productId, @quantityUsed, @totalCost)";

                    MySqlCommand partCmd = new MySqlCommand(insertPartQuery, conn, transaction);
                    partCmd.Parameters.AddWithValue("@repairId", repairId);

                    string selectedProductName = productName.SelectedItem.ToString();
                    int quantityUsed = int.Parse(productQuantity.Text.Trim());

                    if (productMap.TryGetValue(selectedProductName, out var productData))
                    {
                        int productId = productData.productId;
                        decimal productPrice = productData.productPrice;
                        decimal totalCost = quantityUsed * productPrice;

                        partCmd.Parameters.AddWithValue("@productId", productId);
                        partCmd.Parameters.AddWithValue("@quantityUsed", quantityUsed);
                        partCmd.Parameters.AddWithValue("@totalCost", totalCost);

                        partCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Selected product not found.");
                        // Handle error accordingly
                    }

                    // 5. Insert service
                    string selectedServiceName = serviceName.SelectedItem?.ToString();
                    if (string.IsNullOrWhiteSpace(selectedServiceName))
                    {
                        throw new Exception("Please select a service.");
                    }

                    decimal serviceCost = decimal.Parse(serviceCostTextBox.Text.Trim());
                    double serviceDuration = double.Parse(serviceDurationTextBox.Text.Trim());

                    string insertServiceQuery = @"INSERT INTO services 
                    (repair_id, service_name, service_cost, service_duration) 
                    VALUES (@repairId, @serviceName, @serviceCost, @serviceDuration)";

                    MySqlCommand serviceCmd = new MySqlCommand(insertServiceQuery, conn, transaction);
                    serviceCmd.Parameters.AddWithValue("@repairId", repairId);
                    serviceCmd.Parameters.AddWithValue("@serviceName", selectedServiceName);
                    serviceCmd.Parameters.AddWithValue("@serviceCost", serviceCost);
                    serviceCmd.Parameters.AddWithValue("@serviceDuration", serviceDuration);
                    serviceCmd.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Service information successfully saved.");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


    }
}
