using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class Purchase : Form
    {
        Product p = new Product();
        Paymant p1 = new Paymant();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        public Purchase()
        {
            InitializeComponent();
        }



        private void show_Click(object sender, EventArgs e)
        {

            DataTable dt = p.ShowAllProduct();
            dataGridView1.DataSource = dt;
        }
        public void Clear()
        {
            pname.Text = "";
            pricetxt.Clear();
            pquan.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                p.name = pname.Text;
                int qty = Convert.ToInt32(pquan.Text);
                double unitPrice = Convert.ToDouble(pricetxt.Text);

                p.price = unitPrice * qty;
                p.quantity = qty;

                bool x = p.add(p);
                if (x == true)
                {
                    MessageBox.Show("Successfully added!!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong!! Try Again!!");
                }

                DataTable dt = p1.ShowAllcart();
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            pname.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            pricetxt.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();


        }

        private void pquan_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if cart is empty
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("Cart is empty");
                    return;
                }

                // Calculate total price
                double total = 0;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow && row.Cells["price"].Value != null)
                    {
                        double price = Convert.ToDouble(row.Cells["price"].Value);
                        total += price;
                    }
                }

                // Show MessageBox
                MessageBox.Show($"Total Price: {total}\n\nThank You for Your Purchase!",
                                "Payment Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Clear Cart
                ClearCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        void ClearCart()
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("DELETE FROM cart", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView2.DataSource = null; // or call LoadCart();
            t00.Text = "0";
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
