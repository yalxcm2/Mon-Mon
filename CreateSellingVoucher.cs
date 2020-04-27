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
    public partial class CreateSellingVoucher : Form
    {

        int voucherID;
        Boolean isCreate = false;
        Boolean isUpdate = false;

        Double rice2kgAmount = 0;
        Double rice6kgAmount = 0;
        Double rice12kgAmount = 0;
        Double rice54lbAmount = 0;
        Double rice108lbAmount = 0;
        Double sala108lbAmount = 0;
        Double kyaw108lbAmount = 0;
        Double gyi108lbAmount = 0;
        Double tay108lbAmount = 0;
        Double soont108lbAmount = 0;
        Double phwalNu18ptAmount = 0;
        Double briquette10ptAmount = 0;
        Double briquette20ptAmount = 0;






        public CreateSellingVoucher()
        {
            InitializeComponent();
        }

        public CreateSellingVoucher(int UpdateID, Boolean isUpdate)
        {
            this.isUpdate = isUpdate;
            this.voucherID = UpdateID;
            InitializeComponent();
        }


        //declare data table
        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.sellingVoucherTableAdapter taSellingVoucher = new dsMonFactoryTableAdapters.sellingVoucherTableAdapter();
        dsMonFactoryTableAdapters.sellingDetailTableAdapter taSellingDetail = new dsMonFactoryTableAdapters.sellingDetailTableAdapter();
        dsMonFactoryTableAdapters.sellingProductPriceTableAdapter taSellingPrice = new dsMonFactoryTableAdapters.sellingProductPriceTableAdapter();


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //btnAdd's action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sellingDetailID = -1;
            int sellingVoucherID = -1;

            //check txtName
            if (txtName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Customer Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                txtName.SelectAll();
            }


            //check txtAddress
            else if (txtAddress.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                txtAddress.SelectAll();
            }

            //check txtPhNo
            else if (txtPhNo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Customer Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhNo.Focus();
                txtPhNo.SelectAll();
            }

            else
            {
                //update condition
                if (isUpdate)
                {
                    int deleteSellingDetailID = -1;
                    deleteSellingDetailID = taSellingDetail.DeleteSellingDetail(voucherID);

                    if(deleteSellingDetailID > 0)
                    {
                        //check txtRice2kgQty is empty or not
                        if (!txtRice2kgQty.Text.Equals(string.Empty))
                        {

                            //insert rice2kg selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Rice 2 Kg", Convert.ToInt32(txtRice2kgQty.Text), txtRice2kgRate.Text);
                        }

                        //check txtRice6kgQty is empty or not
                        if (!txtRice6kgQty.Text.Equals(string.Empty))
                        {

                            //insert rice6kg selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Rice 6 Kg", Convert.ToInt32(txtRice6kgQty.Text), txtRice6kgRate.Text);
                        }

                        if (!txtRice12kgQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Rice 12 Kg", Convert.ToInt32(txtRice12kgQty.Text), txtRice12kgRate.Text);
                        }

                        if (!txtRice24kgQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Rice 54 lb", Convert.ToInt32(txtRice24kgQty.Text), txtRice54lbRate.Text);
                        }

                        //check txtRice108pQty is empty or not
                        if (!txtRice108pQty.Text.Equals(string.Empty))
                        {
                            //insert rice108lb selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Rice 108 lb", Convert.ToInt32(txtRice108pQty.Text), txtRice108lbRate.Text);
                        }

                        if (!txtSaLaQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Sala 108 lb", Convert.ToInt32(txtSaLaQty.Text), txtSaLaRate.Text);
                        }

                        if (!txtKyawQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Kyaw 108 lb", Convert.ToInt32(txtKyawQty.Text), txtKyawRate.Text);
                        }

                        if (!txtGyiQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Gyi 108 lb", Convert.ToInt32(txtGyiQty.Text), txtGyiRate.Text);
                        }

                        if (!txtTayQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Tay 108 lb", Convert.ToInt32(txtTayQty.Text), txtTayRate.Text);
                        }


                        //check txtSoontQty is empty or not
                        if (!txtSoontQty.Text.Equals(string.Empty))
                        {
                            //insert soont selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Soont 108 lb", Convert.ToInt32(txtSoontQty.Text), txtSoontRate.Text);
                        }

                        if (!txtPhwalNuQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Phwal Nu 18 PT", Convert.ToInt32(txtPhwalNuQty.Text), txtPhwalNuRate.Text);
                        }

                        if (!txtPellet10vQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Briquette 10 PT", Convert.ToInt32(txtPellet10vQty.Text), txtBriquette10vRate.Text);
                        }

                        if (!txtPellet20vQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(voucherID, "Briquette 20 PT", Convert.ToInt32(txtPellet20vQty.Text), txtBriquette20vRate.Text);
                        }


                        //if selling detail add successful
                        if (sellingDetailID > 0)
                        {
                            MessageBox.Show("Update Successful");
                            this.Close();
                        }
                    }
                }

                //create new selling voucher and selling detail
                else
                {

                    sellingVoucherID = taSellingVoucher.InsertSellingVoucher(txtName.Text, txtAddress.Text, txtPhNo.Text, dtpDate.Value);
                    if(sellingVoucherID > 0)
                    {
                        int getSellingVoucherMax = taSellingVoucher.findMaxFromSellingVoucher(dsMonFactory.sellingVoucher);
                        //check txtRice2kgQty is empty or not
                        if (!txtRice2kgQty.Text.Equals(string.Empty))
                        {

                            //insert rice2kg selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Rice 2 Kg", Convert.ToInt32(txtRice2kgQty.Text), txtRice2kgRate.Text);
                        }

                        //check txtRice6kgQty is empty or not
                        if (!txtRice6kgQty.Text.Equals(string.Empty))
                        {

                            //insert rice6kg selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Rice 6 Kg", Convert.ToInt32(txtRice6kgQty.Text), txtRice6kgRate.Text);
                        }

                        if (!txtRice12kgQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Rice 12 Kg", Convert.ToInt32(txtRice12kgQty.Text), txtRice12kgRate.Text);
                        }

                        if (!txtRice24kgQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Rice 54 lb", Convert.ToInt32(txtRice24kgQty.Text), txtRice54lbRate.Text);
                        }

                        //check txtRice108pQty is empty or not
                        if (!txtRice108pQty.Text.Equals(string.Empty))
                        {
                            //insert rice108lb selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Rice 108 lb", Convert.ToInt32(txtRice108pQty.Text), txtRice108lbRate.Text);
                        }

                        if (!txtSaLaQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Sala 108 lb", Convert.ToInt32(txtSaLaQty.Text), txtSaLaRate.Text);
                        }

                        if (!txtKyawQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Kyaw 108 lb", Convert.ToInt32(txtKyawQty.Text), txtKyawRate.Text);
                        }

                        if (!txtGyiQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Gyi 108 lb", Convert.ToInt32(txtGyiQty.Text), txtGyiRate.Text);
                        }

                        if (!txtTayQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Tay 108 lb", Convert.ToInt32(txtTayQty.Text), txtTayRate.Text);
                        }


                        //check txtSoontQty is empty or not
                        if (!txtSoontQty.Text.Equals(string.Empty))
                        {
                            //insert soont selling detail
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Soont 108 lb", Convert.ToInt32(txtSoontQty.Text), txtSoontRate.Text);
                        }

                        if (!txtPhwalNuQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Phwal Nu 18 PT", Convert.ToInt32(txtPhwalNuQty.Text), txtPhwalNuRate.Text);
                        }

                        if (!txtPellet10vQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Briquette 10 PT", Convert.ToInt32(txtPellet10vQty.Text), txtBriquette10vRate.Text);
                        }

                        if (!txtPellet20vQty.Text.Equals(string.Empty))
                        {
                            sellingDetailID = taSellingDetail.InsertSellingDetail(getSellingVoucherMax, "Briquette 20 PT", Convert.ToInt32(txtPellet20vQty.Text), txtBriquette20vRate.Text);
                        }

                        if( sellingDetailID > 0 && sellingVoucherID > 0)
                        {
                            MessageBox.Show("Add Successful");
                            this.Close();
                        }
                    }
                    
                }
            }
        }


        //check txtRice2kgQty leave
        private void txtRice2kgQty_Leave(object sender, EventArgs e)
        {

            //check txtRice2kgQty is number?
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtRice2kgRate.Text);


                if (!txtRice2kgQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtRice2kgQty.Text);
                }

                rice2kgAmount = quantity * rate;

                txtRice2kgAmount.Text = rice2kgAmount.ToString();
                
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRice2kgQty.Focus();
                txtRice2kgQty.SelectAll();
            }
        }


        //check txtRice6kgQty leave
        private void txtRice6kgQty_Leave(object sender, EventArgs e)
        {

            //check txtRice6kgQty is number?
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtRice6kgRate.Text);


                if (!txtRice6kgQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtRice6kgQty.Text);
                }

                rice6kgAmount = quantity * rate;

                txtRice6kgAmount.Text = rice6kgAmount.ToString();
                
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRice6kgQty.Focus();
                txtRice6kgQty.SelectAll();
            }
        }

        private void txtRice12kgQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtRice12kgRate.Text);


                if (!txtRice12kgQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtRice12kgQty.Text);
                }

                rice12kgAmount = quantity * rate;

                txtRice12kgAmount.Text = rice12kgAmount.ToString();
               
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRice12kgQty.Focus();
                txtRice12kgQty.SelectAll();
            }
        }



        //check txtRice24kgQty leave
        private void txtRice24kgQty_Leave(object sender, EventArgs e)
        {

            //check txtRice24kgQty is number
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtRice54lbRate.Text);


                if (!txtRice24kgQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtRice24kgQty.Text);
                }

                rice54lbAmount = quantity * rate;

                txtRice54lbAmount.Text = rice54lbAmount.ToString();
                
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRice24kgQty.Focus();
                txtRice24kgQty.SelectAll();
            }
        }

        private void txtRice108pQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtRice108lbRate.Text);


                if (!txtRice108pQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtRice108pQty.Text);
                }

                rice108lbAmount = quantity * rate;

                txtRice108lbAmount.Text = rice108lbAmount.ToString();
                
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRice108pQty.Focus();
                txtRice108pQty.SelectAll();
            }
        }

        private void txtSaLaQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtSaLaRate.Text);


                if (!txtSaLaQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtSaLaQty.Text);
                }

                sala108lbAmount = quantity * rate;

                txtSaLaAmount.Text = sala108lbAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSaLaQty.Focus();
                txtSaLaQty.SelectAll();
            }
        }


        //check txtKyawQty leave
        private void txtKyawQty_Leave(object sender, EventArgs e)
        {

            //check txtKyawQty is number?
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtKyawRate.Text);


                if (!txtKyawQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtKyawQty.Text);
                }

                kyaw108lbAmount = quantity * rate;

                txtKyawAmount.Text = kyaw108lbAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtKyawQty.Focus();
                txtKyawQty.SelectAll();
            }
        }

        private void txtGyiQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtGyiRate.Text);


                if (!txtGyiQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtGyiQty.Text);
                }

                gyi108lbAmount = quantity * rate;

                txtGyiAmount.Text = gyi108lbAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtGyiQty.Focus();
                txtGyiQty.SelectAll();
            }
        }

        private void txtTayQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtTayRate.Text);


                if (!txtTayQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtTayQty.Text);
                }

                tay108lbAmount = quantity * rate;

                txtTayAmount.Text = tay108lbAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtTayQty.Focus();
                txtTayQty.SelectAll();
            }
        }


        //txtSoontQty leave condition
        private void txtSoontQty_Leave(object sender, EventArgs e)
        {

            //check txtSoontQty is number?
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtSoontRate.Text);


                if (!txtSoontQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtSoontQty.Text);
                }

                soont108lbAmount = quantity * rate;

                txtSoontAmount.Text = soont108lbAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSoontQty.Focus();
                txtSoontQty.SelectAll();
            }
        }

        private void txtPhwalNuQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtPhwalNuRate.Text);


                if (!txtPhwalNuQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtPhwalNuQty.Text);
                }

                phwalNu18ptAmount = quantity * rate;

                txtPhwalNuAmount.Text = phwalNu18ptAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtPhwalNuQty.Focus();
                txtPhwalNuQty.SelectAll();
            }
        }


        //check txtPellet10vQty leave
        private void txtPellet10vQty_Leave(object sender, EventArgs e)
        {

            //check txtPellet10vQty is number ?
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtBriquette10vRate.Text);


                if (!txtPellet10vQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtPellet10vQty.Text);
                }

                briquette10ptAmount = quantity * rate;

                txtPellet10vAmount.Text = briquette10ptAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtPellet10vQty.Focus();
                txtPellet10vQty.SelectAll();
            }
        }

        private void txtPellet20vQty_Leave(object sender, EventArgs e)
        {
            try
            {
                Double quantity = 0;
                Double rate = Convert.ToDouble(txtBriquette20vRate.Text);


                if (!txtPellet20vQty.Text.Equals(string.Empty))
                {
                    quantity = Convert.ToDouble(txtPellet20vQty.Text);
                }

                briquette20ptAmount = quantity * rate;

                txtPellet20vAmount.Text = briquette20ptAmount.ToString();

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtPellet20vQty.Focus();
                txtPellet20vQty.SelectAll();
            }
        }


        //load data to CreateSellingVoucher 
        private void CreateSellingVoucher_Load(object sender, EventArgs e)
        {
            int checkSellingVoucherID = -1, checkSellingDetailID = -1;

            //load as update
            if (isUpdate)
            {
                //get selling voucher data
                checkSellingVoucherID = taSellingVoucher.FillSellingVoucherByID(dsMonFactory.sellingVoucher, voucherID);

                //get selling detail data
                checkSellingDetailID = taSellingDetail.FillSellingDetailByID(dsMonFactory.sellingDetail, voucherID);

                //if selling voucher and selling detail have data
                if(checkSellingDetailID > 0 && checkSellingVoucherID > 0)
                {

                    //fill selling voucher data to form
                    txtName.Text = dsMonFactory.sellingVoucher.Rows[0]["customerName"].ToString();
                    txtAddress.Text = dsMonFactory.sellingVoucher.Rows[0]["address"].ToString();
                    txtPhNo.Text = dsMonFactory.sellingVoucher.Rows[0]["phoneNumber"].ToString();
                    dtpDate.Value = Convert.ToDateTime(dsMonFactory.sellingVoucher.Rows[0]["date"]);

                    //fill selling price to form
                    reload_CreateSellingVoucher();


                    //fill selling detail to form with looping
                    for(int i = 0; i < dsMonFactory.sellingDetail.Rows.Count; i++)
                    {
                        //if rice 2 kg category has data, fill data to text box
                        if((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Rice 2 Kg"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtRice2kgRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtRice2kgQty.Text = qty.ToString();

                            txtRice2kgAmount.Text = (rate * qty).ToString();
                            rice2kgAmount = rate * qty;
                        }


                        
                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Rice 6 Kg"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtRice6kgRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtRice6kgQty.Text = qty.ToString();

                            txtRice6kgAmount.Text = (rate * qty).ToString();
                            rice6kgAmount = rate * qty;
                        }

                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Rice 12 Kg"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtRice12kgRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtRice12kgQty.Text = qty.ToString();

                            txtRice12kgAmount.Text = (rate * qty).ToString();
                            rice12kgAmount = rate * qty;
                        }


                        //if rice 54 lb has data, fill data to text box
                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Rice 54 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtRice54lbRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtRice24kgQty.Text = qty.ToString();

                            txtRice54lbAmount.Text = (rate * qty).ToString();
                            rice54lbAmount = rate * qty;
                        }

                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Rice 108 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtRice108lbRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtRice108pQty.Text = qty.ToString();

                            txtRice108lbAmount.Text = (rate * qty).ToString();
                            rice108lbAmount = rate * qty;

                        }

                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Sala 108 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtSaLaRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtSaLaQty.Text = qty.ToString();

                            txtSaLaAmount.Text = (rate * qty).ToString();
                            sala108lbAmount = rate * qty;
                        }

                        //if kyaw 108 lb has data, fill data to text box
                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Kyaw 108 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtKyawRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtKyawQty.Text = qty.ToString();

                            txtKyawAmount.Text = (rate * qty).ToString();
                            kyaw108lbAmount = rate * qty;
                        }

                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Gyi 108 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtGyiRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtGyiQty.Text = qty.ToString();

                            txtGyiAmount.Text = (rate * qty).ToString();
                            gyi108lbAmount = rate * qty;
                        }


                        //if tay 108 lb has data, fill data to txt box
                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Tay 108 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtTayRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtTayQty.Text = qty.ToString();

                            txtTayAmount.Text = (rate * qty).ToString();
                            tay108lbAmount = rate * qty;
                        }

                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Soont 108 lb"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtSoontRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtSoontQty.Text = qty.ToString();

                            txtSoontAmount.Text = (rate * qty).ToString();
                            soont108lbAmount = rate * qty;
                        }


                        //if phwal nu 18 pt has data, fill data to txt box
                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Phwal Nu 18 PT"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtPhwalNuRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtPhwalNuQty.Text = qty.ToString();

                            txtPhwalNuAmount.Text = (rate * qty).ToString();
                            phwalNu18ptAmount = rate * qty;
                        }

                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Briquette 10 PT"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtBriquette10vRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtPellet10vQty.Text = qty.ToString();

                            txtPellet10vAmount.Text = (rate * qty).ToString();
                            briquette10ptAmount = rate * qty;
                        }


                        //if briquette 20 pt has data, fill data to txt box
                        if ((dsMonFactory.sellingDetail.Rows[i]["catetory"].ToString()).Equals("Briquette 20 PT"))
                        {
                            Double rate = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["rate"]);
                            txtBriquette20vRate.Text = rate.ToString();

                            Double qty = Convert.ToDouble(dsMonFactory.sellingDetail.Rows[i]["qty"]);
                            txtPellet20vQty.Text = qty.ToString();

                            briquette20ptAmount = rate * qty;
                            txtPellet20vAmount.Text = (rate * qty).ToString();
                        }

                        //fill data to txtTotalAmount.Text
                        txtTotalAmount.Text = (rice2kgAmount + rice6kgAmount + rice12kgAmount + rice54lbAmount + rice108lbAmount + sala108lbAmount + kyaw108lbAmount + gyi108lbAmount + tay108lbAmount + soont108lbAmount + phwalNu18ptAmount + briquette10ptAmount + briquette20ptAmount).ToString();
                    }


                }
            }
            else
            {
                //reload CreateSellingVoucher
                reload_CreateSellingVoucher();
            }
            


        }


        //method reload CreateSellingVoucher
        public void reload_CreateSellingVoucher()
        {
            int id = -1;

            //get data from sellingProductPrice
            id = taSellingPrice.FillSellingPrice(dsMonFactory.sellingProductPrice);


            //fill selling price to CreateSellingVoucher
            txtRice2kgRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice2kg"].ToString();
            txtRice6kgRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice6kg"].ToString();
            txtRice12kgRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice12kg"].ToString();
            txtRice54lbRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice54lb"].ToString();
            txtRice108lbRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["rice108lb"].ToString();
            txtSaLaRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["sala108lb"].ToString();
            txtKyawRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["kyaw108lb"].ToString();
            txtGyiRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["gyi108lb"].ToString();
            txtTayRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["tay108lb"].ToString();
            txtSoontRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["soont108lb"].ToString();
            txtPhwalNuRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["phwalnu18pt"].ToString();
            txtBriquette10vRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["briquette10pt"].ToString();
            txtBriquette20vRate.Text = dsMonFactory.sellingProductPrice.Rows[0]["briquette20pt"].ToString();
        }


        //txtTotalAmount click's action
        private void txtTotalAmount_MouseClick(object sender, MouseEventArgs e)
        {

            //set txtTotalAmount.Text's value
            txtTotalAmount.Text = (rice2kgAmount + rice6kgAmount + rice12kgAmount + rice54lbAmount + rice108lbAmount + sala108lbAmount + kyaw108lbAmount + gyi108lbAmount + tay108lbAmount + soont108lbAmount + phwalNu18ptAmount + briquette10ptAmount + briquette20ptAmount).ToString();
        }
    }
}
