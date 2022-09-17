using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsForms.Source
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            if (String.IsNullOrEmpty(email) && String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Either email is empty or password!!!", "Warning");
            }
            else
            {
                string res = "Email : " + email + "\nPassword : " + password;
                MessageBox.Show(res, "Login Successful");
            }
        }
    }
}
