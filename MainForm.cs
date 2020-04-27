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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void btnProductPrice_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductPrice);
        }
        private void customizeDesign()
        {
            panelProductPrice.Visible = false;
            panelVoucherList.Visible = false;
           

        }
        public void hideSubMenu()
        {
            if (panelProductPrice.Visible == true)
                panelProductPrice.Visible = false;
            if (panelVoucherList.Visible == true)
                panelVoucherList.Visible = false;


        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnVoucherList_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVoucherList);
        }

        private Form activeform = null;

        public void openChildForm(Form childform)
        {
           
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childform);
           panelChild.Tag = childform;
            panelChild.BringToFront();
            childform.Show();
        }

       

        private void btnSellingVoucher_Click(object sender, EventArgs e)
        {
            CreateSellingVoucher f=new CreateSellingVoucher();
            f.Show();
        }

        private void btnSellingProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new SellingVoucherList());
            hideSubMenu();
        }

        private void btnSellingProductPrice_Click_1(object sender, EventArgs e)
        {
            openChildForm(new SellingProductPrice());
            hideSubMenu();
        }

        private void btnBuyingProductPrice_Click(object sender, EventArgs e)
        {
            openChildForm(new BuyingProductPrice());
            hideSubMenu();
        }

        private void btnBuyingVoucherList_Click(object sender, EventArgs e)
        {
            openChildForm(new BuyingVoucheList());
            hideSubMenu();
        }

        private void btnSabarVoucher_Click(object sender, EventArgs e)
        {
            openChildForm(new SabarVoucher());
            hideSubMenu();
        }

        private void btnSabarVoucherList_Click(object sender, EventArgs e)
        {
            openChildForm(new SabarVoucherList());
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Loginform login = new Loginform();
            login.Show();
            this.Close();
    
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            openChildForm(new Register());
            hideSubMenu();
        }

        private void btnUserLists_Click(object sender, EventArgs e)
        {
            openChildForm(new UserLists());
            hideSubMenu();
        }

        private void btnSellingVoucher_Click_1(object sender, EventArgs e)
        {
            CreateSellingVoucher csv = new CreateSellingVoucher();
            csv.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            openChildForm(new CarList());
            hideSubMenu();
        }

        private void btnTransportation_Click(object sender, EventArgs e)
        {
            openChildForm(new Going());
            hideSubMenu();
        }

        public void reload_CarList()
        {
            openChildForm(new CarList());
            hideSubMenu();
            MessageBox.Show("sdfsdbbb");
        }
    }
}
