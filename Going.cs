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
    public partial class Going : Form
    {
        public Going()
        {
            InitializeComponent();
        }


        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.goingListTableAdapter taGoinList = new dsMonFactoryTableAdapters.goingListTableAdapter();

        decimal noOfBags = 0;
        decimal bagsPerUnit = 0;
        decimal price = 0;


        //btnAdd's action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = -1;

            //check txtCarNo
            if (txtCarNo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter car number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarNo.Focus();
                txtCarNo.SelectAll();
            }

            //check txtDriver
            else if (txtDriver.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter driver Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDriver.Focus();
                txtDriver.SelectAll();
            }

            //check txtCity
            else if (txtCity.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter going city Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCity.Focus();
                txtCity.SelectAll();
            }

            //check cboItemName
            else if (cboItemName.SelectedIndex < 0)
            {
                MessageBox.Show("Select your item Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboItemName.Focus();
                cboItemName.SelectAll();
            }

            //check txtBagsPerUnit
            else if (txtBagsPerUnit.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Bage Per Unit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBagsPerUnit.Focus();
                txtBagsPerUnit.SelectAll();
            }

            //check txtNoOfBags
            else if (txtNoOfBags.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Number of Bags!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoOfBags.Focus();
                txtNoOfBags.SelectAll();
            }

            //check txtPrice
            else if (txtPrice.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                txtPrice.SelectAll();
            }

            //check dtpDate
            else if (dtpDate.Value < DateTime.Today)
            {
                MessageBox.Show("Your Entered date is not valid!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDate.Focus();

            }
            else
            {

                //inert going list
                id = taGoinList.InsertGoingList(txtCarNo.Text, txtDriver.Text, txtCity.Text, dtpDate.Value, cboItemName.SelectedItem.ToString(), txtNoOfBags.Text, Convert.ToDecimal(txtPrice.Text), "going", "Create", "Update", "Delete");
                
                if(id > 0)
                {
                    MessageBox.Show("add successful");
                    txtCarNo.Text = "";
                    txtDriver.Text = "";
                    txtCity.Text = "";
                    cboItemName.SelectedIndex = -1;
                    txtBagsPerUnit.Text = "";
                    txtNoOfBags.Text = "";
                    txtPrice.Text = "";
                    txtTotalAmt.Text = "";
                }
                
            }
        }


        //check txtNoOfBags leave, if user input isn't number then renter
        private void txtNoOfBags_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!txtNoOfBags.Text.Equals(string.Empty))
                {
                    decimal noOfBags = Convert.ToDecimal(txtNoOfBags.Text);
                    this.noOfBags = noOfBags;
                    txtTotalAmt.Text = (this.price * this.noOfBags).ToString("#,##0.###");
                }

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtNoOfBags.Focus();
                txtNoOfBags.SelectAll();
            }
        }


        //check txtPrice leave, if user input isn't number then renter
        private void txtPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!txtPrice.Text.Equals(string.Empty))
                {
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    this.price = price;
                    txtTotalAmt.Text = (this.price * this.noOfBags).ToString("#,##0.###");
                }

            }
            catch
            {
                MessageBox.Show("You should enter a number!!");
                txtPrice.Focus();
                txtPrice.SelectAll();
            }
        }


        //calculate 
        private void txtTotalAmt_MouseClick(object sender, MouseEventArgs e)
        {
            txtTotalAmt.Text = Convert.ToDouble((this.price * this.noOfBags)).ToString();
        }
    }
}
