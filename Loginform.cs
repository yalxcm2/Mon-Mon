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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.userTableAdapter taUser = new dsMonFactoryTableAdapters.userTableAdapter();

        private void Loginform_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int id = -1;
            id = taUser.FillUserByUserNameAndPassword(dsMonFactory.user, txtUserName.Text, txtPassword.Text);
            if (id > 0)
            {
                MainForm frm = new MainForm();
                frm.ShowDialog();
                this.Close();

            }
            else
            {
                txtUserName.Text = "Login fail";
                MessageBox.Show("Your User Name or Password is invalid!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = string.Empty;
                txtUserName.Text = string.Empty;
            }

        }
    }
}
