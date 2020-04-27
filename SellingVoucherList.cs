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
    public partial class SellingVoucherList : Form
    {
        public SellingVoucherList()
        {
            InitializeComponent();
        }

        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.sellingVoucherTableAdapter taSellingVoucher = new dsMonFactoryTableAdapters.sellingVoucherTableAdapter();
        dsMonFactoryTableAdapters.sellingDetailTableAdapter taSellingDetail = new dsMonFactoryTableAdapters.sellingDetailTableAdapter();
        dsMonFactoryTableAdapters.sellingVoucherGridTableAdapter taSellingGrid = new dsMonFactoryTableAdapters.sellingVoucherGridTableAdapter();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSellingVoucher up = new UpdateSellingVoucher();
            up.Show();
        }


        //fill data to SellingVoucherList
        private void SellingVoucherList_Load(object sender, EventArgs e)
        {
            //get data from sellingVoucherGrid
            taSellingGrid.FillSellingVoucherGrid(dsMonFactory.sellingVoucherGrid);
            //fill data to dgvSellingVoucher
            dgvSellingVoucher.DataSource = dsMonFactory.sellingVoucherGrid;


            for (int i = 0; i < dgvSellingVoucher.Rows.Count; i++)
            {
                dgvSellingVoucher.Rows[i].Cells[0].Value = "Update";
                dgvSellingVoucher.Rows[i].Cells[1].Value = "Delete";

            }
        }


        //SellingVoucherList reload method
        public void reload_SellingVoucherList()
        {

            //get data from sellingVoucherid
            taSellingGrid.FillSellingVoucherGrid(dsMonFactory.sellingVoucherGrid);

            //fill data to dgvSellingVoucher
            dgvSellingVoucher.DataSource = dsMonFactory.sellingVoucherGrid;


            //set update cell and delete cell with looping
            for (int i = 0; i < dgvSellingVoucher.Rows.Count; i++)
            {
                dgvSellingVoucher.Rows[i].Cells[0].Value = "Update";
                dgvSellingVoucher.Rows[i].Cells[1].Value = "Delete";

            }
        }


        //data grid double click aciton
        private void dgvSellingVoucher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvSellingVoucher.CurrentCell.RowIndex,
            //dgvSellingVoucher.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");


            
            int clickedRowID = -1;
            clickedRowID = taSellingVoucher.FillSellingVoucherGridByID(dsMonFactory.sellingVoucher, Convert.ToInt32(dgvSellingVoucher.CurrentRow.Cells[2].Value));



            //double click update
            if (dgvSellingVoucher.CurrentCell.ColumnIndex == 0)
            {
                CreateSellingVoucher frm = new CreateSellingVoucher(Convert.ToInt32(dgvSellingVoucher.CurrentRow.Cells[2].Value), true);
                frm.ShowDialog();
            }

            //double click delete
            else if(dgvSellingVoucher.CurrentCell.ColumnIndex == 1)
            {
                int deleteSellingVoucherID = -1, deleteSellingDetailID = -1;
                deleteSellingVoucherID = taSellingVoucher.DeleteSellingVoucher(clickedRowID);
                deleteSellingDetailID = taSellingDetail.DeleteSellingDetail(clickedRowID);

                if(deleteSellingDetailID > 0 && deleteSellingVoucherID > 0)
                {
                    MessageBox.Show("Delete Successful");
                    reload_SellingVoucherList();
                }
                
            }
        }
    }
}
