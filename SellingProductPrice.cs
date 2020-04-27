using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellingProduct
{
    public partial class SellingProductPrice : Form
    {
        public SellingProductPrice()
        {
            InitializeComponent();
            callUI();
        }


        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.sellingProductPriceTableAdapter taSellingPrice = new dsMonFactoryTableAdapters.sellingProductPriceTableAdapter();


        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateSellingProductPrice sp = new UpdateSellingProductPrice();
            sp.Show();
        }
        private void callUI()
        {
            MainForm method = new MainForm();
            method.openChildForm(new UpdateSellingProductPrice());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = -1;
            //check txtRice2kgPrice
            if (txtRice2kgPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRice2kgPrice.Focus();
                txtRice2kgPrice.SelectAll();
            }
            //check txtRice6kgPrice
            else if (txtRice6kgPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRice6kgPrice.Focus();
                txtRice6kgPrice.SelectAll();
            }
            //check txtRice12kgPrice
            else if (txtRice12kgPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRice12kgPrice.Focus();
                txtRice12kgPrice.SelectAll();
            }
            //check txtRice54lbPrice
            else if (txtRice54lbPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRice54lbPrice.Focus();
                txtRice54lbPrice.SelectAll();
            }
            //check txtRice108lbPrice
            else if (txtRice108lbPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRice108lbPrice.Focus();
                txtRice108lbPrice.SelectAll();
            }
            //check txtSaLaPrice
            else if (txtSaLaPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaLaPrice.Focus();
                txtSaLaPrice.SelectAll();
            }
            //check txtKyawPrice
            else if (txtKyawPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKyawPrice.Focus();
                txtKyawPrice.SelectAll();
            }
            //check txtGyiPrice
            else if (txtGyiPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGyiPrice.Focus();
                txtGyiPrice.SelectAll();
            }
            //check txtTayPrice
            else if (txtTayPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTayPrice.Focus();
                txtTayPrice.SelectAll();
            }
            //check txtSoontPrice
            else if (txtSoontPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoontPrice.Focus();
                txtSoontPrice.SelectAll();
            }
            //check txtPhwalPrice
            else if (txtPhwalPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhwalPrice.Focus();
                txtPhwalPrice.SelectAll();
            }
            //check txtBriquette10ptPrice
            else if (txtBriquette10ptPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBriquette10ptPrice.Focus();
                txtBriquette10ptPrice.SelectAll();
            }
            //check txtBriquette20ptPrice
            else if (txtBriquette20ptPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice2kg Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBriquette20ptPrice.Focus();
                txtBriquette20ptPrice.SelectAll();
            }
            //check
            else
            {
                //update selling product price 
                id = taSellingPrice.UpdateSellingPrice(Convert.ToInt32(txtRice2kgPrice.Text), Convert.ToInt32(txtRice6kgPrice.Text), Convert.ToInt32(txtRice12kgPrice.Text), Convert.ToInt32(txtRice54lbPrice.Text), Convert.ToInt32(txtRice108lbPrice.Text), Convert.ToInt32(txtSaLaPrice.Text), Convert.ToInt32(txtKyawPrice.Text), Convert.ToInt32(txtGyiPrice.Text), Convert.ToInt32(txtTayPrice.Text), Convert.ToInt32(txtSoontPrice.Text), Convert.ToInt32(txtPhwalPrice.Text), Convert.ToInt32(txtBriquette10ptPrice.Text), Convert.ToInt32(txtBriquette20ptPrice.Text));

                if(id > 0)
                {

                    MessageBox.Show("Update Selling Price Successful!!");
                    taSellingPrice.FillSellingPrice(dsMonFactory.sellingProductPrice);


                    txtRice2kgPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice2kg"].ToString();
                    txtRice6kgPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice6kg"].ToString();
                    txtRice12kgPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice12kg"].ToString();
                    txtRice54lbPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice54lb"].ToString();
                    txtRice108lbPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice108lb"].ToString();
                    txtSaLaPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["sala108lb"].ToString();
                    txtKyawPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["kyaw108lb"].ToString();
                    txtGyiPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["gyi108lb"].ToString();
                    txtTayPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["tay108lb"].ToString();
                    txtSoontPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["soont108lb"].ToString();
                    txtPhwalPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["phwalnu18pt"].ToString();
                    txtBriquette10ptPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["briquette10pt"].ToString();
                    txtBriquette20ptPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["briquette20pt"].ToString();
                }

                
            }

        }


        //load data to selling product price form
        private void SellingProductPrice_Load(object sender, EventArgs e)
        {
            taSellingPrice.FillSellingPrice(dsMonFactory.sellingProductPrice);


            txtRice2kgPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice2kg"].ToString();
            txtRice6kgPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice6kg"].ToString();
            txtRice12kgPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice12kg"].ToString();
            txtRice54lbPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice54lb"].ToString();
            txtRice108lbPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice108lb"].ToString();
            txtSaLaPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["sala108lb"].ToString();
            txtKyawPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["kyaw108lb"].ToString();
            txtGyiPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["gyi108lb"].ToString();
            txtTayPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["tay108lb"].ToString();
            txtSoontPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["soont108lb"].ToString();
            txtPhwalPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["phwalnu18pt"].ToString();
            txtBriquette10ptPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["briquette10pt"].ToString();
            txtBriquette20ptPrice.Text = dsMonFactory.sellingProductPrice.Rows[0]["briquette20pt"].ToString();


        }
    }
}
