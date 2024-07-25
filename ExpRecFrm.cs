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
        public ExpRecFrm()
        {
            InitializeComponent();
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

            // Display success message
            MessageBox.Show("Expense added successfully!");

            // Clear user input fields
            expCatComboBox.SelectedIndex = 0;
            expDesTextBox.Text = "";
            expAmtTextBox.Text = "";
        }

        public void AddExpense(string category, string description, double amount)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

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
    }
}
