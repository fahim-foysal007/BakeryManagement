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
    public partial class LogIn1 : Form
    {
        public LogIn1()
        {
            InitializeComponent();
        }

        private void AdminLogInbutton_Click(object sender, EventArgs e)
        {
            AdminLogin cb = new AdminLogin();
            cb.Show();
            this.Hide();
        }

        private void CustomerLogInButton_Click(object sender, EventArgs e)
        {
            CustomerLogin cb = new CustomerLogin();
            cb.Show();
            this.Hide();
        }

        private void ManagerLoginbutton_Click(object sender, EventArgs e)
        {
            ManagerLogin md = new ManagerLogin();
            md.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WelcomePage lb = new WelcomePage();
            lb.Show();
            this.Hide();
        }

        private void BakerLoginbutton_Click(object sender, EventArgs e)
        {
            Bakerlogin b = new Bakerlogin();
            b.Show();
            this.Hide();
        }
    }
}
