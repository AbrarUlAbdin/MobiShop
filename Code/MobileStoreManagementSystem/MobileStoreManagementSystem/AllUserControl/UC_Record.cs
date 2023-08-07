using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreManagementSystem.AllUserControl
{
    public partial class UC_Record : UserControl
    {
        function fn = new function();
        string query;
        public UC_Record()
        {
            InitializeComponent();
        }
        
        Boolean flag;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.SelectedIndex == 0)
            {
                flag = false;
                labletoset.Text = "Enter Customer Name";
            }
            else if (txtSearch.SelectedIndex == 1)
            {
                flag = true;
                labletoset.Text = "Enter IMEI ";
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                query = "select * from Customer where cname like '" + txtcustomer.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from Customer where imei like '" + txtcustomer.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void UC_Record_Enter(object sender, EventArgs e)
        {
            query = "select * from Customer";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        
    }
}
