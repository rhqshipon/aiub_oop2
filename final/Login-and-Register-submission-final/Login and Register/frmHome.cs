using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Register
{
    public partial class frmHome : Form
    {
        private frmLogin loginFormReference; 
        public frmHome(string fullName, frmLogin loginForm)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + fullName;
            loginFormReference = loginForm;

            
            LoadData("");
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadData(""); 
        }

        private void LoadData(string searchTerm)
        {
            try
            {
                dataGridViewUsers.DataSource = DatabaseHelper.GetUsers(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            loginFormReference.ClearForm();
            loginFormReference.Show();
            this.Close(); 
        }

       
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (Application.OpenForms["frmLogin"] != null && !loginFormReference.Visible)
            {
                Application.Exit();
            }
        }

        private void btnLogout1_Click_1(object sender, EventArgs e)
        {
            loginFormReference.ClearForm();
            loginFormReference.Show();
            this.Close(); 

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text); 
        }
    }
}
