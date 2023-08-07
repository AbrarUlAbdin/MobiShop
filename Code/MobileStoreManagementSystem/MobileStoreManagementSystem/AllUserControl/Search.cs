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
    public partial class Search : UserControl
    {
        function fn = new function();
        string query;
        public Search()
        {
            InitializeComponent();
        }
        private void Search_Enter(object sender, EventArgs e)
        {
            query = "select * from NewMobileT";
            DataSet ds = fn.getData(query);
            guna2DataGridView4.DataSource = ds.Tables[0];
        }
        int bid;
        private void guna2DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView4.Rows[e.ColumnIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(guna2DataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from NewMobileT where MID = " + bid + "";
            DataSet ds = fn.getData(query);
            companylable.Text = ds.Tables[0].Rows[0][1].ToString();
            modellable.Text = ds.Tables[0].Rows[0][2].ToString();
            RamLable.Text = ds.Tables[0].Rows[0][3].ToString();
            interLable.Text = ds.Tables[0].Rows[0][4].ToString();
            externLable.Text = ds.Tables[0].Rows[0][5].ToString();
            displayLable.Text = ds.Tables[0].Rows[0][6].ToString();
            rareLable.Text = ds.Tables[0].Rows[0][7].ToString();
            frontLable.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerLable.Text = ds.Tables[0].Rows[0][9].ToString();
            simLable.Text = ds.Tables[0].Rows[0][10].ToString();
            networkLable.Text = ds.Tables[0].Rows[0][11].ToString();
            priceLable.Text = ds.Tables[0].Rows[0][12].ToString();
        }
    }
}
