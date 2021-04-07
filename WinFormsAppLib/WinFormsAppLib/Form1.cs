using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "dammit2525@gmail.com";
            string pass = "Damnguyen26";
            if (user.Equals(txtUser.Text) && pass.Equals(txtPass.Text))
            {
                MessageBox.Show("Login successful.");
                Form2 fm = new Form2();
                fm.Show();
            }
            else
                MessageBox.Show("Nhap lai di ban oi");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
