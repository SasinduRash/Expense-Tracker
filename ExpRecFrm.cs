using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_cash_management_system
{
    public partial class ExpRecFrm : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        private SqlConnection connection;

        public ExpRecFrm()
        {
            InitializeComponent();
            LoadDataToComboBox();
            LoadDataToDataGridView();
        }

        private void expAddBtn_Click(object sender, EventArgs e)
        {
            // Get user input from controls
            string category = expCatComboBox.SelectedItem.ToString();
            string description = expDesTextBox.Text;
            double amount = Convert.ToDouble(expAmtTextBox.Text);

            // Validate user input (ensure non-negative amount)
            if (amount < 0)
            {
                MessageBox.Show("Error: Expense amount cannot be negative.");
                return;
            }

            AddExpense(category, description, amount);

            LoadDataToDataGridView();

            // Display success message
            MessageBox.Show("Expense added successfully!");

            // Clear user input fields
            expCatComboBox.SelectedIndex = 0;
            expDesTextBox.Text = "";
            expAmtTextBox.Text = "";
        }

        public void AddExpense(string category, string description, double amount)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO ExpenseReport1 (Category, Description, Amount, DateEntered) VALUES (@category, @description, @amount, GETDATE())";

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
                string query = "SELECT Category FROM ExpenseCategory";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Clear existing items in the ComboBox
                expCatComboBox.Items.Clear();

                expCatComboBox.Items.Add("");

                // Add items from the database to the ComboBox
                while (reader.Read())
                {
                    expCatComboBox.Items.Add(reader["Category"].ToString());
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

        private void LoadDataToDataGridView()
        {
            //string connectionString = "your_connection_string_here"; // Replace with your actual connection string
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve data from the database
                    string query = "SELECT Category,Description,Amount,DateEntered FROM ExpenseReport1"; // Replace with your actual table name

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridViewExpR.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void ExpRecFrm_Load(object sender, EventArgs e)
        {
            LoadDataToComboBox();
            LoadDataToDataGridView();
        }
    }
}
