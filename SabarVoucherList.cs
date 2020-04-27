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
    public partial class SabarVoucherList : Form
    {
        public SabarVoucherList()
        {
            InitializeComponent();
        }

        Boolean isUpdate = false;
        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.sabarVoucherListGridTableAdapter taSabarVoucherListGrid = new dsMonFactoryTableAdapters.sabarVoucherListGridTableAdapter();
        dsMonFactoryTableAdapters.sabarVoucherListTableAdapter taSabarVoucherList = new dsMonFactoryTableAdapters.sabarVoucherListTableAdapter();
        dsMonFactoryTableAdapters.sabarVoucherListDetailTableAdapter taSabarVoucherListDetail = new dsMonFactoryTableAdapters.sabarVoucherListDetailTableAdapter();

        

        private void SabarVoucherList_Load(object sender, EventArgs e)
        {
            taSabarVoucherListGrid.FillSabarVoucherList(dsMonFactory.sabarVoucherListGrid);
            dgvSabarVoucherList.DataSource = dsMonFactory.sabarVoucherListGrid;

            for (int i = 0; i < dgvSabarVoucherList.Rows.Count; i++)
            {
                dgvSabarVoucherList.Rows[i].Cells[0].Value = "Create";
                dgvSabarVoucherList.Rows[i].Cells[1].Value = "Update";
                dgvSabarVoucherList.Rows[i].Cells[2].Value = "Delete";
            }
        }


        public void reload_SabarVoucherList()
        {
            taSabarVoucherListGrid.FillSabarVoucherList(dsMonFactory.sabarVoucherListGrid);
            dgvSabarVoucherList.DataSource = dsMonFactory.sabarVoucherListGrid;

            for (int i = 0; i < dgvSabarVoucherList.Rows.Count; i++)
            {
                dgvSabarVoucherList.Rows[i].Cells[0].Value = "Create";
                dgvSabarVoucherList.Rows[i].Cells[1].Value = "Update";
                dgvSabarVoucherList.Rows[i].Cells[2].Value = "Delete";
            }
        }

        private void dgvSabarVoucherList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvSabarVoucherList.CurrentCell.RowIndex,
            //dgvSabarVoucherList.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");

            //create voucher
            if (dgvSabarVoucherList.CurrentCell.ColumnIndex == 0)
            {
                int id = -1;
                id = taSabarVoucherList.FillSabarVoucherListByID(dsMonFactory.sabarVoucherList, Convert.ToInt32(dgvSabarVoucherList.CurrentRow.Cells[3].Value));

                //check if voucher is already exist? than this action will do nothing! 
                if (id > 0 && dsMonFactory.sabarVoucherList.Rows[0]["status"].Equals("FINISHED"))
                {
                    string msgg = String.Format("Voucher ID {0} is already exist, You can't create it again!!", dgvSabarVoucherList.CurrentRow.Cells[3].Value.ToString());
                    MessageBox.Show(msgg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //create a voucher with current row's ID
                else
                {
                    CreateBuyingVoucher frm = new CreateBuyingVoucher(Convert.ToInt32(dgvSabarVoucherList.CurrentRow.Cells[3].Value));
                    frm.ShowDialog();
                    reload_SabarVoucherList();
                }
            }
            //update voucher
            else if (dgvSabarVoucherList.CurrentCell.ColumnIndex == 1)
            {
                int id = -1;
                id = taSabarVoucherList.FillSabarVoucherListByID(dsMonFactory.sabarVoucherList, Convert.ToInt32(dgvSabarVoucherList.CurrentRow.Cells[3].Value));

                //check if voucher is already exist? than this action will do nothing! 
                if (id > 0 && dsMonFactory.sabarVoucherList.Rows[0]["status"].Equals("FINISHED"))
                {
                    isUpdate = true;
                    CreateBuyingVoucher frm = new CreateBuyingVoucher(isUpdate, Convert.ToInt32(dgvSabarVoucherList.CurrentRow.Cells[3].Value));
                    frm.ShowDialog();
                }
                else
                {

                    MessageBox.Show("This voucher is'nt exist ,Plz create it first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            //delete voucher
            else if (dgvSabarVoucherList.CurrentCell.ColumnIndex == 2)
            {

                int vListID = -1;
                int vListDetailID = -1;

                //delete clicked row's voucher
                vListID = taSabarVoucherList.DeleteSabarVoucherList(Convert.ToInt32(dgvSabarVoucherList.CurrentRow.Cells[3].Value));

                //delete clicked row's voucher detail
                vListDetailID = taSabarVoucherListDetail.DeleteSabarVoucherListDetail(Convert.ToInt32(dgvSabarVoucherList.CurrentRow.Cells[3].Value));


                //reload list grid
                if (vListDetailID > 0 || vListID > 0)
                {
                    taSabarVoucherListGrid.FillSabarVoucherList(dsMonFactory.sabarVoucherListGrid);
                    dgvSabarVoucherList.DataSource = dsMonFactory.sabarVoucherListGrid;
                    for (int i = 0; i < dgvSabarVoucherList.Rows.Count; i++)
                    {
                        dgvSabarVoucherList.Rows[i].Cells[0].Value = "Create";
                        dgvSabarVoucherList.Rows[i].Cells[1].Value = "Update";
                        dgvSabarVoucherList.Rows[i].Cells[2].Value = "Delete";

                    }


                    MessageBox.Show("Delete Successful", "");
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            taSabarVoucherListGrid.FillSabarVoucherList(dsMonFactory.sabarVoucherListGrid);
            dgvSabarVoucherList.DataSource = dsMonFactory.sabarVoucherListGrid;

            for (int i = 0; i < dgvSabarVoucherList.Rows.Count; i++)
            {
                dgvSabarVoucherList.Rows[i].Cells[0].Value = "Create";
                dgvSabarVoucherList.Rows[i].Cells[1].Value = "Update";
                dgvSabarVoucherList.Rows[i].Cells[2].Value = "Delete";
            }
        }

        //reload sabarvoucherlist grid
        //private void btnReload_Click(object sender, EventArgs e)
        //{
        //    taSabarVoucherListGrid.FillSabarVoucherList(dsMonFactory.sabarVoucherListGrid);
        //    dgvSabarVoucherList.DataSource = dsMonFactory.sabarVoucherListGrid;

        //    for (int i = 0; i < dgvSabarVoucherList.Rows.Count; i++)
        //    {
        //        dgvSabarVoucherList.Rows[i].Cells[0].Value = "Create";
        //        dgvSabarVoucherList.Rows[i].Cells[1].Value = "Update";
        //        dgvSabarVoucherList.Rows[i].Cells[2].Value = "Delete";
        //    }


        //}
    }
}
