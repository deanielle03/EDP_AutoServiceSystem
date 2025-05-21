using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Auto_Service
{
    public partial class employeeManagement : UserControl
    {
        public employeeManagement()
        {
            InitializeComponent();
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM employees";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    employeesView.DataSource = dt;
                    employeesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message);
            }
        }

        private void productsManagement_Load(object sender, EventArgs e)
        {

        }

        private void employeesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employeesView.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["employee_id"].Value);
                string firstName = row.Cells["first_name"].Value?.ToString();
                string lastName = row.Cells["last_name"].Value?.ToString();
                string phoneNumber = row.Cells["phone_number"].Value?.ToString();
                string email = row.Cells["email"].Value?.ToString();
                string address = row.Cells["address"].Value?.ToString();
                string role = row.Cells["role"].Value?.ToString();
                string hireDate = Convert.ToDateTime(row.Cells["hire_date"].Value).ToShortDateString();
                string salary = row.Cells["salary"].Value?.ToString();
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeesForm form = new employeesForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // Refresh the DataGridView
            }
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = employeesView.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["employee_id"].Value);
                string firstName = row.Cells["first_name"].Value.ToString();
                string lastName = row.Cells["last_name"].Value.ToString();
                string phone = row.Cells["phone_number"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string address = row.Cells["address"].Value.ToString();
                string role = row.Cells["role"].Value.ToString();
                DateTime hireDate = Convert.ToDateTime(row.Cells["hire_date"].Value);
                decimal salary = Convert.ToDecimal(row.Cells["salary"].Value);

                employeesForm form = new employeesForm();
                form.LoadEmployeeData(id, firstName, lastName, phone, email, address, role, hireDate, salary);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (employeesView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(employeesView.SelectedRows[0].Cells["employee_id"].Value);

                    using (MySqlConnection conn = Database.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM employees WHERE employee_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    LoadEmployees();
                    MessageBox.Show("Employee deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string excelFilePath = @"C:\Users\Danica\Desktop\EDP\bin\Debug\net8.0-windows\reportTemplate\employeesList.xlsx";

            if (!File.Exists(excelFilePath))
            {
                MessageBox.Show("Excel template not found at: " + excelFilePath);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                workbook = excelApp.Workbooks.Open(excelFilePath);
                worksheet = workbook.Sheets[1];

                int startRow = 5; // Skip title and headers
                int startCol = 1;

                int lastRow = worksheet.UsedRange.Rows.Count;
                for (int r = startRow; r <= lastRow; r++)
                {
                    for (int c = startCol; c <= employeesView.Columns.Count; c++)
                    {
                        worksheet.Cells[r, c] = null;
                    }
                }

                // Write data
                for (int i = 0; i < employeesView.Rows.Count; i++)
                {
                    for (int j = 0; j < employeesView.Columns.Count; j++)
                    {
                        object value = employeesView.Rows[i].Cells[j].Value;
                        worksheet.Cells[startRow + i, startCol + j] = value?.ToString() ?? "";
                    }
                }


                // Save changes
                workbook.Save();
                MessageBox.Show("Export successful to:\n" + excelFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cleanup
                workbook?.Close(false);
                excelApp.Quit();

                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
