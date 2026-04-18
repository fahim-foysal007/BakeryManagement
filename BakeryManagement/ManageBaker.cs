using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class ManageBaker : Form
    {
        public ManageBaker()
        {
            InitializeComponent();
        }
        Baker b = new Baker();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        
        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 cb = new LogIn1();
            cb.Show();
            this.Hide();
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            AdminDashboard mm = new AdminDashboard();
            mm.Show();
            this.Hide();
        }

        private void buttonCM_Click(object sender, EventArgs e)
        {
            ManageBaker cb = new ManageBaker();
            cb.Show();

        }
        public void Clear()
        {
            BN.Text = null;
            BU.Clear();
            BP.Clear();
            BS.Clear();
            BCN.Clear();

        }

        private void save_Click(object sender, EventArgs e)
        {
            b.Name = BN.Text;
            b.Username = BU.Text;
            b.passsword = Convert.ToInt32(BP.Text);
            b.salary = Convert.ToDouble(BS.Text);
            b.contact = Convert.ToInt32(BCN.Text);

            bool x = b.save(b);
            if (x == true)
            {
                MessageBox.Show("Successfully added!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = b.showBaker();
            dataGridView1.DataSource = dt;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            b.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            bool x = b.Delete(b);
            if (x == true)
            {
                MessageBox.Show("Successfully deleted!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = b.showBaker();
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            b.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            b.Name = BN.Text;
            b.Username = BU.Text;
            b.passsword = Convert.ToInt32(BP.Text);
            b.salary = Convert.ToDouble(BS.Text);
            b.contact = Convert.ToInt32(BCN.Text);

            bool x = b.update(b);
            if (x == true)
            {
                MessageBox.Show("Successfully Updated!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = b.showBaker();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            BN.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            BU.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            BP.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            BS.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            BCN.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
        }

        private void show_Click(object sender, EventArgs e)
        {
            DataTable dt = b.showBaker();
            dataGridView1.DataSource = dt;
        }
    }

}
