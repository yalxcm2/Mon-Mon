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
    public partial class BuyingVoucheList : Form
    {
        public BuyingVoucheList()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBuyingVoucher ubv = new UpdateBuyingVoucher();
            ubv.Show();
        }
    }
}
