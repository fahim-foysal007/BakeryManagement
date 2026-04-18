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
    class CartItem
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable showItem()
        {
            string q = "Select * From curt";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

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


    }
}
