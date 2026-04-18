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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        Manager m = new Manager();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 cb = new LogIn1();
            cb.Show();
            this.Hide();
        }

        private void buttonCM_Click(object sender, EventArgs e)
        {
            ManageBaker mb = new ManageBaker();
            mb.Show();
            this.Hide();
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            mname.Text = null;
            musername.Clear();
            mpass.Clear();
            msalary.Clear();
            mcontact.Clear();
           
        }
        private void save_Click(object sender, EventArgs e)
        {
            m.Name = mname.Text;
            m.Username = musername.Text;
            m.passsword = Convert.ToInt32(mpass.Text);
            m.salary = Convert.ToDouble(msalary.Text);
            m.contact = Convert.ToInt32(mcontact.Text);

            bool x = m.save(m);
            if (x == true)
            {
                MessageBox.Show("Successfully added!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = m.showManager();
            dataGridView1.DataSource = dt;

        }

        private void delete_Click(object sender, EventArgs e)
        {

            m.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            bool x = m.Delete(m);
            if (x == true)
            {
                MessageBox.Show("Successfully deleted!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = m.showManager();
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            m.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            m.Name = mname.Text;
            m.Username = musername.Text;
            m.passsword = Convert.ToInt32(mpass.Text);
            m.salary = Convert.ToDouble(msalary.Text);
            m.contact = Convert.ToInt32(mcontact.Text);

            bool x = m.update(m);
            if (x == true)
            {
                MessageBox.Show("Successfully Updated!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = m.showManager();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int row_index = e.RowIndex;
            mname.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            musername.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            mpass.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            msalary.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            mcontact.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
          
        }

        private void show_Click(object sender, EventArgs e)
        {

            DataTable dt = m.showManager();
            dataGridView1.DataSource = dt;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
