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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CakeDashboard bd = new CakeDashboard();
            bd.Show();
            this.Hide();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 lg = new LogIn1();
            lg.Show();
            this.Hide();
        }

        private void buttonSI_Click(object sender, EventArgs e)
        {
            SpecialDashbord cd = new SpecialDashbord();
            cd.Show();
            this.Hide();
        }

        private void buttonBB_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
            this.Hide();
        }
    }
}
