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
    public partial class UC_DeletePhone : UserControl
    {
        function fn = new function();
        string query;
        public UC_DeletePhone()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from NewMobileT where cname like '" + txtSearch.Text + "%' or mname like '"+txtSearch.Text+"'";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        private void UC_DeletePhone_Enter(object sender, EventArgs e)
        {
            query = "select * from NewMobileT ";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        int bid;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from NewMobileT where MID = " + bid + "";
                if(MessageBox.Show("Deleting Record Of "+bid+"","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    fn.setData(query);
                }
                else
                {
                    MessageBox.Show("You Cancelled The Operation..", "Back <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
