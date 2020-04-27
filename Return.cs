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
    public partial class Return : Form
    {


        int ListID;
        Boolean isCreate = false;
        Boolean isUpdate = false;

        Double noOfBagsTr;
        Double priceTr;
        Double petrolCost;
        Double generalCost;
        Double totalAmountTr;
        Double totalAmountTg;
        Double totalCost;
        Double totalNetProfit;



        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.goingListTableAdapter taGoingList = new dsMonFactoryTableAdapters.goingListTableAdapter();
        dsMonFactoryTableAdapters.returnListTableAdapter taReturnList = new dsMonFactoryTableAdapters.returnListTableAdapter();


        public Return()
        {
            InitializeComponent();
        }

        public Return(int id)
        {
            this.ListID = id;
            isCreate = true;
            InitializeComponent();
        }



        public Return(int id, Boolean isUpdate)
        {
            this.ListID = id;
            this.isUpdate = isUpdate;
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            noOfBagsTr = 0;
            priceTr = 0;
            petrolCost = 0;
            generalCost = 0;
            totalAmountTr = 0;
            totalAmountTg = 0;
            totalCost = 0;
            totalNetProfit = 0;

            int id = -1;
            int fillUpdateID = -1;
            if (isCreate)
            {

                //get list id
                id = taGoingList.FillGoingListByID(dsMonFactory.goingList, ListID);
                if (id > 0)
                {

                    //set TG panel textbox value and carlist value
                    txtCarNo.Text = dsMonFactory.goingList.Rows[0]["carNumber"].ToString();
                    txtDriver.Text = dsMonFactory.goingList.Rows[0]["driverName"].ToString();
                    txtCity.Text = dsMonFactory.goingList.Rows[0]["goingCity"].ToString();
                    dtpDate.Value = Convert.ToDateTime(dsMonFactory.goingList.Rows[0]["goingDate"]);
                    txtItemTG.Text = dsMonFactory.goingList.Rows[0]["itemName"].ToString();
                    txtNoOfBagTG.Text = dsMonFactory.goingList[0]["noOfBags"].ToString();
                    txtPriceTG.Text = dsMonFactory.goingList.Rows[0]["price"].ToString();
                    txtTotalAmtTG.Text = (Convert.ToDouble(txtNoOfBagTG.Text) * Convert.ToDouble(txtPriceTG.Text)).ToString();


                    //get totalAmountTg'value from textbox
                    totalAmountTg = Convert.ToDouble(txtTotalAmtTG.Text);
                }
            }
            else if (isUpdate)
            {
                //get list id
                id = taGoingList.FillGoingListByID(dsMonFactory.goingList, ListID);
                fillUpdateID = taReturnList.FillReturnListByID(dsMonFactory.returnList, ListID.ToString());
                if (id > 0 && fillUpdateID > 0)
                {

                    //set TG panel textbox value and carlist value
                    txtCarNo.Text = dsMonFactory.goingList.Rows[0]["carNumber"].ToString();
                    txtDriver.Text = dsMonFactory.goingList.Rows[0]["driverName"].ToString();
                    txtCity.Text = dsMonFactory.goingList.Rows[0]["goingCity"].ToString();
                    txtItemTG.Text = dsMonFactory.goingList.Rows[0]["itemName"].ToString();
                    txtNoOfBagTG.Text = dsMonFactory.goingList[0]["noOfBags"].ToString();
                    txtPriceTG.Text = dsMonFactory.goingList.Rows[0]["price"].ToString();
                    txtTotalAmtTG.Text = (Convert.ToDouble(txtNoOfBagTG.Text) * Convert.ToDouble(txtPriceTG.Text)).ToString();


                    //get totalAmountTg'value from textbox
                    totalAmountTg = Convert.ToDouble(txtTotalAmtTG.Text);



                    noOfBagsTr = Convert.ToDouble(dsMonFactory.returnList.Rows[0]["noOfBags"].ToString());
                    priceTr = Convert.ToDouble(dsMonFactory.returnList.Rows[0]["price"].ToString());
                    petrolCost = Convert.ToDouble(dsMonFactory.returnList.Rows[0]["petrolCost"].ToString());
                    generalCost = Convert.ToDouble(dsMonFactory.returnList.Rows[0]["generalCost"].ToString());
                    totalAmountTr = priceTr * noOfBagsTr;
                    totalCost = generalCost + petrolCost;
                    totalNetProfit = totalAmountTr + totalAmountTg - totalCost;


                    txtItemTR.Text = dsMonFactory.returnList.Rows[0]["itemName"].ToString();
                    txtNoOfBagTR.Text = dsMonFactory.returnList.Rows[0]["noOfBags"].ToString();
                    txtPriceTR.Text = dsMonFactory.returnList.Rows[0]["price"].ToString();
                    txtTotalAmtTR.Text = totalAmountTr.ToString();
                    txtPetrolCost.Text = dsMonFactory.returnList.Rows[0]["petrolCost"].ToString();
                    txtGeneralCost.Text = dsMonFactory.returnList.Rows[0]["generalCost"].ToString();
                    txtTotalCost.Text = totalCost.ToString();
                    txtNetProfit.Text = txtNetProfit.Text = totalNetProfit.ToString();
                }
            }
        }

        private void txtNoOfBagTR_Leave(object sender, EventArgs e)
        {
            Double noOfBags;
            try
            {

                //chek uesr input is number 
                if (!txtNoOfBagTR.Text.Equals(string.Empty))
                {
                    noOfBagsTr = noOfBags = Convert.ToDouble(txtNoOfBagTR.Text);
                    txtTotalAmtTR.Text = (noOfBagsTr * priceTr).ToString();
                    totalAmountTr = noOfBagsTr * this.priceTr;
                }

            }
            catch
            {
                //show message if user isn't number?
                MessageBox.Show("You should enter a number!!");
                txtNoOfBagTR.Focus();
                txtNoOfBagTR.SelectAll();
            }
        }

        private void txtPriceTR_Leave(object sender, EventArgs e)
        {
            Double priceTr;
            try
            {

                //check user input is number
                if (!txtPriceTR.Text.Equals(string.Empty))
                {
                    this.priceTr = priceTr = Convert.ToDouble(txtPriceTR.Text);
                    txtTotalAmtTR.Text = (noOfBagsTr * this.priceTr).ToString();
                    totalAmountTr = noOfBagsTr * this.priceTr;
                }

            }
            catch
            {
                //show message if user input isn't number?
                MessageBox.Show("You should enter a number!!");
                txtPriceTR.Focus();
                txtPriceTR.SelectAll();
            }
        }

        private void txtPetrolCost_Leave(object sender, EventArgs e)
        {
            Double petrolCost;
            try
            {
                if (!txtPetrolCost.Text.Equals(string.Empty))
                {

                    //check user input is number?
                    this.petrolCost = petrolCost = Convert.ToDouble(txtPetrolCost.Text);
                    txtTotalCost.Text = (this.petrolCost + this.generalCost).ToString();
                    totalCost = this.petrolCost + this.generalCost;
                }

            }
            catch
            {

                //show message if user input isn't number
                MessageBox.Show("You should enter a number!!");
                txtPetrolCost.Focus();
                txtPetrolCost.SelectAll();
            }
        }

        private void txtGeneralCost_Leave(object sender, EventArgs e)
        {
            Double gengralCost;
            try
            {

                //check user input is number ?
                if (!txtGeneralCost.Text.Equals(string.Empty))
                {
                    this.generalCost = gengralCost = Convert.ToDouble(txtGeneralCost.Text);
                    txtTotalCost.Text = (this.petrolCost + this.generalCost).ToString();
                    totalCost = this.petrolCost + this.generalCost;
                }

            }
            catch
            {
                //show message if user input isn't number
                MessageBox.Show("You should enter a number!!");
                txtGeneralCost.Focus();
                txtGeneralCost.SelectAll();
            }
        }

        //txtTotalAmtTR's mouse click action
        private void txtTotalAmtTR_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate totalAmountTr
            totalAmountTr = noOfBagsTr * this.priceTr;

            //show totalAmountTr
            txtTotalAmtTR.Text = totalAmountTr.ToString();
        }

        private void txtNetProfit_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        //txtNetProfit's mouse click action
        private void txtNetProfit_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate totalNetProfit 
            totalNetProfit = totalAmountTg + totalAmountTr - totalCost;

            //show totalNetProfit
            txtNetProfit.Text = totalNetProfit.ToString();
        }


        // txtTotalCost's action
        private void txtTotalCost_MouseClick(object sender, MouseEventArgs e)
        {
            //calculate totalCost
            txtTotalCost.Text = (this.petrolCost + this.generalCost).ToString();

            //show totalCost
            totalCost = this.petrolCost + this.generalCost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = -1;

            if (txtItemTR.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Item Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemTR.Focus();
                txtItemTR.SelectAll();
            }
            else if (txtNoOfBagTR.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Bags!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoOfBagTR.Focus();
                txtNoOfBagTR.SelectAll();
            }
            else if (txtPriceTR.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPriceTR.Focus();
                txtPriceTR.SelectAll();
            }
            else if (txtPetrolCost.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Petrol Cost!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPetrolCost.Focus();
                txtPetrolCost.SelectAll();
            }
            else if (txtGeneralCost.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter General Cost!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGeneralCost.Focus();
                txtGeneralCost.SelectAll();
            }
            else
            {
                if (isCreate)
                {
                    id = taReturnList.InsertReturnList(ListID.ToString(), txtItemTR.Text, txtNoOfBagTR.Text, txtPriceTR.Text, txtPetrolCost.Text, txtGeneralCost.Text, dtpDate.Value);
                    if (id > 0)
                    {
                        taGoingList.UpdateStatus("ARRIVED", ListID);
                        MessageBox.Show("Create Successful!");
                        this.Close();
                    }
                }
                else if (isUpdate)
                {
                    id = taReturnList.UpdateReturnList(txtItemTR.Text, txtNoOfBagTR.Text, txtPriceTR.Text, txtPetrolCost.Text, dtpDate.Value, txtGeneralCost.Text, ListID.ToString());
                    if (id > 0)
                    {
                        MessageBox.Show("Update Successful!");   
                        this.Close();
                    }
                }
            }


            
        }
    }
}
