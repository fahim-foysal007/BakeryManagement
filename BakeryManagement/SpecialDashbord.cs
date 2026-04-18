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
    public partial class SpecialDashbord : Form
    {
        public SpecialDashbord()
        {
            InitializeComponent();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LogIn1 lg = new LogIn1();
            lg.Show();
            this.Hide();
        }

        private void buttonBB_Click(object sender, EventArgs e)
        {
            CustomerDashboard cd = new CustomerDashboard();
            cd.Show();
            this.Hide();
        }

        private void buttonCP_Click(object sender, EventArgs e)
        {
            CakeDashboard cd = new CakeDashboard();
            cd.Show();
            this.Hide();
        }

        private void SpecialDashbord_Load(object sender, EventArgs e)
        {

        }

        private void buttonSI_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
            this.Hide();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            Purchase P = new Purchase();
            P.Show();
            this.Hide();
        }
    }
}
