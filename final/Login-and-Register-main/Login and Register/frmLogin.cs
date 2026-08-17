using Microsoft.Data.SqlClient; // Updated to the modern SQL client
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Login_and_Register
{
    public partial class frmLogin : Form
    {
        // 1. Just DECLARE the variables here
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public frmLogin()
        {
            InitializeComponent();

            // 2. ASSIGN the connection string here
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con = new SqlConnection(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Using parameterized queries to securely pass credentials
                string login = "SELECT * FROM logininfo1 WHERE username = @username and password = @password";
                                cmd = new SqlCommand(login, con);

                // Bind the parameters safely
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    new frmDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }

                dr.Close(); // Good practice to close the reader when done
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure connection is closed even if the login fails or throws an error
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void clickRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}