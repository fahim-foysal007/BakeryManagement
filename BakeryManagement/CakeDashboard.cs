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
    public partial class CakeDashboard : Form
    {
        public CakeDashboard()
        {
            InitializeComponent();
        }

        private void CakeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonBB_Click(object sender, EventArgs e)
        {
            CustomerDashboard cd = new CustomerDashboard();
            cd.Show();
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

        private void Purchase_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
            this.Hide();
        }
    }
}
