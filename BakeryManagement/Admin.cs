using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryManagement
{
    class Admin
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        // Constructor (AUTO INSERT MULTIPLE ADMINS)
        public Admin()
        {
            InsertMultipleAdmins();
        }
        
        private void InsertMultipleAdmins()
        {
            using (SqlConnection sqc = new SqlConnection(connection))
            {
                string q = "INSERT INTO [Admin] (name, username, password, contact) " +
                           "VALUES (@name, @username, @password, @contact)";

                try
                {
                    sqc.Open();

                    SqlCommand sq = new SqlCommand(q, sqc);

                    // Admin 1
                    sq.Parameters.AddWithValue("@name", "Rahim");
                    sq.Parameters.AddWithValue("@username", "rahim01");
                    sq.Parameters.AddWithValue("@password", "12345");
                    sq.Parameters.AddWithValue("@contact", 1712345678);
                    sq.ExecuteNonQuery();

                    // Admin 2
                    sq.Parameters.Clear();
                    sq.Parameters.AddWithValue("@name", "Karim");
                    sq.Parameters.AddWithValue("@username", "karim01");
                    sq.Parameters.AddWithValue("@password", "abc123");
                    sq.Parameters.AddWithValue("@contact", 1812345678);
                    sq.ExecuteNonQuery();

                    // Admin 3
                    sq.Parameters.Clear();
                    sq.Parameters.AddWithValue("@name", "Salma");
                    sq.Parameters.AddWithValue("@username", "salma01");
                    sq.Parameters.AddWithValue("@password", "pass456");
                    sq.Parameters.AddWithValue("@contact", 1912345678);
                    sq.ExecuteNonQuery();

                    // Admin 4 (Your Almas)
                    sq.Parameters.Clear();
                    sq.Parameters.AddWithValue("@name", "Almas");
                    sq.Parameters.AddWithValue("@username", "admin123");
                    sq.Parameters.AddWithValue("@password", "123456");
                    sq.Parameters.AddWithValue("@contact", 1912345678);
                    sq.ExecuteNonQuery();

                    sqc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
