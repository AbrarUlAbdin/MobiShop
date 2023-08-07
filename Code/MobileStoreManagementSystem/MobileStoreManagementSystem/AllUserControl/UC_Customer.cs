using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileStoreManagementSystem.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        string query;

        public UC_Customer()
        {
            InitializeComponent();
        }

        public void setCombobox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void front_Click(object sender, EventArgs e)
        {

        }

        private void rare_Click(object sender, EventArgs e)
        {

        }

        private void expandable_Click(object sender, EventArgs e)
        {

        }

        private void ramLable_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtIMEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from NewMobileT where mname = '" + txtModel.Text + "'";
            DataSet ds = fn.getData(query);

            ramLable.Text = ds.Tables[0].Rows[0][3].ToString();
            internalLable.Text = ds.Tables[0].Rows[0][4].ToString();
            expandable.Text = ds.Tables[0].Rows[0][5].ToString();
            rare.Text = ds.Tables[0].Rows[0][7].ToString();
            front.Text = ds.Tables[0].Rows[0][8].ToString();
            finger.Text = ds.Tables[0].Rows[0][9].ToString();
            price.Text = ds.Tables[0].Rows[0][12].ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            string cname = txtCompany.Text;
            query= "select mname from NewMobileT where cname = '"+cname+"'";
            setCombobox(query, txtModel);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void finger_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtModel.Text != "" && txtEmail.Text != "" &&
                txtAddress.Text != "" && txtCompany.Text != "" && txtIMEI.Text != "" && txtContact.Text != "")
            {
                string name = txtName.Text;
                string gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string company = txtCompany.Text;
                string model = txtModel.Text;
                string imei = txtIMEI.Text;

                query = "insert into Customer(cname,gender,contact,email,caddress,company,model,imei) values('" + name + "','" + gender + "'," + contact + ",'" + email + "','" + address + "','" + company + "','" + model + "','" + imei + "')";
                fn.setData(query);

                txtName.Clear();
                txtContact.Clear();
                txtGender.StartIndex = -1;
                txtIMEI.Clear();
                txtCompany.StartIndex = -1;
                txtEmail.Clear();
                txtModel.StartIndex = -1;
                txtAddress.Clear();
            }
            else
            {
                MessageBox.Show("Fill All The Fields..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct cname from NewMobileT";
            setCombobox(query, txtCompany);
        }
    }
}
