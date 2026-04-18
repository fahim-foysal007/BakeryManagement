using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryManagement
{
    class Paymant
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable ShowAllcart()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqc = new SqlConnection(connection))
                {
                    string q = "SELECT * FROM cart";
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
    }
}
