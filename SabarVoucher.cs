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
    public partial class SabarVoucher : Form
    {
        public SabarVoucher()
        {
            InitializeComponent();
        }



        Boolean isEdit = false;
        int isEditID;
        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.sabarVoucherListTableAdapter taSabarVoucherList = new dsMonFactoryTableAdapters.sabarVoucherListTableAdapter();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (txtCusName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Customer Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusName.Focus();
                txtCusName.SelectAll();
            }
            else if (txtPhNo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Customer Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhNo.Focus();
                txtPhNo.SelectAll();
            }
            else if (txtSaBarTin.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter Sabar Tin Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaBarTin.Focus();
                txtSaBarTin.SelectAll();
            }
            else if (dtpDate.Value < DateTime.Today)
            {
                MessageBox.Show("Your Entered date is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpDate.Focus();
            }
            else
            {
                if (isEdit)
                {
                    id = taSabarVoucherList.UpdateSabarVoucherList(txtCusName.Text, txtPhNo.Text, txtAddress.Text, Convert.ToDecimal(txtSaBarTin.Text), dtpDate.Value, isEditID);


                    if (id > 0)
                    {
                        txtCusName.Text = string.Empty;
                        txtPhNo.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtSaBarTin.Text = string.Empty;

                        taSabarVoucherList.FillSabarVoucherList(dsMonFactory.sabarVoucherList);
                        dgvSabarVoucherListGrid.DataSource = dsMonFactory.sabarVoucherList;

                        MessageBox.Show("Update Successful");
                    }
                }
                else
                {
                    id = taSabarVoucherList.InsertSabarVoucherList(txtCusName.Text, txtPhNo.Text, txtAddress.Text, Convert.ToDecimal(txtSaBarTin.Text), dtpDate.Value, "Pending", "NOT_PAY");
                    if (id > 0)
                    {
                        txtCusName.Text = string.Empty;
                        txtPhNo.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtSaBarTin.Text = string.Empty;

                        MessageBox.Show("Add Successful!");
                        this.Dispose();
                    }
                }

            }
        }

        private void SabarVoucher_Load(object sender, EventArgs e)
        {
            taSabarVoucherList.FillSabarVoucherList(dsMonFactory.sabarVoucherList);
            dgvSabarVoucherListGrid.DataSource = dsMonFactory.sabarVoucherList;
        }

        private void dgvSabarVoucherListGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = -1;
            id = taSabarVoucherList.FillSabarVoucherListByID(dsMonFactory.sabarVoucherList, Convert.ToInt32(dgvSabarVoucherListGrid.CurrentRow.Cells[0].Value));
            if (id > 0)
            {

                txtAddress.Text = dsMonFactory.sabarVoucherList.Rows[0]["address"].ToString();
                txtCusName.Text = dsMonFactory.sabarVoucherList.Rows[0]["customerName"].ToString(); ;
                txtPhNo.Text = dsMonFactory.sabarVoucherList.Rows[0]["phoneNumber"].ToString(); ;
                txtSaBarTin.Text = dsMonFactory.sabarVoucherList.Rows[0]["sabarTin"].ToString(); ;
                dtpDate.Value = Convert.ToDateTime(dsMonFactory.sabarVoucherList.Rows[0]["date"]);

                isEditID = Convert.ToInt32(dgvSabarVoucherListGrid.CurrentRow.Cells[0].Value);
                isEdit = true;
            }

            taSabarVoucherList.FillSabarVoucherList(dsMonFactory.sabarVoucherList);
            dgvSabarVoucherListGrid.DataSource = dsMonFactory.sabarVoucherList;
        }

        private void txtSaBarTin_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtSaBarTin.Text);
            }
            catch
            {
                MessageBox.Show("Enter a number!");
                txtSaBarTin.Focus();
                txtSaBarTin.SelectAll();
            }
        }
    }
}
