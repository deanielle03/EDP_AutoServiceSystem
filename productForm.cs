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
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }
        public int ProductId { get; set; }
        public bool IsEditMode { get; set; } = false;

        public void LoadProductData(int id, string name, decimal price, int stock)
        {
            ProductId = id;
            productName.Text = name;
            productPrice.Text = price.ToString("0.00");
            productQuantity.Text = stock.ToString();

            IsEditMode = true;
            submitBtn.Text = "Update Product";
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = productName.Text.Trim();
            string priceText = productPrice.Text.Trim();
            string stockText = productQuantity.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || !decimal.TryParse(priceText, out decimal price) || !int.TryParse(stockText, out int stock))
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    if (IsEditMode)
                    {
                        string updateQuery = @"
                    UPDATE products 
                    SET product_name = @name, product_price = @price, stock_quantity = @stock 
                    WHERE product_id = @id";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@name", name);
                            updateCmd.Parameters.AddWithValue("@price", price);
                            updateCmd.Parameters.AddWithValue("@stock", stock);
                            updateCmd.Parameters.AddWithValue("@id", ProductId);

                            int result = updateCmd.ExecuteNonQuery();
                            MessageBox.Show(result > 0 ? "Product updated successfully." : "No changes were made.");
                        }
                    }
                    else
                    {
                        // Optional duplicate check
                        string checkQuery = @"SELECT COUNT(*) FROM products WHERE LOWER(product_name) = @name";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@name", name.ToLower());

                            int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (existing > 0)
                            {
                                MessageBox.Show("A product with this name already exists.");
                                return;
                            }
                        }

                        string insertQuery = @"
                    INSERT INTO products (product_name, product_price, stock_quantity) 
                    VALUES (@name, @price, @stock)";

                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@name", name);
                            insertCmd.Parameters.AddWithValue("@price", price);
                            insertCmd.Parameters.AddWithValue("@stock", stock);

                            int result = insertCmd.ExecuteNonQuery();
                            MessageBox.Show(result > 0 ? "Product added successfully." : "Failed to add product.");
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productForm_Load(object sender, EventArgs e)
        {

        }
    }
}
