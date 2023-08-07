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
    public partial class UC_NewPhone : UserControl
    {
        function fn = new function();
        string query;
        public UC_NewPhone()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtmodel.Clear();
            txtRam.StartIndex = -1;
            txtInternal.StartIndex = -1;
            txtExpandable.StartIndex = -1;
            txtDisplay.StartIndex = -1;
            txtRare.StartIndex = -1;
            txtFront.StartIndex = -1;
            txtFigerprint.StartIndex = -1;
            txtPrice.Clear();
            txtNetwork.StartIndex = -1;
            txtSim.StartIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtRam.Text != "" && txtmodel.Text != "" && txtFigerprint.Text != "" && txtExpandable.Text != "" && txtInternal.Text != "" && txtDisplay.Text != "" && txtFront.Text != "" && txtRare.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {
                string company = txtCompany.Text;
                string model = txtmodel.Text;
                string ram = txtRam.Text;
                string intern = txtInternal.Text;
                string exter = txtExpandable.Text;
                string display = txtDisplay.Text;
                string rare = txtRare.Text;
                string fron = txtFront.Text;
                string finger = txtFigerprint.Text;
                string sim = txtSim.Text;
                string network = txtNetwork.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "insert into NewMobileT (cname,mname,ram,intern,exter,display,rare,front,finger,sim,network,price) " +
                    "values('" + company + "','" + model + "','" + ram + "','" + intern + "'," +
                    "'" + exter + "','" + display + "','" + rare + "','" + fron + "'," +
                    "'" + finger + "','" + sim + "','" + network + "'," + price + ")";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
