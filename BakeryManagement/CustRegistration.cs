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
    public partial class CustRegistration : Form
    {
        public CustRegistration()
        {
            InitializeComponent();
        }
        Customer c = new Customer();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\BakeryManagement.mdf;Integrated Security=True;Connect Timeout=30";

        private void BackButton_Click(object sender, EventArgs e)
        {
            WelcomePage wb = new WelcomePage();
            wb.Show();
            this.Hide();
        }

        public void Clear()
        {
            tbname.Text = null;
            tbUsername.Clear();
            tbPassword.Clear();
            tbEmail.Clear();
            tbAddress.Clear();
            tbContact.Clear();
            tbConfirmPass.Clear();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbConfirmPass.Text))
                {
                    MessageBox.Show("Password fields cannot be empty", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbPassword.Text != tbConfirmPass.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                c.Name = tbname.Text;
                c.Username = tbUsername.Text;
                c.passsword = Convert.ToInt32(tbPassword.Text); 
                c.Address = tbAddress.Text;
                c.Email = tbEmail.Text;
                c.contact = Convert.ToInt32(tbContact.Text);

                bool x = c.save(c);

                if (x)
                {
                    MessageBox.Show("Registration successful!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerLogin c = new CustomerLogin();
            c.Show();
            this.Hide();
        }
    }
}
