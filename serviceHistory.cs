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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace Auto_Service
{
    public partial class serviceHistory : UserControl
    {
        public serviceHistory()
        {
            InitializeComponent();
            LoadServiceInformation();
        }

        private void serviceHistory_Load(object sender, EventArgs e)
        {

        }

        private void LoadServiceInformation()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM service_information";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    servicesView.DataSource = dt;
                    servicesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service information: " + ex.Message);
            }
        }

        private void servicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row, not the header
            if (e.RowIndex >= 0 && e.RowIndex < servicesView.Rows.Count)
            {
                DataGridViewRow row = servicesView.Rows[e.RowIndex];

                string company = row.Cells["vehicle_company"].Value?.ToString() ?? string.Empty;
                string model = row.Cells["vehicle_model"].Value?.ToString() ?? string.Empty;
                string year = row.Cells["model_year"].Value?.ToString() ?? string.Empty;
                string customerFName = row.Cells["customer_FName"].Value?.ToString() ?? string.Empty;
                string customerLName = row.Cells["customer_LName"].Value?.ToString() ?? string.Empty;
                string service = row.Cells["service_acquired"].Value?.ToString() ?? string.Empty;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string excelFilePath = @"C:\Users\Danica\Desktop\EDP\bin\Debug\net8.0-windows\reportTemplate\serviceHistory.xlsx";

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
                    for (int c = startCol; c <= servicesView.Columns.Count; c++)
                    {
                        worksheet.Cells[r, c] = null;
                    }
                }

                // Write data
                for (int i = 0; i < servicesView.Rows.Count; i++)
                {
                    for (int j = 0; j < servicesView.Columns.Count; j++)
                    {
                        object value = servicesView.Rows[i].Cells[j].Value;
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
