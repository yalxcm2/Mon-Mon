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
    public partial class Register : Form
    {

        Boolean isEdit = false;
        int updateID;


        public Register()
        {
            InitializeComponent();
        }


        //constructor for update register form
        public Register(Boolean isEdit, int updateID)
        {
            this.isEdit = isEdit;
            this.updateID = updateID;
            InitializeComponent();
        }


        dsMonFactory dsMonFactory = new dsMonFactory();
        dsMonFactoryTableAdapters.userTableAdapter taUser = new dsMonFactoryTableAdapters.userTableAdapter();
        dsMonFactoryTableAdapters.userByIDTableAdapter taUserByID = new dsMonFactoryTableAdapters.userByIDTableAdapter();


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Add's action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check txtUserName
            if (txtUserName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter User Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                txtUserName.SelectAll();
            }
            //check cboUserType
            else if (cboUserType.SelectedIndex < 0)
            {
                MessageBox.Show("Select your User type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboUserType.Focus();
                cboUserType.SelectAll();


            }
            //check txtPassword
            else if (txtPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter your password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                txtPassword.SelectAll();
            }

            //check txtConfirmPassword
            else if (txtConfirmPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Enter your Confirm Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
            }
            //check txtPassword is equal txtConfirmPassword
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password must be same!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                //isEdit for Add
                if (isEdit)
                {
                    int id = 0;
                    //check isEdit is exist or not
                    id = taUser.UpdateUser(cboUserType.SelectedItem.ToString(), txtPassword.Text, txtUserName.Text, updateID);
                    if (id > 0)
                    {
                        txtUserName.Text = string.Empty;
                        txtConfirmPassword.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        cboUserType.SelectedIndex = -1;

                        MessageBox.Show("Update User Successful!");
                    }
                }
                else
                {
                    int id = -1;
                    //check insert user is successful or not
                    id = taUser.InsertUser(cboUserType.SelectedItem.ToString(), txtPassword.Text, txtUserName.Text);
                    if (id > 0)
                    {
                        MessageBox.Show("Add User Successful!");
                        txtUserName.Text = string.Empty;
                        txtConfirmPassword.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        cboUserType.SelectedIndex = -1;

                    }
                }
            }    
        }


        //load data for register form
        private void Register_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                taUserByID.FillUserByID(dsMonFactory.userByID, updateID);
                txtUserName.Text = dsMonFactory.userByID.Rows[0]["username"].ToString();
                txtPassword.Text = dsMonFactory.userByID.Rows[0]["userpassword"].ToString();
                txtConfirmPassword.Text = dsMonFactory.userByID.Rows[0]["userpassword"].ToString();
                cboUserType.SelectedItem = dsMonFactory.userByID.Rows[0]["usertype"].ToString();
            }
        }
    }
}
