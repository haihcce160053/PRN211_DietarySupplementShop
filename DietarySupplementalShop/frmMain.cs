using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySupplementalShop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello, " + frmLogin.myUsername;
        }

        private void btnAccountMng_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement();
            accountManagement.Show();
        }

        private void btnProductMng_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
        }

        private void btnOrderMng_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Show();
        }
    }
}
