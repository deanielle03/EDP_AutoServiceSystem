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
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Auto_Service
{
    public partial class productsManagement : UserControl
    {
        public productsManagement()
        {
            InitializeComponent();
            LoadProductsData();
        }

        private void LoadProductsData()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM products";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    productsView.DataSource = dt;
                    productsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void productsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productsView.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["product_id"].Value);
                string name = row.Cells["product_name"].Value?.ToString();
                string price = row.Cells["product_price"].Value?.ToString();
                string quantity = row.Cells["stock_quantity"].Value?.ToString();


            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            productForm form = new productForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProductsData(); // Refresh the DataGridView
            }
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (productsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            DataGridViewRow selectedRow = productsView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["product_id"].Value);
            string name = selectedRow.Cells["product_name"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells["product_price"].Value);
            int stock = Convert.ToInt32(selectedRow.Cells["stock_quantity"].Value);

            productForm form = new productForm();
            form.LoadProductData(id, name, price, stock);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProductsData(); // Refresh the DataGridView
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            if (productsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DataGridViewRow selectedRow = productsView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["product_id"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = Database.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM products WHERE product_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Product deleted successfully.");
                                LoadProductsData(); // Refresh
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete product.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string excelFilePath = @"C:\Users\Danica\Desktop\EDP\bin\Debug\net8.0-windows\reportTemplate\productList.xlsx";

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
                    for (int c = startCol; c <= productsView.Columns.Count; c++)
                    {
                        worksheet.Cells[r, c] = null;
                    }
                }

                // Write data
                for (int i = 0; i < productsView.Rows.Count; i++)
                {
                    for (int j = 0; j < productsView.Columns.Count; j++)
                    {
                        object value = productsView.Rows[i].Cells[j].Value;
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
