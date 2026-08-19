using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Login_and_Register
{
    public static class DatabaseHelper
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        }

        public static void TestConnection()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    con.Open();
                    MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string HashPassword(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool CheckUsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string query = "SELECT COUNT(*) FROM dbo.Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static bool RegisterUser(string username, string passwordHash, string email, string fullName)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string query = "INSERT INTO dbo.Users (Username, PasswordHash, Email, FullName) VALUES (@Username, @PasswordHash, @Email, @FullName)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@FullName", fullName);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static string LoginUser(string username, string passwordHash)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string query = "SELECT FullName FROM dbo.Users WHERE Username = @Username AND PasswordHash = @PasswordHash";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public static DataTable GetUsers(string searchTerm = "")
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                
                string query = "SELECT UserID, Username, FullName, Email, CreatedAt FROM dbo.Users WHERE Username LIKE @SearchTerm";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}