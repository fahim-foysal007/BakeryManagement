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
    class Baker
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int passsword { get; set; }
        public double salary { get; set; }
        public int contact { get; set; }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        public DataTable showBaker()
        {
            string q = "Select * From baker";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public bool save(Baker b)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();

            string q = "INSERT into baker (name,username,password,salary,contact) Values (@name,@username,@password,@salary, @contact)";
            SqlCommand sq = new SqlCommand(q, sqc);

            sq.Parameters.AddWithValue("@name", b.Name);
            sq.Parameters.AddWithValue("@username", b.Username);
            sq.Parameters.AddWithValue("@password", b.passsword);
            sq.Parameters.AddWithValue("@salary", b.salary);
            sq.Parameters.AddWithValue("@contact", b.contact);


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

        public bool update(Baker b)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();
            try
            {
                string q = " UPDATE baker set name=@name,username=@username,password=@password,salary=@salary,contact=@contact" + " WHERE Id=@Id";
                SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@Id", b.id);
                sq.Parameters.AddWithValue("@name", b.Name);
                sq.Parameters.AddWithValue("@username", b.Username);
                sq.Parameters.AddWithValue("@password", b.passsword);
                sq.Parameters.AddWithValue("@salary", b.salary);
                sq.Parameters.AddWithValue("@contact", b.contact);


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
        public bool Delete(Baker b)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();
            try
            {
                string q = "Delete from manager where Id=@Id";
                SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@Id", b.id);

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

