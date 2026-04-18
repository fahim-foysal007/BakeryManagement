using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BakeryManagement
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }
        Product p = new Product();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 lg = new LogIn1();
            lg.Show();
            this.Hide();
        }

        private void buttonCM_Click(object sender, EventArgs e)
        {
            CustomerManage lg = new CustomerManage();
            lg.Show();
            this.Hide();
        }

        private void buttonBI_Click(object sender, EventArgs e)
        {
            BakerInformed bi = new BakerInformed();
            bi.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int GetQuantityByName(string name)
        {
            int qty = 0;

            using (SqlConnection sqc = new SqlConnection(connection))
            {
                string q = "SELECT quantity FROM product WHERE name=@name";
                SqlCommand cmd = new SqlCommand(q, sqc);
                cmd.Parameters.AddWithValue("@name", name);

                sqc.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    qty = Convert.ToInt32(result);
                }
            }
            return qty;
        }
        public bool UpdateQuantity(string name, int newQty)
        {
            bool isSuccess = false;
            using (SqlConnection sqc = new SqlConnection(connection))
            {
                string q = "UPDATE product SET quantity=@quantity WHERE name=@name";
                SqlCommand cmd = new SqlCommand(q, sqc);

                cmd.Parameters.AddWithValue("@quantity", newQty);
                cmd.Parameters.AddWithValue("@name", name);

                sqc.Open();
                isSuccess = cmd.ExecuteNonQuery() > 0;
            }
            return isSuccess;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                PP.Clear();
                PQ.Clear();

                switch (comboBox1.Text)
                {
                    case "bakorkhani":
                        PP.Text = "20";
                        break;

                    case "dry cake":
                        PP.Text = "50";
                        break;

                    case "einkon biscuit":
                        PP.Text = "10";
                        break;

                    case "brown bread":
                        PP.Text = "40";
                        break;

                    case "fulko bread":
                        PP.Text = "35";
                        break;

                    case "buttermilk biscuit":
                        PP.Text = "15";
                        break;

                    case "vanilla cake":
                        PP.Text = "600";
                        break;

                    case "strawberry cake":
                        PP.Text = "650";
                        break;

                    case "chocolate cake":
                        PP.Text = "700";
                        break;

                    case "happy bear":
                        PP.Text = "30";
                        break;

                    case "vanilla bear":
                        PP.Text = "30";
                        break;

                    case "strawberry bear":
                        PP.Text = "30";
                        break;

                    default:
                        PP.Clear();
                        break;
                }

        }

        public void Clear()
        {
            comboBox1.Text = "";
            PP.Clear();
            PQ.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || PP.Text == "" || PQ.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                if (!int.TryParse(PQ.Text, out int qty))
                {
                    MessageBox.Show("Invalid quantity");
                    return;
                }

                p.name = comboBox1.Text;
                p.price = Convert.ToDouble(PP.Text);
                p.quantity = qty;

                int existingQty = p.GetQuantityByName(p.name);
                if (existingQty > 0)
                {
                    MessageBox.Show("Product already added! Please update the quantity.");
                    return;
                }

                bool success = p.Add(p);
                if (success)
                {
                    MessageBox.Show("Product added successfully!");
                    Clear();
                    dataGridView1.DataSource = p.ShowAllProduct();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                p.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                bool x = p.Delete(p);
                if (x == true)
                {
                    MessageBox.Show("Successfully deleted!!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong!! try Again!!");
                }
                DataTable dt = p.ShowAllProduct();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }

        }

        private void show_Click(object sender, EventArgs e)
        {
        
                DataTable dt = p.ShowAllProduct();
                dataGridView1.DataSource = dt;
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] {
                "bakorkhani","dry cake","einkon biscuit","brown bread","fulko bread",
                "buttermilk biscuit","vanilla cake","strawberry cake","chocolate cake",
                "happy bear","vanilla bear","strawberry bear"
            });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

         
            dataGridView1.DataSource = p.ShowAllProduct();
        }

         private void update_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a product first");
                    return;
                }

                if (!int.TryParse(PQ.Text, out int qty) || !double.TryParse(PP.Text, out double price))
                {
                    MessageBox.Show("Invalid quantity or price");
                    return;
                }

                p.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                p.name = comboBox1.Text;
                p.price = price;
                p.quantity = qty;

                bool success = p.Update(p);
                if (success)
                {
                    MessageBox.Show("Product updated successfully!");
                    dataGridView1.DataSource = p.ShowAllProduct();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
