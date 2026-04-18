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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "Select Count(*) from customer Where userName='" + tuser.Text + "' and password='" + tpass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                CustomerDashboard rf = new CustomerDashboard();
                rf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid!! Try Again");
            }
        }

       

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            tpass.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LogIn1 l = new LogIn1();
            l.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CustRegistration r = new CustRegistration();
            r.Show();
            this.Hide();
        }
    }
    }

