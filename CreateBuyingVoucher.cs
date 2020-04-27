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
    public partial class CreateBuyingVoucher : Form
    {

        int voucherID;
        Boolean isCreate = false;
        Boolean isUpdate = false;



        decimal ricePaAmount = 0;
        decimal ricePoundAmount = 0;

        decimal salaPaAmount = 0;
        decimal salaPoundAmount = 0;

        decimal kyawPaAmount = 0;
        decimal kyawPoundAmount = 0;

        decimal gyiPaAmount = 0;
        decimal gyiPoundAmount = 0;

        decimal tayPaAmount = 0;
        decimal tayPoundAmount = 0;

        decimal soontPaAmount = 0;
        decimal soontPoundAmount = 0;

        decimal phwalnuPaAmount = 0;
        decimal phwalnuPoundAmount = 0;

        decimal satkyatekhaPaAmount = 0;
        decimal satkyatekhaPoundAmount = 0;


        public CreateBuyingVoucher()
        {
            InitializeComponent();
        }


        //constructor with isUpdate and updateID
        public CreateBuyingVoucher(Boolean isUpdate, int updateID)
        {
            this.isUpdate = isUpdate;
            voucherID = updateID;
            InitializeComponent();
        }



        //constructor with id
        public CreateBuyingVoucher(int id)
        {
            this.voucherID = id;
            isCreate = true;
            InitializeComponent();
        }

        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.sabarVoucherListTableAdapter taSabarVoucherListID = new dsMonFactoryTableAdapters.sabarVoucherListTableAdapter();
        dsMonFactoryTableAdapters.buyingProductPriceTableAdapter taBuyingPrice = new dsMonFactoryTableAdapters.buyingProductPriceTableAdapter();
        dsMonFactoryTableAdapters.sabarVoucherListDetailTableAdapter taSabarDetail = new dsMonFactoryTableAdapters.sabarVoucherListDetailTableAdapter();
        dsMonFactoryTableAdapters.sabarVoucherListDetailTableAdapter taSabarListDetail = new dsMonFactoryTableAdapters.sabarVoucherListDetailTableAdapter();


        //load data to form
        private void CreateBuyingVoucher_Load(object sender, EventArgs e)
        {
            txtRiceAmount.Text = "0.00";
            txtSalaAmount.Text = "0.00";
            txtKyawAmount.Text = "0.00";
            txtGyiAmount.Text = "0.00";
            txtTayAmount.Text = "0.00";
            txtSoontAmount.Text = "0.00";
            txtPhwalNuAmount.Text = "0.00";
            txtSatKyateKhaAmount.Text = "0.00";



            int loadID = -1, checkBuyingPriceID = -1, listDetailID = -1;

            //isCreate condition
            if (isCreate)
            {

                //get buying price
                checkBuyingPriceID = taBuyingPrice.FillBuyingPrice(dsMonFactory.buyingProductPrice);

                //get sabar voucher list data by id
                loadID = taSabarVoucherListID.FillSabarVoucherListByID(dsMonFactory.sabarVoucherList, voucherID);


                if (loadID > 0 && checkBuyingPriceID > 0)
                {
                    //fill sabar voucher list data
                    txtSabarVoucherID.Text = dsMonFactory.sabarVoucherList.Rows[0]["voucherId"].ToString();
                    txtName.Text = dsMonFactory.sabarVoucherList.Rows[0]["customername"].ToString();
                    txtSabarTin.Text = dsMonFactory.sabarVoucherList.Rows[0]["sabarTin"].ToString();
                    txtAddress.Text = dsMonFactory.sabarVoucherList.Rows[0]["address"].ToString();
                    txtPh.Text = dsMonFactory.sabarVoucherList.Rows[0]["phoneNumber"].ToString();
                    dtpDate.Value = Convert.ToDateTime(dsMonFactory.sabarVoucherList.Rows[0]["date"]);


                    //fill buying price
                    txtRiceRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["rice"].ToString();
                    txtSalaRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["sala"].ToString();
                    txtKyawRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyaw"].ToString();
                    txtGyiRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyi"].ToString();
                    txtTayRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["tay"].ToString();
                    txtSoontRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["soont"].ToString();
                    txtPhwalNuRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["phwalnu"].ToString();
                    txtSatKyateKhaRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["satkyyatkha"].ToString();

                }
            }

            //update condition
            else if (isUpdate)
            {

                //get buying price
                checkBuyingPriceID = taBuyingPrice.FillBuyingPrice(dsMonFactory.buyingProductPrice);

                //get sabar voucher list data by id
                loadID = taSabarVoucherListID.FillSabarVoucherListByID(dsMonFactory.sabarVoucherList, voucherID);

                //get sabar voucher list detail by id
                listDetailID = taSabarListDetail.FillListDetailByID(dsMonFactory.sabarVoucherListDetail, voucherID);

                if (loadID > 0 && checkBuyingPriceID > 0)
                {

                    //fill sabar voucher list data
                    txtSabarVoucherID.Text = dsMonFactory.sabarVoucherList.Rows[0]["voucherId"].ToString();
                    txtName.Text = dsMonFactory.sabarVoucherList.Rows[0]["customername"].ToString();
                    txtSabarTin.Text = dsMonFactory.sabarVoucherList.Rows[0]["sabarTin"].ToString();
                    txtAddress.Text = dsMonFactory.sabarVoucherList.Rows[0]["address"].ToString();
                    txtPh.Text = dsMonFactory.sabarVoucherList.Rows[0]["phoneNumber"].ToString();
                    dtpDate.Value = Convert.ToDateTime(dsMonFactory.sabarVoucherList.Rows[0]["date"]);


                    //fill buying price
                    txtRiceRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["rice"].ToString();
                    txtSalaRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["sala"].ToString();
                    txtKyawRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyaw"].ToString();
                    txtGyiRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["kyi"].ToString();
                    txtTayRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["tay"].ToString();
                    txtSoontRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["soont"].ToString();
                    txtPhwalNuRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["phwalnu"].ToString();
                    txtSatKyateKhaRate.Text = dsMonFactory.buyingProductPrice.Rows[0]["satkyyatkha"].ToString();

                    //fill sabar voucher list detail with looping
                    for (int i = 0; i < dsMonFactory.sabarVoucherListDetail.Rows.Count; i++)
                    {
                        //category == rice
                        //calculate ricePaAmount and ricePountAmount
                        //fill txtRiceAmount.Text
                        if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("rice"))
                        {
                            decimal riceRate = Convert.ToDecimal(txtRiceRate.Text);
                            txtRicePa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal ricePa = Convert.ToDecimal(txtRicePa.Text);
                            txtRicePound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal ricePound = Convert.ToDecimal(txtRicePound.Text);

                            ricePaAmount = ricePa * riceRate;
                            ricePoundAmount = ((riceRate / 109) * ricePound);
                            txtRiceAmount.Text = ((ricePa * riceRate) + ((riceRate / 109) * ricePound)).ToString("#,##0");

                        }

                        //category == sala
                        //calculate salaPaAmount and salaPountAmount
                        //fill txtSalaAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("sala"))
                        {
                            decimal salaRate = Convert.ToDecimal(txtSalaRate.Text);
                            txtSalaPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal salaPa = Convert.ToDecimal(txtSalaPa.Text);
                            txtSalaPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal salaPound = Convert.ToDecimal(txtSalaPound.Text);

                            salaPaAmount = salaPa * salaRate;
                            salaPoundAmount = ((salaRate / 109) * salaPound);
                            txtSalaAmount.Text = ((salaPa * salaRate) + ((salaRate / 109) * salaPound)).ToString("#,##0");
                        }

                        //category == kyaw
                        //calculate kyawPaAmount and kyawPountAmount
                        //fill txtKyawAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("kyaw"))
                        {
                            decimal kyawRate = Convert.ToDecimal(txtKyawRate.Text);
                            txtKyawPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal kyawPa = Convert.ToDecimal(txtKyawPa.Text);
                            txtKyawPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal kyawPound = Convert.ToDecimal(txtKyawPound.Text);

                            kyawPaAmount = kyawPa * kyawRate;
                            kyawPoundAmount = ((kyawRate / 109) * kyawPound);
                            txtKyawAmount.Text = ((kyawPa * kyawRate) + ((kyawRate / 109) * kyawPound)).ToString("#,##0");
                        }

                        //category == gyi
                        //calculate gyiPaAmount and gyiPountAmount
                        //fill txtGyiAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("gyi"))
                        {
                            decimal gyiRate = Convert.ToDecimal(txtGyiRate.Text);
                            txtGyiPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal gyiPa = Convert.ToDecimal(txtGyiPa.Text);
                            txtGyiPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal gyiPound = Convert.ToDecimal(txtGyiPound.Text);

                            gyiPaAmount = gyiPa * gyiRate;
                            gyiPoundAmount = ((gyiRate / 109) * gyiPound);
                            txtGyiAmount.Text = ((gyiPa * gyiRate) + ((gyiRate / 109) * gyiPound)).ToString("#,##0");
                        }

                        //category == tay
                        //calculate tayPaAmount and tayPountAmount
                        //fill txtTayAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("tay"))
                        {
                            decimal tayRate = Convert.ToDecimal(txtTayRate.Text);
                            txtTayPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal tayPa = Convert.ToDecimal(txtTayPa.Text);
                            txtTayPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal tayPound = Convert.ToDecimal(txtTayPound.Text);

                            tayPaAmount = tayPa * tayRate;
                            tayPoundAmount = ((tayRate / 109) * tayPound);
                            txtTayAmount.Text = ((tayPa * tayRate) + ((tayRate / 109) * tayPound)).ToString("#,##0");
                        }

                        //category == soont
                        //calculate soontPaAmount and soontPountAmount
                        //fill txtSoontAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("soont"))
                        {
                            decimal soontRate = Convert.ToDecimal(txtSoontRate.Text);
                            txtSoontPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal soontPa = Convert.ToDecimal(txtSoontPa.Text);
                            txtSoontPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal soontPound = Convert.ToDecimal(txtSoontPound.Text);

                            soontPaAmount = soontPa * soontRate;
                            soontPoundAmount = ((soontRate / 109) * soontPound);
                            txtSoontAmount.Text = ((soontPa * soontRate) + ((soontRate / 109) * soontPound)).ToString("#,##0");
                        }

                        //category == Phwal Nu
                        //calculate phwalnuPaAmount and phwalnuPountAmount
                        //fill txtPhwalNuAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("Phwal Nu"))
                        {
                            decimal phwalNuRate = Convert.ToDecimal(txtPhwalNuRate.Text);
                            txtPhwalNuPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal phwalNuPa = Convert.ToDecimal(txtPhwalNuPa.Text);
                            txtPhwalNuPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal phwalNuPound = Convert.ToDecimal(txtPhwalNuPound.Text);

                            phwalnuPaAmount = phwalNuPa * phwalNuRate;
                            phwalnuPoundAmount = ((phwalNuRate / 109) * phwalNuPound);
                            txtPhwalNuAmount.Text = ((phwalNuPa * phwalNuRate) + ((phwalNuRate / 109) * phwalNuPound)).ToString("#,##0");
                        }

                        //category == Sat Kyate Kha
                        //calculate satkyatekhaPaAmount and satkyatekhaPoundAmount
                        //fill txtSatKyateKhaAmount.Text
                        else if ((dsMonFactory.sabarVoucherListDetail.Rows[i]["category"].ToString()).Equals("Sat Kyate Kha"))
                        {
                            decimal satKyateKhaRate = Convert.ToDecimal(txtSatKyateKhaRate.Text);
                            txtSatKyateKhaPa.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["package"].ToString();
                            decimal satKyateKhaPa = Convert.ToDecimal(txtSatKyateKhaPa.Text);
                            txtSatKyateKhaPound.Text = dsMonFactory.sabarVoucherListDetail.Rows[i]["pound"].ToString();
                            decimal satKyateKhaPound = Convert.ToDecimal(txtSatKyateKhaPound.Text);

                            satkyatekhaPaAmount = satKyateKhaPa * satKyateKhaRate;
                            satkyatekhaPoundAmount = ((satKyateKhaRate / 109) * satKyateKhaPound);
                            txtSatKyateKhaAmount.Text = ((satKyateKhaPa * satKyateKhaRate) + ((satKyateKhaRate / 109) * satKyateKhaPound)).ToString("#,##0");
                        }

                    }

                    //calculate and fill txtTotalCategoryAmount.Text and txtTotalAmount.Text
                    txtTotalCategoryAmount.Text = (Convert.ToDecimal(txtRiceAmount.Text) + Convert.ToDecimal(txtSalaAmount.Text) + Convert.ToDecimal(txtKyawAmount.Text) + Convert.ToDecimal(txtGyiAmount.Text) + Convert.ToDecimal(txtTayAmount.Text) + Convert.ToDecimal(txtSoontAmount.Text) + Convert.ToDecimal(txtPhwalNuAmount.Text)).ToString("#,##0");
                    txtTotalAmount.Text = (Convert.ToDecimal(txtRiceAmount.Text) + Convert.ToDecimal(txtSalaAmount.Text) + Convert.ToDecimal(txtKyawAmount.Text) + Convert.ToDecimal(txtGyiAmount.Text) + Convert.ToDecimal(txtTayAmount.Text) + Convert.ToDecimal(txtSoontAmount.Text) + Convert.ToDecimal(txtPhwalNuAmount.Text) - Convert.ToDecimal(txtSatKyateKhaAmount.Text)).ToString("#,##0");

                }
            }
        }


        
        //btnAdd's action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = -1;

            //update condition
            if (isUpdate)
            {

                //delete all list detail with voucher id
                taSabarListDetail.DeleteSabarVoucherListDetail(voucherID);

                //check txtRice input
                if (!txtRicePa.Text.Equals(string.Empty) || !txtRicePound.Text.Equals(string.Empty))
                {
                    //txtRicePa is empty
                    if (txtRicePa.Text.Equals(string.Empty))
                    {
                        //insert txtRicePound.Text
                        id = taSabarDetail.InsertSabarVoucherListDetail("rice", 0, Convert.ToDecimal(txtRicePound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                    //txtRicePound is empty
                    else if (txtRicePound.Text.Equals(string.Empty))
                    {
                        //insert txtRicePa
                        id = taSabarDetail.InsertSabarVoucherListDetail("rice", Convert.ToDecimal(txtRicePa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //no empty
                    else
                    {
                        //insert both
                        id = taSabarDetail.InsertSabarVoucherListDetail("rice", Convert.ToDecimal(txtRicePa.Text), Convert.ToDecimal(txtRicePound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                //check txtSala input
                if (!txtSalaPa.Text.Equals(string.Empty) || !txtSalaPound.Text.Equals(string.Empty))
                {
                    //txtSalaPa is empty
                    if (txtSalaPa.Text.Equals(string.Empty))
                    {
                        //insert txtSalaPound
                        id = taSabarDetail.InsertSabarVoucherListDetail("sala", 0, Convert.ToDecimal(txtSalaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //txtSalaPound is empty
                    else if (txtSalaPound.Text.Equals(string.Empty))
                    {
                        //insert txtRicePa
                        id = taSabarDetail.InsertSabarVoucherListDetail("sala", Convert.ToDecimal(txtSalaPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //no empty
                    else
                    {
                        //insert both
                        id = taSabarDetail.InsertSabarVoucherListDetail("sala", Convert.ToDecimal(txtSalaPa.Text), Convert.ToDecimal(txtSalaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtKyawPa.Text.Equals(string.Empty) || !txtKyawPound.Text.Equals(string.Empty))
                {
                    if (txtKyawPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("kyaw", 0, Convert.ToDecimal(txtKyawPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtKyawPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("kyaw", Convert.ToDecimal(txtKyawPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("kyaw", Convert.ToDecimal(txtKyawPa.Text), Convert.ToDecimal(txtKyawPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtGyiPa.Text.Equals(string.Empty) || !txtGyiPound.Text.Equals(string.Empty))
                {
                    if (txtGyiPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("gyi", 0, Convert.ToDecimal(txtGyiPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtGyiPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("gyi", Convert.ToDecimal(txtGyiPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("gyi", Convert.ToDecimal(txtGyiPa.Text), Convert.ToDecimal(txtGyiPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtTayPa.Text.Equals(string.Empty) || !txtTayPound.Text.Equals(string.Empty))
                {
                    if (txtTayPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("tay", 0, Convert.ToDecimal(txtTayPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtTayPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("tay", Convert.ToDecimal(txtTayPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("tay", Convert.ToDecimal(txtTayPa.Text), Convert.ToDecimal(txtTayPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtSoontPa.Text.Equals(string.Empty) || !txtSoontPound.Text.Equals(string.Empty))
                {
                    if (txtSoontPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("soont", 0, Convert.ToDecimal(txtSoontPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtSoontPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("soont", Convert.ToDecimal(txtSoontPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("soont", Convert.ToDecimal(txtSoontPa.Text), Convert.ToDecimal(txtSoontPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }


                //check txtPhwalNu input
                if (!txtPhwalNuPa.Text.Equals(string.Empty) || !txtPhwalNuPound.Text.Equals(string.Empty))
                {

                    //if txtPhwalNuPa is empty
                    if (txtPhwalNuPa.Text.Equals(string.Empty))
                    {
                        //insert txtPhwalNuPound
                        id = taSabarDetail.InsertSabarVoucherListDetail("Phwal Nu", 0, Convert.ToDecimal(txtPhwalNuPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //if txtPhwalNuPound is empty
                    else if (txtPhwalNuPound.Text.Equals(string.Empty))
                    {
                        //insert txtPhwalNuPa
                        id = taSabarDetail.InsertSabarVoucherListDetail("Phwal Nu", Convert.ToDecimal(txtPhwalNuPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //no empty
                    else
                    {
                        //insert both
                        id = taSabarDetail.InsertSabarVoucherListDetail("Phwal Nu", Convert.ToDecimal(txtPhwalNuPa.Text), Convert.ToDecimal(txtPhwalNuPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtSatKyateKhaPa.Text.Equals(string.Empty) || !txtSatKyateKhaPound.Text.Equals(string.Empty))
                {
                    if (txtSatKyateKhaPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Sat Kyate Kha", 0, Convert.ToDecimal(txtSatKyateKhaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtSatKyateKhaPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Sat Kyate Kha", Convert.ToDecimal(txtSatKyateKhaPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Sat Kyate Kha", Convert.ToDecimal(txtSatKyateKhaPa.Text), Convert.ToDecimal(txtSatKyateKhaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }


                //insert sabarVoucherListDetail successful
                if (id > 0)
                {
                    //taSabarVoucherListID.DeleteSabarVoucherList(Convert.ToInt32(txtSabarVoucherID.Text));

                    //set status as finished with txtSabarVoucherID
                    taSabarVoucherListID.UpdateStatus("FINISHED", Convert.ToInt32(txtSabarVoucherID.Text));

                    //show updated message
                    MessageBox.Show("Update Successful");

                }
            }
            else
            {
                //check txtRice input
                if (!txtRicePa.Text.Equals(string.Empty) || !txtRicePound.Text.Equals(string.Empty))
                {
                    //txtRicePa is empty
                    if (txtRicePa.Text.Equals(string.Empty))
                    {
                        //insert txtRicePound
                        id = taSabarDetail.InsertSabarVoucherListDetail("rice", 0, Convert.ToDecimal(txtRicePound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //txtRicePound is empty
                    else if (txtRicePound.Text.Equals(string.Empty))
                    {
                        //insert txtRicePa 
                        id = taSabarDetail.InsertSabarVoucherListDetail("rice", Convert.ToDecimal(txtRicePa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //no empty
                    else
                    {
                        //insert  both
                        id = taSabarDetail.InsertSabarVoucherListDetail("rice", Convert.ToDecimal(txtRicePa.Text), Convert.ToDecimal(txtRicePound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtSalaPa.Text.Equals(string.Empty) || !txtSalaPound.Text.Equals(string.Empty))
                {
                    if (txtSalaPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("sala", 0, Convert.ToDecimal(txtSalaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtSalaPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("sala", Convert.ToDecimal(txtSalaPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("sala", Convert.ToDecimal(txtSalaPa.Text), Convert.ToDecimal(txtSalaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtKyawPa.Text.Equals(string.Empty) || !txtKyawPound.Text.Equals(string.Empty))
                {
                    if (txtKyawPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("kyaw", 0, Convert.ToDecimal(txtKyawPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtKyawPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("kyaw", Convert.ToDecimal(txtKyawPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("kyaw", Convert.ToDecimal(txtKyawPa.Text), Convert.ToDecimal(txtKyawPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtGyiPa.Text.Equals(string.Empty) || !txtGyiPound.Text.Equals(string.Empty))
                {
                    if (txtGyiPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("gyi", 0, Convert.ToDecimal(txtGyiPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtGyiPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("gyi", Convert.ToDecimal(txtGyiPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("gyi", Convert.ToDecimal(txtGyiPa.Text), Convert.ToDecimal(txtGyiPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }


                //check txtTay input
                if (!txtTayPa.Text.Equals(string.Empty) || !txtTayPound.Text.Equals(string.Empty))
                {
                    //if txtTayPa is empty
                    if (txtTayPa.Text.Equals(string.Empty))
                    {
                        //insert txtTayPound 
                        id = taSabarDetail.InsertSabarVoucherListDetail("tay", 0, Convert.ToDecimal(txtTayPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //if txtTayPound is empty
                    else if (txtTayPound.Text.Equals(string.Empty))
                    {
                        //insert txtTayPa
                        id = taSabarDetail.InsertSabarVoucherListDetail("tay", Convert.ToDecimal(txtTayPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    //no empty
                    else
                    {
                        //insert both
                        id = taSabarDetail.InsertSabarVoucherListDetail("tay", Convert.ToDecimal(txtTayPa.Text), Convert.ToDecimal(txtTayPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtSoontPa.Text.Equals(string.Empty) || !txtSoontPound.Text.Equals(string.Empty))
                {
                    if (txtSoontPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("soont", 0, Convert.ToDecimal(txtSoontPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtSoontPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("soont", Convert.ToDecimal(txtSoontPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("soont", Convert.ToDecimal(txtSoontPa.Text), Convert.ToDecimal(txtSoontPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtPhwalNuPa.Text.Equals(string.Empty) || !txtPhwalNuPound.Text.Equals(string.Empty))
                {
                    if (txtPhwalNuPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Phwal Nu", 0, Convert.ToDecimal(txtPhwalNuPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtPhwalNuPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Phwal Nu", Convert.ToDecimal(txtPhwalNuPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Phwal Nu", Convert.ToDecimal(txtPhwalNuPa.Text), Convert.ToDecimal(txtPhwalNuPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }

                if (!txtSatKyateKhaPa.Text.Equals(string.Empty) || !txtSatKyateKhaPound.Text.Equals(string.Empty))
                {
                    if (txtSatKyateKhaPa.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Sat Kyate Kha", 0, Convert.ToDecimal(txtSatKyateKhaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else if (txtSatKyateKhaPound.Text.Equals(string.Empty))
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Sat Kyate Kha", Convert.ToDecimal(txtSatKyateKhaPa.Text), 0, Convert.ToInt32(txtSabarVoucherID.Text));
                    }
                    else
                    {
                        id = taSabarDetail.InsertSabarVoucherListDetail("Sat Kyate Kha", Convert.ToDecimal(txtSatKyateKhaPa.Text), Convert.ToDecimal(txtSatKyateKhaPound.Text), Convert.ToInt32(txtSabarVoucherID.Text));
                    }

                }


                //add sabarVoucherDetail successful
                if (id > 0)
                {
                    //taSabarVoucherListID.DeleteSabarVoucherList(Convert.ToInt32(txtSabarVoucherID.Text));
                    //set status as finished
                    taSabarVoucherListID.UpdateStatus("FINISHED", Convert.ToInt32(txtSabarVoucherID.Text));

                    //show added message
                    MessageBox.Show("Add Successful");
                    this.Dispose();

                }
            }
        }


        //txtTotalCategoryAmount click's action
        private void txtTotalCategoryAmount_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate and fill txtTotalCategoryAmount.Text
            txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString("#,##0");
        }

        //txtTotalAmount click's action
        private void txtTotalAmount_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate and fill txtTotalAmount.Text
            txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString("#,##0");

            //calculate and fill txtTotalCategoryAmount.Text
            txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString("#,##0");
        }

        //txtRicePa leave action
        //check user input is number or not, calculate ricePaAmount and fill txtRiceAmount.Text
        private void txtRicePa_Leave_1(object sender, EventArgs e)
        {
            decimal packages = 0;
            decimal rate = Convert.ToDecimal(txtRiceRate.Text);



            try
            {
                if (!txtRicePa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtRicePa.Text);

                }
                ricePaAmount = packages * rate;

                txtRiceAmount.Text = (ricePaAmount + ricePoundAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRicePa.Focus();
                txtRicePa.SelectAll();
            }
        }

        private void txtRicePound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtRiceRate.Text);


                if (!txtRicePound.Text.Equals(string.Empty))
                {
                    pounds = Convert.ToDecimal(txtRicePound.Text);
                }

                ricePoundAmount = ((rate / 109) * pounds);

                txtRiceAmount.Text = (ricePaAmount + ricePoundAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtRicePound.Focus();
                txtRicePound.SelectAll();
            }
        }



        private void txtSalaPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtSalaRate.Text);

                if (!txtSalaPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtSalaPa.Text);
                }

                salaPaAmount = packages * rate;

                txtSalaAmount.Text = (salaPoundAmount + salaPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSalaPa.Focus();
                txtSalaPa.SelectAll();
            }
        }


        //txtSalaPound leave action
        //check user input is number or not, calculate salaPoundAmount and fill txtSalaAmount.Text
        private void txtSalaPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtSalaRate.Text);


                if (!txtSalaPound.Text.Equals(string.Empty))
                {
                    pounds = Convert.ToDecimal(txtSalaPound.Text);
                }

                salaPoundAmount = ((rate / 109) * pounds);

                txtSalaAmount.Text = (salaPoundAmount + salaPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSalaPound.Focus();
                txtSalaPound.SelectAll();
            }
        }

        private void txtKyawPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtKyawRate.Text);

                if (!txtKyawPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtKyawPa.Text);
                }

                kyawPaAmount = packages * rate;

                txtKyawAmount.Text = (kyawPoundAmount + kyawPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtKyawPa.Focus();
                txtKyawPa.SelectAll();
            }
        }



        //txtKyawPound leave action
        //check user input is number or not, calculate kyawPoundAmount and fill txtKyawAmount.Text
        private void txtKyawPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtKyawRate.Text);


                if (!txtKyawPound.Text.Equals(string.Empty))
                {
                    pounds = Convert.ToDecimal(txtKyawPound.Text);
                }

                kyawPoundAmount = +((rate / 109) * pounds);

                txtKyawAmount.Text = (kyawPoundAmount + kyawPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtKyawPound.Focus();
                txtKyawPound.SelectAll();
            }
        }

        private void txtGyiPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtGyiRate.Text);

                if (!txtGyiPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtGyiPa.Text);
                }

                gyiPaAmount = packages * rate;

                txtGyiAmount.Text = (gyiPoundAmount + gyiPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtGyiPa.Focus();
                txtGyiPa.SelectAll();
            }
        }



        //txtGyiPound leave action
        //check user input is number or not, calculate gyiPoundAmount and fill txtGyiAmount.Text
        private void txtGyiPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtGyiRate.Text);


                if (!txtGyiPound.Text.Equals(string.Empty))
                {
                    pounds = Convert.ToDecimal(txtGyiPound.Text);
                }

                gyiPoundAmount = ((rate / 109) * pounds);

                txtGyiAmount.Text = (gyiPoundAmount + gyiPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtGyiPound.Focus();
                txtGyiPound.SelectAll();
            }
        }

        private void txtGyiPound_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTayPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtTayRate.Text);

                if (!txtTayPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtTayPa.Text);
                }

                tayPaAmount = packages * rate;

                txtTayAmount.Text = (tayPoundAmount + tayPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtTayPa.Focus();
                txtTayPa.SelectAll();
            }
        }

        private void txtTayPound_TextChanged(object sender, EventArgs e)
        {

        }



        //txtTayPound leave action
        //check user input is number or not, calculate tayPoundAmount and fill txtTayAmount.Text
        private void txtTayPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtTayRate.Text);


                if (!txtTayPound.Text.Equals(string.Empty))
                {
                    pounds = Convert.ToDecimal(txtTayPound.Text);
                }

                tayPoundAmount = ((rate / 109) * pounds);

                txtTayAmount.Text = (tayPoundAmount + tayPaAmount).ToString("#,##0");

                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtTayPound.Focus();
                txtTayPound.SelectAll();
            }
        }

        private void txtSoontPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtSoontRate.Text);

                if (!txtSoontPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtSoontPa.Text);
                }

                soontPaAmount = packages * rate;

                txtSoontAmount.Text = (soontPaAmount + soontPoundAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSoontPa.Focus();
                txtSoontPa.SelectAll();
            }
        }


        //txtSoontPound leave action
        //check user input is number or not, calculate soontPoundAmount and fill txtSoontAmount.Text
        private void txtSoontPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtSoontRate.Text);


                if (!txtSoontPound.Text.Equals(string.Empty))
                {

                    pounds = Convert.ToDecimal(txtSoontPound.Text);
                }

                soontPoundAmount = ((rate / 109) * pounds);

                txtSoontAmount.Text = (soontPaAmount + soontPoundAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSoontPound.Focus();
                txtSoontPound.SelectAll();
            }
        }

        private void txtPhwalNuPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtPhwalNuRate.Text);

                if (!txtPhwalNuPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtPhwalNuPa.Text);
                }

                phwalnuPaAmount = packages * rate;

                txtPhwalNuAmount.Text = (phwalnuPoundAmount + phwalnuPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtPhwalNuPa.Focus();
                txtPhwalNuPa.SelectAll();
            }
        }

        private void txtPhwalNuPound_TextChanged(object sender, EventArgs e)
        {

        }



        //txtPhwalNuPound leave action
        //check user input is number or not, calculate phwalNuPoundAmount and fill txtPhwalNuAmount.Text
        private void txtPhwalNuPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtPhwalNuRate.Text);


                if (!txtPhwalNuPound.Text.Equals(string.Empty))
                {

                    pounds = Convert.ToDecimal(txtPhwalNuPound.Text);
                }

                phwalnuPoundAmount = ((rate / 109) * pounds);

                txtPhwalNuAmount.Text = (phwalnuPoundAmount + phwalnuPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtPhwalNuPound.Focus();
                txtPhwalNuPound.SelectAll();
            }
        }

        private void txtSatKyateKhaPa_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal packages = 0;
                decimal rate = Convert.ToDecimal(txtSatKyateKhaRate.Text);

                if (!txtSatKyateKhaPa.Text.Equals(string.Empty))
                {
                    packages = Convert.ToDecimal(txtSatKyateKhaPa.Text);
                }

                satkyatekhaPaAmount = packages * rate;

                txtSatKyateKhaAmount.Text = (satkyatekhaPoundAmount + satkyatekhaPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSatKyateKhaPa.Focus();
                txtSatKyateKhaPa.SelectAll();
            }
        }


        //txtSatKyateKhaPound leave action
        //check user input is number or not, calculate satKyateKhaPoundv and fill txtSatKyateKhaAmount.Text
        private void txtSatKyateKhaPound_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal pounds = 0;
                decimal rate = Convert.ToDecimal(txtSatKyateKhaRate.Text);


                if (!txtSatKyateKhaPound.Text.Equals(string.Empty))
                {
                    pounds = Convert.ToDecimal(txtSatKyateKhaPound.Text);
                }

                satkyatekhaPoundAmount = ((rate / 109) * pounds);

                txtSatKyateKhaAmount.Text = (satkyatekhaPoundAmount + satkyatekhaPaAmount).ToString("#,##0");
                //txtTotalAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount).ToString();
                //txtTotalCategoryAmount.Text = (ricePaAmount + salaPaAmount + kyawPaAmount + gyiPaAmount + tayPaAmount + soontPaAmount + phwalnuPaAmount - satkyatekhaPaAmount + ricePoundAmount + salaPoundAmount + kyawPoundAmount + gyiPoundAmount + tayPoundAmount + soontPoundAmount + phwalnuPoundAmount - satkyatekhaPoundAmount).ToString();
            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtSatKyateKhaPound.Focus();
                txtSatKyateKhaPound.SelectAll();
            }
        }
    }
}
