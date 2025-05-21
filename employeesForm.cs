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
    public partial class employeesForm : Form
    {
        public employeesForm()
        {
            InitializeComponent();
        }

        private int EmployeeId;
        private bool IsEditMode = false;

        public void LoadEmployeeData(int id, string firstName, string lastName, string phone, string email, string address, string role, DateTime hireDate, decimal salary)
        {
            EmployeeId = id;
            fName.Text = firstName;
            lName.Text = lastName;
            mobileNum.Text = phone;
            emailText.Text = email;
            addressText.Text = address;
            employeeRole.Text = role;
            employeeHireDate.Value = hireDate;
            employeeSalary.Text = salary.ToString("0.00");

            IsEditMode = true;
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            string firstName = fName.Text.Trim();
            string lastName = lName.Text.Trim();
            string phone = mobileNum.Text.Trim();
            string email = emailText.Text.Trim();
            string address = addressText.Text.Trim();
            string role = employeeRole.Text.Trim();
            DateTime hireDate = employeeHireDate.Value;
            decimal salary;

            if (!decimal.TryParse(employeeSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                if (IsEditMode)
                {
                    string updateQuery = @"UPDATE employees SET 
                first_name = @firstName, 
                last_name = @lastName, 
                phone_number = @phone, 
                email = @email, 
                address = @address, 
                role = @role, 
                hire_date = @hireDate, 
                salary = @salary
                WHERE employee_id = @id";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@hireDate", hireDate);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@id", EmployeeId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee updated successfully.");
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
                    string insertQuery = @"INSERT INTO employees 
                (first_name, last_name, phone_number, email, address, role, hire_date, salary) 
                VALUES (@firstName, @lastName, @phone, @email, @address, @role, @hireDate, @salary)";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@hireDate", hireDate);
                    cmd.Parameters.AddWithValue("@salary", salary);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee added successfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee.");
                    }
                }
            }
        }

    }
}
