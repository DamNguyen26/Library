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
            if (this. txtUser.Text == "dammit2525@gmail.com" && this.txtPass.Text == "Damnguyen26")
            {
                MessageBox.Show("Login successful. Student");
                Form2 fm = new Form2();
                fm.Show();
            }
            else if(this.txtUser.Text == "dammit2525@yahoo.com.vn" && this.txtPass.Text == "Damnguyen"){
                MessageBox.Show("Login successful. Admin");
                Form3 fm = new Form3();
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
