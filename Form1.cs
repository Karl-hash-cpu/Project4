using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
namespace WindowsFormsApp1
{
    public partial class Loginform : Form
    {
        
        public Loginform()
        {
            InitializeComponent();
            Passwordtxtbox.Text = "Please enter your password";
            Passwordtxtbox.Text = "";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        //login 
        private void button1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDB;Integrated Security=True;";



                string email = Emailtxtbox.Text;
                string password = Passwordtxtbox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            {
                
                if (Passwordtxtbox.PasswordChar == '*')
                {
                    
                    Passwordtxtbox.PasswordChar = '\0';
                }
                else
                {
                    
                    Passwordtxtbox.PasswordChar = '*';

                   
                }
            }

        }

        

        private void textBox2_Enter(object sender, EventArgs e)
        {
           
        }

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            {

                if (Passwordtxtbox.Text == "Please enter your password")
                {
                    Passwordtxtbox.Text = "";
                    Emailtxtbox.Text = "";
                    Passwordtxtbox.PasswordChar = '*';
                }
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            {
                if (Emailtxtbox.Text == "Please enter your email")
                {
                    Emailtxtbox.Text = "";
                    Passwordtxtbox.Text = "";

                }
            }
        }

        private void signupbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserCreation signup = new UserCreation();
            signup.Show();
            this.Hide();
            
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}

