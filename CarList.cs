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
    public partial class CarList : Form
    {
        public CarList()
        {
            InitializeComponent();
        }


        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.goingListTableAdapter taGoingList = new dsMonFactoryTableAdapters.goingListTableAdapter();
        dsMonFactoryTableAdapters.returnListTableAdapter taReturnList = new dsMonFactoryTableAdapters.returnListTableAdapter();
        dsMonFactoryTableAdapters.goingListGridTableAdapter taGoingListGrid = new dsMonFactoryTableAdapters.goingListGridTableAdapter();

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return re = new Return();
            re.Show();
        }


        //dgv cell's double click action
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvGoingList.CurrentCell.RowIndex,
            //dgvGoingList.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");

            //create return voucher
            int id = -1, returnID = -1;
            if (dgvGoingList.CurrentCell.ColumnIndex == 9)
            {

                //get going's id from cell click
                id = taGoingList.FillGoingListByID(dsMonFactory.goingList, Convert.ToInt32(dgvGoingList.CurrentRow.Cells[0].Value));
                
                
                //arrived condition
                if (id > 0 && dsMonFactory.goingList.Rows[0]["status"].Equals("ARRIVED"))
                {
                    string msg = String.Format("Going List ID {0} is already exist, You can't create it again!!", dgvGoingList.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //not arrived
                else
                {

                    //open Return form with clicked cell
                    Return frm = new Return(Convert.ToInt32(dgvGoingList.CurrentRow.Cells[0].Value));
                    frm.ShowDialog();
                    reload();
                }

            }

            //update return form
            else if (dgvGoingList.CurrentCell.ColumnIndex == 10)
            {

                //get return's id
                id = taGoingList.FillGoingListByID(dsMonFactory.goingList, Convert.ToInt32(dgvGoingList.CurrentRow.Cells[0].Value));

                //continue if return form is already exist
                if (id > 0 && dsMonFactory.goingList.Rows[0]["status"].Equals("ARRIVED"))
                {
                    Return frm = new Return(Convert.ToInt32(dgvGoingList.CurrentRow.Cells[0].Value), true);
                    frm.ShowDialog();
                }

                //return form isn't created condition
                else
                {
                    string msg = String.Format("Going List ID {0} isn't exist, Plz create it first!!", dgvGoingList.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //delete going list and return list with id
            else if (dgvGoingList.CurrentCell.ColumnIndex == 11)
            {
                //delete going list with click row's id
                id = taGoingList.DeleteGoingList(Convert.ToInt32(dgvGoingList.CurrentRow.Cells[0].Value));

                //delete return list with click row's id
                returnID = taReturnList.DeleteReturnList(dgvGoingList.CurrentRow.Cells[0].Value.ToString());

                if (id > 0 || returnID > 0)
                {
                    //taGoingListGrid.FillGoingListGrid(dsMonFactory.goingListGrid);
                    //dgvGoingList.DataSource = dsMonFactory.goingListGrid;
                    reload();
                    MessageBox.Show("delete successful!");
                }
            }
        }


        //load data to dgvGoingList
        private void CarList_Load(object sender, EventArgs e)
        {
            taGoingListGrid.FillGoingListGrid(dsMonFactory.goingListGrid);
            dgvGoingList.DataSource = dsMonFactory.goingListGrid;
        }


        //reload dgvGoingList
        public void reload()
        {
            taGoingListGrid.FillGoingListGrid(dsMonFactory.goingListGrid);
            dgvGoingList.DataSource = dsMonFactory.goingListGrid;
        }
    }
}
