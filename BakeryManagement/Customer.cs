using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BakeryManagement
{
    class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int passsword { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int contact { get; set; }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable showAllCustomer()
        {
            string q = "Select * From customer";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public bool save(Customer c)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();

            string q = "INSERT into customer (name,password,username,email,contact,address) Values (@name, @password, @username,@email,@contact, @address)";
            SqlCommand sq = new SqlCommand(q, sqc);
          
            sq.Parameters.AddWithValue("@name", c.Name);
            sq.Parameters.AddWithValue("@password", c.passsword);
            sq.Parameters.AddWithValue("@username", c.Username);
            sq.Parameters.AddWithValue("@email", c.Email);
            sq.Parameters.AddWithValue("@contact", c.contact);
            sq.Parameters.AddWithValue("@address", c.Address);


            if (sqc.State == ConnectionState.Open)
            {
                int row = sq.ExecuteNonQuery();
                
                if (row > 0)
                {
                    isSuccess = true;
                }
            }

            sqc.Close();


            return isSuccess;
        }

        public bool update(Customer c)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();
            try
            {
                string q = " UPDATE customer set name=@name,password=@password,username=@username,email=@email,contact=@contact,address=@address" + " WHERE Id=@Id";
                SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@Id", c.id);
                sq.Parameters.AddWithValue("@name", c.Name);
                sq.Parameters.AddWithValue("@password", c.passsword);
                sq.Parameters.AddWithValue("@username", c.Username);
                sq.Parameters.AddWithValue("@email", c.Email);
                sq.Parameters.AddWithValue("@contact", c.contact);
                sq.Parameters.AddWithValue("@address", c.Address);


                if (sqc.State == ConnectionState.Open)
                {
                    int row = sq.ExecuteNonQuery();
                   
                    if (row > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR: {e.Message}");
                return isSuccess;
            }
            finally
            {
                sqc.Close();
            }


            return isSuccess;
        }
        public bool Delete(Customer c)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();
            try
            {
                string q = "Delete from customer where Id=@Id";
                SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@Id", c.id);

                if (sqc.State == ConnectionState.Open)
                {
                    int row = sq.ExecuteNonQuery();
                    if (row > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception e)
            {
                return isSuccess;
            }
            finally
            {
                sqc.Close();
            }

            return isSuccess;
        }
    }



}
