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
    public partial class signUpFrm : Form
    {
        public signUpFrm()
        {
            InitializeComponent();
        }

        private void pwShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pwShowCheckBox.Checked==false)
            {
                pwTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                pwTextBox.UseSystemPasswordChar=false;
            }
        }

        private void pwTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string pw = pwTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("User name or Password field is empty!");
                return;
            }

            AddUser(username, pw);
        }

        public void AddUser(string username, string pw)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO [User] (Username, Password) VALUES (@username, @pw)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@pw", pw);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("New user added successfully!");

                usernameTextBox.Text = "";
                pwTextBox.Text = "";
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions (e.g., connection errors, syntax errors)
                MessageBox.Show("An error occurred while adding the user: " + ex.Message);
            }
            catch (Exception ex)  // Catch any other unexpected exceptions
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
