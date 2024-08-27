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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mini_cash_management_system
{
    public partial class ExpCatMastFrm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        private SqlConnection connection;

        public ExpCatMastFrm()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void expCatAddBtn_Click(object sender, EventArgs e)
        {
            string catID = expIdTextBox.Text;
            string cat = expTextBox.Text;

            if (string.IsNullOrEmpty(catID) || string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("Category ID or Category field is empty!");
                return;
            }

            AddCat(catID, cat);
        }

        public void AddCat(string catID, string cat)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ExpenseCategory (CategoryID, Category) VALUES (@catID, @cat)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@catID", catID);
                        command.Parameters.AddWithValue("@cat", cat);

                        command.ExecuteNonQuery();
                    }
                }

                LoadDataToDataGridView();

                MessageBox.Show("New category added successfully!");

                expIdTextBox.Text = "";
                expTextBox.Text = "";
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

        private void expCatUpdateBtn_Click(object sender, EventArgs e)
        {
            string catID = expIdTextBox.Text;
            string cat = expTextBox.Text;

            if (string.IsNullOrEmpty(catID) || string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("Category ID or Category field is empty!");
                return;
            }

            UpdateCat(catID, cat);
        }

        public void UpdateCat(string catID, string cat)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE ExpenseCategory SET Category = @cat WHERE CategoryID = @catID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@catID", catID);
                        command.Parameters.AddWithValue("@cat", cat);

                        command.ExecuteNonQuery();
                    }
                }

                LoadDataToDataGridView();

                MessageBox.Show("Category updated successfully!");

                expIdTextBox.Text = "";
                expTextBox.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while updating the category: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void expCatDeleteBtn_Click(object sender, EventArgs e)
        {
            string catID = expIdTextBox.Text;

            if (string.IsNullOrEmpty(catID))
            {
                MessageBox.Show("Category ID field is empty!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteCat(catID);
            }
        }

        public void DeleteCat(string catID)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM ExpenseCategory WHERE CategoryID = @catID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@catID", catID);

                        command.ExecuteNonQuery();
                    }
                }

                LoadDataToDataGridView();

                MessageBox.Show("Category deleted successfully!");

                expIdTextBox.Text = "";
                expTextBox.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the category: " + ex.Message);
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
                    string query = "SELECT Category FROM ExpenseCategory"; // Replace with your actual table name

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridViewExp.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void ExpCatMastFrm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
