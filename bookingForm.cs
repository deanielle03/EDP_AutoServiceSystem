using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Auto_Service
{
    public partial class bookingForm : Form
    {
        private int bookingId;
        private bool isEditMode = false;

        public int BookingId
        {
            get => bookingId;
            set => bookingId = value;
        }

        public bool IsEditMode
        {
            get => isEditMode;
            set => isEditMode = value;
        }

        public string EditedName => fNameBooking.Text;
        public string EditedPhone => phoneNumBooking.Text;
        public string EditedService => serviceNameBooking.Text;

        public bookingForm()
        {
            InitializeComponent();
            LoadServiceDropdown();
            InitializeStatusDropdown();
        }

        private void InitializeStatusDropdown()
        {
            statusDDown.Items.Clear();
            statusDDown.Items.Add("Pending");
            statusDDown.Items.Add("Approved");
            statusDDown.Items.Add("Cancelled");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void LoadBookingData(int id, string name, string phone, string service, string status)
        {
            BookingId = id;
            fNameBooking.Text = name;
            phoneNumBooking.Text = phone;
            serviceNameBooking.Text = service;
            
            IsEditMode = true;
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = fNameBooking.Text.Trim();
            string phoneNumber = phoneNumBooking.Text.Trim();
            string service = serviceNameBooking.Text.Trim();
            string status = "Pending"; 

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(service))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    if (IsEditMode)
                    {
                        // Update query
                        string updateQuery = @"UPDATE bookings 
                                       SET name = @name, phone_number = @phone, service = @service, status = @status 
                                       WHERE id = @id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@name", name);
                        updateCmd.Parameters.AddWithValue("@phone", phoneNumber);
                        updateCmd.Parameters.AddWithValue("@service", service);
                        updateCmd.Parameters.AddWithValue("@status", statusDDown.SelectedItem.ToString());
                        updateCmd.Parameters.AddWithValue("@id", BookingId);

                        int result = updateCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Booking updated successfully.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.");
                        }
                    }
                    else
                    {
                        // Same insert logic as before
                        string checkQuery = @"SELECT COUNT(*) FROM bookings 
                                      WHERE LOWER(name) = @name AND LOWER(phone_number) = @phone 
                                      AND LOWER(service) = @service AND DATE(created_at) = CURDATE()";

                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@name", name.ToLower());
                        checkCmd.Parameters.AddWithValue("@phone", phoneNumber.ToLower());
                        checkCmd.Parameters.AddWithValue("@service", service.ToLower());

                        int existingBookings = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingBookings > 0)
                        {
                            MessageBox.Show("A booking with the same details already exists for today.");
                            return;
                        }

                        string insertQuery = @"INSERT INTO bookings (name, phone_number, service, created_at, status) 
                                       VALUES (@name, @phone, @service, @created_at, @status)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@phone", phoneNumber);
                        insertCmd.Parameters.AddWithValue("@service", service);
                        insertCmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@status", status);

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Booking submitted successfully.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit booking.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }


        private void phoneNumBooking_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviceNameBooking_SelectedIndexChanged(object sender, EventArgs e)
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
                        serviceNameBooking.Items.Clear(); // Clear any existing items

                        while (reader.Read())
                        {
                            serviceNameBooking.Items.Add(reader.GetString("service_name"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service names: " + ex.Message);
            }
        }

        private void bookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
