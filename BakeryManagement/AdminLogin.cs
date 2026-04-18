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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {  LogIn1 cb = new LogIn1();
            cb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string q = "Select Count(*) from Admin Where userName='" + Aduser.Text + "' and password='" + Adpass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                AdminDashboard b = new AdminDashboard();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid!! Try Again");
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Adpass.UseSystemPasswordChar = !checkBox1.Checked;


        }
    }
}
