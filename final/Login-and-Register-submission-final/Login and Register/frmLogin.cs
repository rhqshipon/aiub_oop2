using Microsoft.Data.SqlClient;
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
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public frmLogin()   { InitializeComponent(); }

        private int failedAttempts = 0;

       

        public void ClearForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string hashedPw = DatabaseHelper.HashPassword(txtPassword.Text);
                string fullName = DatabaseHelper.LoginUser(txtUsername.Text, hashedPw);

                if (fullName != null)
                {
                    failedAttempts = 0; 
                    new frmHome(fullName, this).Show();
                    this.Hide();
                }
                else
                {
                    failedAttempts++;
                    MessageBox.Show($"Invalid credentials. Attempt {failedAttempts} of 3.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (failedAttempts >= 3)
                    {
                        btnLogin.Enabled = false;
                        MessageBox.Show("Account temporarily locked due to too many failed attempts.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Hide();
            new frmRegister().Show();
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