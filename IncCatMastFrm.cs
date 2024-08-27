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

namespace Mini_cash_management_system
{
    public partial class IncCatMastFrm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        private SqlConnection connection;

        public IncCatMastFrm()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void incCatAddBtn_Click(object sender, EventArgs e)
        {
            string catID = incIdTextBox.Text;
            string cat = incTextBox.Text;

            if (string.IsNullOrEmpty(catID) || string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("Category ID or Category field is empty!");
                return;
            }

            AddIncCat(catID, cat);
        }

        public void AddIncCat(string catID, string cat)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO IncomeCategory (CategoryID, Category) VALUES (@catID, @cat)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@catID", catID);
                        command.Parameters.AddWithValue("@cat", cat);

                        command.ExecuteNonQuery();
                    }
                }

                LoadDataToDataGridView();

                MessageBox.Show("New category added successfully!");

                incIdTextBox.Text = "";
                incTextBox.Text = "";
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions (e.g., connection errors, syntax errors)
                MessageBox.Show("An error occurred while adding the category: " + ex.Message);
            }
            catch (Exception ex)  // Catch any other unexpected exceptions
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void incCatUpdateBtn_Click(object sender, EventArgs e)
        {
            string catID = incIdTextBox.Text;
            string cat = incTextBox.Text;

            if (string.IsNullOrEmpty(catID) || string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("Category ID or Category field is empty!");
                return;
            }

            UpdateIncCat(catID, cat);
        }

        public void UpdateIncCat(string catID, string cat)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE IncomeCategory SET Category = @cat WHERE CategoryID = @catID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@catID", catID);
                        command.Parameters.AddWithValue("@cat", cat);

                        command.ExecuteNonQuery();
                    }
                }

                LoadDataToDataGridView();

                MessageBox.Show("Income category updated successfully!");

                incIdTextBox.Text = "";
                incTextBox.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while updating the income category: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void incCatDeleteBtn_Click(object sender, EventArgs e)
        {
            string catID = incIdTextBox.Text;

            if (string.IsNullOrEmpty(catID))
            {
                MessageBox.Show("Category ID field is empty!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteIncCat(catID);
            }
        }

        public void DeleteIncCat(string catID)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM IncomeCategory WHERE CategoryID = @catID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@catID", catID); 
                        command.ExecuteNonQuery();
                    } 
                }

                LoadDataToDataGridView();

                MessageBox.Show("Income category deleted successfully!");

                incIdTextBox.Text = "";
                incTextBox.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the income category: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
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
                    string query = "SELECT Category FROM IncomeCategory"; // Replace with your actual table name

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridViewInc.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void IncCatMastFrm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }

    
}
