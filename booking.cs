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
    public partial class booking : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer;
        public booking()
        {
            InitializeComponent();
            LoadBookings();
            InitializeRefreshTimer();
        }

        // Method to load bookings into DataGridView
        private void LoadBookings()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM bookings";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    bookingView.DataSource = dt;
                    bookingView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        private void bookingView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bookingView.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value?.ToString();
                string phone = row.Cells["phone_number"].Value?.ToString();
                string service = row.Cells["service"].Value?.ToString();
                string status = row.Cells["status"].Value?.ToString();

                bookingForm form = new bookingForm();
                form.LoadBookingData(id, name, phone, service, status);

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadBookings(); // reload grid
                    refreshTimer.Start();
                }
            }
        }

        private void InitializeRefreshTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 60000; // 60000 milliseconds = 1 minute

            refreshTimer.Tick += (s, e) =>
            {
                LoadBookings();      // Refresh the bookings data grid
                refreshTimer.Stop(); // Stop the timer after this one refresh
            };
        }

        private void editBookingBtn_Click(object sender, EventArgs e)
        {
            if (bookingView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bookingView.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string name = selectedRow.Cells["name"].Value?.ToString();
                string phone = selectedRow.Cells["phone_number"].Value?.ToString();
                string service = selectedRow.Cells["service"].Value?.ToString();
                string status = selectedRow.Cells["status"].Value?.ToString();

                bookingForm editForm = new bookingForm();
                editForm.LoadBookingData(id, name, phone, service, status);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Reload your data in the DataGridView after a successful edit
                    LoadBookings();
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to edit.");
            }
        }

        private void addBookingBtn_Click(object sender, EventArgs e)
        {
            bookingForm bookingForm = new bookingForm();
            bookingForm.ShowDialog();

            if (bookingForm.DialogResult == DialogResult.OK)
            {
                LoadBookings(); // reload grid
            }
        }
    }
}
