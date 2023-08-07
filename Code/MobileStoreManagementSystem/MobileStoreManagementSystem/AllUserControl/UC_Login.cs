using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MobileStoreManagementSystem
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            Toshowlab.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            pan.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }

  

        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;
                string ABC = txtUseName.Text;
                try
                {
                    StreamReader Sr = new StreamReader(@"Users/" + ABC + ".txt");
                    string n = Sr.ReadLine();  //AttaUllah
                    string p = Sr.ReadLine();  //009988

                    if (txtUseName.Text.Equals(n) && txtPass.Text.Equals(p))
                    {
                        this.Hide();
                        timer1.Stop();
                    }
                    else
                    {
                        pan.Visible = true;
                        Toshowlab.Visible = true;
                        timer1.Stop();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message + "\nTry Valid User Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UC_Login_Load(object sender, EventArgs e)
        {
            pan.Enabled = true;
        }

        private void guna2WinProgressIndicator1_Click(object sender, EventArgs e)
        {
            pan.Visible = true;
        }
    }
}
