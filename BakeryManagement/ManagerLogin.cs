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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "Select Count(*) from manager Where userName='" + mloguser.Text + "' and password='" + mlogpass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                ManagerDashboard rf = new ManagerDashboard();
                rf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid!! Try Again");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mlogpass.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LogIn1 l = new LogIn1();
            l.Show();
            this.Hide();
        }
    }
    }

