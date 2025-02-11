using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class UserCreation : Form // SignupForm
    {
        private string connectionString;


        public UserCreation()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            
        }

private void SignupButton_Click(object sender, EventArgs e)
        {

        }

        private void UserCreation_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_click_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Name, Email, Password) VALUES (@Name, @Email, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", NameTextboxcreation.Text);
                        cmd.Parameters.AddWithValue("@Email", CreationEmailtxtbox.Text);
                        cmd.Parameters.AddWithValue("@Password", CreationPasswordtxtbox.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully!");
                        Loginform loginform = new Loginform();
                        loginform.Show();
                        this.Hide();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}\nError Number: {ex.Number}");
            }
        }
    }
}







