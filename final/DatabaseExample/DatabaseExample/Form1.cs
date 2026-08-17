using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;

namespace DatabaseExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=localhost;Initial Catalog=Trial1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}
