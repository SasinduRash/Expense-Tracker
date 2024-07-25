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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void pwLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pwShowCheckBox.Checked == false)
            {
                pwLoginTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                pwLoginTextBox.UseSystemPasswordChar = false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string Uname = usernameLoginTextBox.Text;
            string pw = pwLoginTextBox.Text;
            
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM [User] WHERE Username = @Uname and Password = @pw ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Uname", Uname);
                        command.Parameters.AddWithValue("@pw", pw);

                        SqlDataAdapter ad = new SqlDataAdapter(command);

                        DataTable dt = new DataTable();

                        ad.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            Form1 f1 = new Form1();
                            f1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!");
                        }

                    }
  
                }
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
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
