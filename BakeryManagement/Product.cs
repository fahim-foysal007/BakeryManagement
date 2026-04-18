using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryManagement
{
    class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable ShowAllProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "SELECT * FROM product";
                    SqlDataAdapter sda = new SqlDataAdapter(q, sqc);
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            return dt;
        }

        
        public bool Add(Product p)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "INSERT INTO product (name, price, quantity) VALUES (@name, @price, @quantity)";
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@name", p.name);
                    cmd.Parameters.AddWithValue("@price", p.price);
                    cmd.Parameters.AddWithValue("@quantity", p.quantity);

                    sqc.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            return isSuccess;
        }
        public bool add(Product p)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "INSERT INTO cart (name, price, quantity) VALUES (@name, @price, @quantity)";
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@name", p.name);
                    cmd.Parameters.AddWithValue("@price", p.price);
                    cmd.Parameters.AddWithValue("@quantity", p.quantity);

                    sqc.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            return isSuccess;
        }


        public bool Update(Product p)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "UPDATE product SET name=@name, price=@price, quantity=@quantity WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@Id", p.Id);
                    cmd.Parameters.AddWithValue("@name", p.name);
                    cmd.Parameters.AddWithValue("@price", p.price);
                    cmd.Parameters.AddWithValue("@quantity", p.quantity);

                    sqc.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            return isSuccess;
        }

        public bool Delete(Product p)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "DELETE FROM product WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@Id", p.Id);

                    sqc.Open();
                    isSuccess = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            return isSuccess;
        }

        public int GetQuantityByName(string name)
        {
            int qty = 0;
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "SELECT quantity FROM product WHERE name=@name";
                    SqlCommand cmd = new SqlCommand(q, sqc);
                    cmd.Parameters.AddWithValue("@name", name);

                    sqc.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        qty = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            return qty;
        }
    }
}
