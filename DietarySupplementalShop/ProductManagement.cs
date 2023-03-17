using DataAccess.DataAccess;
using DataAccess.Repository;
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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            IProductRepository IProduct = new ProductRepository();
            List<Product> product = new List<Product>(IProduct.GetProductList());
            if (product != null)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView1.Columns.Add("ProductID", "Product ID");
                dataGridView1.Columns.Add("ProductName", "Product Name");
                dataGridView1.Columns.Add("PictureLink", "PictureLink");
                dataGridView1.Columns.Add("Description", "Description");
                dataGridView1.ClearSelection();

                for (int i = 0; i < product.Count; i++)
                {
                    dataGridView1.Rows.Add(product[i].ProductId,
                        product[i].ProductName,
                        product[i].PictureLink,
                        product[i].Description);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].Value != null
               && dataGridView1.SelectedCells[1].Value != null
               && dataGridView1.SelectedCells[2].Value != null
               && dataGridView1.SelectedCells[3].Value != null)
                {
                    txtProductID.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    txtProductName.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    txtPictureLink.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    txtDescription.Text = dataGridView1.SelectedCells[3].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductCRUD frmProductCRUD = new frmProductCRUD(txtProductID.Text, 1);
            frmProductCRUD.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductCRUD frmProductCRUD = new frmProductCRUD(txtProductID.Text, 2);
            frmProductCRUD.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmProductCRUD frmProductCRUD = new frmProductCRUD(txtProductID.Text, 3);
            frmProductCRUD.Show();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmProductCRUD frmProductCRUD = new frmProductCRUD(txtProductID.Text, 4);
            frmProductCRUD.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
