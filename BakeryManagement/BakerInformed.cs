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
    public partial class BakerInformed : Form
    {
        public BakerInformed()
        {
            InitializeComponent();
        }
        Product p = new Product();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        private void buttonPM_Click(object sender, EventArgs e)
        {
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
            this.Hide();
        }

        private void buttonCM_Click(object sender, EventArgs e)
        {
            CustomerManage lg = new CustomerManage();
            lg.Show();
            this.Hide();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 lg = new LogIn1();
            lg.Show();
            this.Hide();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DataTable dt = p.ShowAllProduct();
            dataGridView1.DataSource = dt;
        }

        private void sent_Click(object sender, EventArgs e)
        {
            string message = richTextBox.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message!");
                return;
            }

            BakerManage.AddMessage(message); 
            richTextBox.Clear();

            MessageBox.Show("Message sent successfully!");
        }
    }
}
