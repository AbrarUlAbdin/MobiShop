using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MobileStoreManagementSystem
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string N = txtName.Text;
            string P = txtPassword.Text;
            string E = txtMail.Text;

            StreamWriter SW = new StreamWriter(@"Users/" + N + ".txt");

            SW.WriteLine(N);
            SW.WriteLine(P);
            SW.WriteLine(E);
            SW.Flush();
            SW.Close();
            MessageBox.Show("New User Create Successfully ...");

            txtName.Text = txtPassword.Text = txtMail.Text = null;
            this.Dispose();

        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
