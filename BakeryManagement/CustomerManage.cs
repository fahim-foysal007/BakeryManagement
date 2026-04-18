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
    public partial class CustomerManage : Form
    {
        public CustomerManage()
        {
            InitializeComponent();
        }
        Customer c = new Customer();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        private void buttonPM_Click(object sender, EventArgs e)
        {
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
            this.Hide();
        }

        private void buttonBI_Click(object sender, EventArgs e)
        {
            BakerInformed bi = new BakerInformed();
            bi.Show();
            this.Hide();

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 lg = new LogIn1();
            lg.Show();
            this.Hide();
        }
        public void Clear()
        {
            CN.Text = null;
            CU.Clear();
            CP.Clear();
            CA.Clear();
            CE.Clear();
            CCN.Clear();
        }
        private void show_Click(object sender, EventArgs e)
        {
            DataTable dt = c.showAllCustomer();
            dataGridView1.DataSource = dt;
        }

        private void save_Click(object sender, EventArgs e)
        {
            c.Name = CN.Text;
            c.Username = CU.Text;
            c.passsword= Convert.ToInt32(CP.Text);
            c.Address=CA.Text;
            c.Email = CE.Text;
            c.contact = Convert.ToInt32(CCN.Text);

            bool x = c.save(c);
            if (x == true)
            {
                MessageBox.Show("Successfully added!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = c.showAllCustomer();
            dataGridView1.DataSource = dt;
        
         }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            CN.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            CU.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            CP.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            CA.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            CE.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            CCN.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
           
                c.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                c.Name = CN.Text;
                c.Username = CU.Text;
                c.passsword = Convert.ToInt32(CP.Text);
                c.Address = CA.Text;
                c.Email = CE.Text;
                c.contact = Convert.ToInt32(CCN.Text);

                bool x = c.update(c);
                if (x == true)
                {
                    MessageBox.Show("Successfully Updated!!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong!! try Again!!");
                }
                DataTable dt = c.showAllCustomer();
                dataGridView1.DataSource = dt;
         
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();

            string q = "Select * from customer Where Name Like '%" + Searchbox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(q, sqc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void delete_Click(object sender, EventArgs e)
        {

            c.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            bool x = c.Delete(c);
            if (x == true)
            {
                MessageBox.Show("Successfully deleted!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = c.showAllCustomer();
            dataGridView1.DataSource = dt;
        }

        private void buttonCM_Click(object sender, EventArgs e)
        {

        }
    }
    }
