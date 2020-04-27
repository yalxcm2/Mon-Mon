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
    public partial class UserLists : Form
    {
        public UserLists()
        {
            InitializeComponent();
        }


        Boolean isUpdate = false;
        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.userTableAdapter taUser = new dsMonFactoryTableAdapters.userTableAdapter();
        dsMonFactoryTableAdapters.userGridTableAdapter taUserGrid = new dsMonFactoryTableAdapters.userGridTableAdapter();




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserUpdate uUpdate = new UserUpdate();
            uUpdate.Show();
        }


        //fill user'Grid
        private void UserLists_Load(object sender, EventArgs e)
        {
            taUserGrid.FillUserGrid(dsMonFactory.userGrid);
            dgvUser.DataSource = dsMonFactory.userGrid;

            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                dgvUser.Rows[i].Cells[0].Value = "Update";
                dgvUser.Rows[i].Cells[1].Value = "Delete";

            }
        }


        //fill user's Grid
        public void reload_UserList()
        {
            taUserGrid.FillUserGrid(dsMonFactory.userGrid);
            dgvUser.DataSource = dsMonFactory.userGrid;

            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                dgvUser.Rows[i].Cells[0].Value = "Update";
                dgvUser.Rows[i].Cells[1].Value = "Delete";

            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("Row: {0}, Column: {1}",
            //dgvUser.CurrentCell.RowIndex,
            //dgvUser.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");


            //update user and reload dgvUser
            if (dgvUser.CurrentCell.ColumnIndex == 0)
            {
                isUpdate = true;
                Register r = new Register(isUpdate, Convert.ToInt32(dgvUser.CurrentRow.Cells[2].Value));
                r.ShowDialog();

                reload_UserList();
            }


            //delete user and reload dgvUser
            else if (dgvUser.CurrentCell.ColumnIndex == 1)
            {
                taUser.DeleteUserByID(Convert.ToInt32(dgvUser.CurrentRow.Cells[2].Value));
                taUserGrid.FillUserGrid(dsMonFactory.userGrid);
                dgvUser.DataSource = dsMonFactory.userGrid;


            }
        }
    }
}
