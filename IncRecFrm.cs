﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_cash_management_system
{
    public partial class IncRecFrm : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        private SqlConnection connection;

        public IncRecFrm()
        {
            InitializeComponent();
            LoadDataToComboBox();
        }

        private void IncRecFrm_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
        }

        private void incAddBtn_Click(object sender, EventArgs e)
        {
            // Get user input from controls
            string category = incCatComboBox.SelectedItem.ToString();
            string description = incDesTextBox.Text;
            double amount = Convert.ToDouble(incAmtTextBox.Text);

            // Validate user input (ensure non-negative amount)
            if (amount < 0)
            {
                MessageBox.Show("Error: Expense amount cannot be negative.");
                return;
            }

            AddIncome(category, description, amount);

            // Display success message
            MessageBox.Show("Expense added successfully!");

            // Clear user input fields
            incCatComboBox.SelectedIndex = 0;
            incDesTextBox.Text = "";
            incAmtTextBox.Text = "";
        }

        public void AddIncome(string category, string description, double amount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO IncomeReport (Category, Description, Amount, DateEntered) VALUES (@category, @description, @amount, GETDATE())";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@amount", amount);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadDataToComboBox()
        {
            //string connectionString = "your_connection_string_here";
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                // Query to retrieve data
                string query = "SELECT Category FROM IncomeCategory";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Clear existing items in the ComboBox
                incCatComboBox.Items.Clear();

                // Add items from the database to the ComboBox
                while (reader.Read())
                {
                    incCatComboBox.Items.Add(reader["Category"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
