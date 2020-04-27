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
    public partial class BuyingProductPrice : Form
    {
        public BuyingProductPrice()
        {
            InitializeComponent();
        }

        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.buyingProductPriceTableAdapter taBuyingPrice = new dsMonFactoryTableAdapters.buyingProductPriceTableAdapter();
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            


        }


        //btnAdd's action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = -1;
            //check txtRice
            if (txtRice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Rice Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRice.Focus();
                txtRice.SelectAll();
            }
            //check txtSala
            else if (txtSaLa.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Sala Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaLa.Focus();
                txtSaLa.SelectAll();
            }
            //check txtKyaw
            else if (txtKyaw.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Kyaw Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKyaw.Focus();
                txtKyaw.SelectAll();
            }
            //check txtGyi
            else if (txtGyi.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Gyi Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGyi.Focus();
                txtGyi.SelectAll();
            }
            //check txtTay
            else if (txtTay.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Tay Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTay.Focus();
                txtTay.SelectAll();
            }
            //check txtSoont
            else if (txtSoont.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Soont Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoont.Focus();
                txtSoont.SelectAll();
            }
            //check txtPhwalNu
            else if (txtPhwalNu.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Phwal Nu Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhwalNu.Focus();
                txtPhwalNu.SelectAll();
            }
            //check txtSatKyatKha
            else if (txtSatKyatKha.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Sat Kyat Kha!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSatKyatKha.Focus();
                txtSatKyatKha.SelectAll();
            }
            else
            {
                //update buying price
                id = taBuyingPrice.UpdateBuyingPrice(Convert.ToDecimal(txtRice.Text), Convert.ToDecimal(txtSaLa.Text), Convert.ToDecimal(txtKyaw.Text), Convert.ToDecimal(txtGyi.Text), Convert.ToDecimal(txtTay.Text), Convert.ToDecimal(txtSoont.Text), Convert.ToDecimal(txtPhwalNu.Text), Convert.ToDecimal(txtSatKyatKha.Text));
                if (id > 0)
                {

                    MessageBox.Show("Update Successful!");

                    //fill data to BuyingProductPrice form
                    taBuyingPrice.FillBuyingPrice(dsMonFactory.buyingProductPrice);

                    txtGyi.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyi"].ToString();
                    txtKyaw.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyaw"].ToString();
                    txtPhwalNu.Text = dsMonFactory.buyingProductPrice.Rows[0]["phwalnu"].ToString();
                    txtRice.Text = dsMonFactory.buyingProductPrice.Rows[0]["rice"].ToString();
                    txtSaLa.Text = dsMonFactory.buyingProductPrice.Rows[0]["sala"].ToString();
                    txtSatKyatKha.Text = dsMonFactory.buyingProductPrice.Rows[0]["satkyyatkha"].ToString();
                    txtSoont.Text = dsMonFactory.buyingProductPrice.Rows[0]["soont"].ToString();
                    txtTay.Text = dsMonFactory.buyingProductPrice.Rows[0]["tay"].ToString();

                }
            }
        }


        //load data to BuyingProuductPrice form
        private void BuyingProductPrice_Load(object sender, EventArgs e)
        {
            taBuyingPrice.FillBuyingPrice(dsMonFactory.buyingProductPrice);
            
            txtGyi.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyi"].ToString();
            txtKyaw.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyaw"].ToString();
            txtPhwalNu.Text = dsMonFactory.buyingProductPrice.Rows[0]["phwalnu"].ToString();
            txtRice.Text = dsMonFactory.buyingProductPrice.Rows[0]["rice"].ToString();
            txtSaLa.Text = dsMonFactory.buyingProductPrice.Rows[0]["sala"].ToString();
            txtSatKyatKha.Text = dsMonFactory.buyingProductPrice.Rows[0]["satkyyatkha"].ToString();
            txtSoont.Text = dsMonFactory.buyingProductPrice.Rows[0]["soont"].ToString();
            txtTay.Text = dsMonFactory.buyingProductPrice.Rows[0]["tay"].ToString();
        }
    }
}
