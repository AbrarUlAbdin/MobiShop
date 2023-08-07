using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            picture1.Visible = false;
            uC_NewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            search1.Visible = false;
            uC_Record1.Visible = false;
            uC_DeletePhone1.Visible = false;
            enableDisable(false, false, false);
            uC_Login1.Visible = true;
            panel1.Visible = false;
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            uC_NewPhone1.Visible = true;
            uC_NewPhone1.BringToFront();
            uC_Customer1.Visible = false;
            uC_Record1.Visible = false;
            uC_DeletePhone1.Visible = false;
            picture1.Visible = false;
            search1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            search1.Visible = true;
            search1.BringToFront();
            uC_NewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Record1.Visible = false;
            uC_DeletePhone1.Visible = false;
            picture1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_Record1.Visible = true;
            uC_Customer1.BringToFront();
            uC_NewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            search1.Visible = false;
            uC_DeletePhone1.Visible = false;
            picture1.Visible = false;
        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
            uC_NewPhone1.Visible = false;
            search1.Visible = false;
            uC_DeletePhone1.Visible = false;
            picture1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableDisable(true, true, true);
        }
        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPass.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableDisable(false, false, false);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "009988")
            {
                panel2.Enabled = true;
                uC_DeletePhone1.Visible = true;
                uC_DeletePhone1.BringToFront();
                enableDisable(false, false, false);
                txtPass.Clear();
            }
            else
            {
                txtPass.Clear();
            }
        }
        private void uC_Login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            picture1.Visible = true;
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure You want To Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                uC_Login1.Visible = true;  
                uC_Login1.BringToFront();
                panel1.Visible = false;
                picture1.Visible = false;
                uC_NewPhone1.Visible = false;
                uC_Customer1.Visible = false;
                search1.Visible = false;
                uC_Record1.Visible = false;
                uC_DeletePhone1.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewUser NU = new NewUser();
            NU.Show();
        }

        private void picture1_Load(object sender, EventArgs e)
        {

        }
    }
}
