using DataAccess.DataAccess;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DietarySupplementalShop
{
    public partial class frmProductCRUD : Form
    {
        private string id;
        private int CRUDStatus;

        public frmProductCRUD(string id, int CRUDStatus)
        {
            InitializeComponent();
            this.id = id;
            this.CRUDStatus = CRUDStatus;
        }

        private void frmProductCRUD_Load(object sender, EventArgs e)
        {
            //Create
            if (CRUDStatus == 1)
            {
                txtProductID.ReadOnly = false;
                btnProcess.Text = "Create product";
                this.Text = "Create new product";
            }

            //Update
            if (CRUDStatus == 2)
            {
                GetProductInformation();
                btnProcess.Text = "Update product";
                this.Text = "Update product information";
            }

            //Delete
            if (CRUDStatus == 3)
            {
                GetProductInformation();
                btnProcess.Text = "Delete product";
                this.Text = "Delete product";
            }

            //View
            if (CRUDStatus == 4)
            {
                GetProductInformation();
                btnProcess.Hide();
                this.Text = "View product information";
            }
        }

        private void GetProductInformation()
        {
            IProductRepository IProduct = new ProductRepository();
            IProductInformationRepository IProductInfo = new ProductInformationRepository();
            Product product = IProduct.GetProductByID(id);
            ProductInformation productInfo = IProductInfo.GetProductInfoByID(id);

            if (product != null && productInfo != null)
            {
                txtProductID.Text = product.ProductId;
                cbProductType.SelectedIndex = cbProductType.FindStringExact(productInfo.ProductTypeId);
                txtProductName.Text = product.ProductName;
                txtPictureLink.Text = product.PictureLink;
                txtDescription.Text = product.Description;
                txtQuantity.Text = productInfo.Quantity.ToString();
                txtPrice.Text = productInfo.Price.ToString();
                dateTimeEXP.Value = productInfo.Exp;
                txtOrigin.Text = productInfo.Origin;
                txtSoldAmmount.Text = productInfo.SoldAmount.ToString();
            }
        }

        private void CreateProduct()
        {
            Product product = new Product();
            ProductInformation productInfo = new ProductInformation();
            product.ProductId = txtProductID.Text;
            productInfo.ProductId = txtProductID.Text;
            productInfo.ProductTypeId = cbProductType.Text;
            product.ProductName = txtProductName.Text;
            product.PictureLink = txtPictureLink.Text;
            product.Description = txtDescription.Text;
            productInfo.Quantity = Convert.ToInt32(txtQuantity.Text);
            productInfo.Price = Convert.ToInt32(txtPrice.Text);
            productInfo.Exp = dateTimeEXP.Value;
            productInfo.Origin = txtOrigin.Text;
            productInfo.SoldAmount = Convert.ToInt32(txtSoldAmmount.Text);

            IProductRepository IProduct = new ProductRepository();
            IProductInformationRepository IProductInfo = new ProductInformationRepository();

            if (IProduct.AddProduct(product) == true && IProductInfo.AddProductInfo(productInfo) == true)
            {
                MessageBox.Show("Create product for " + product.ProductId + " successful");
            }
            else
            {
                MessageBox.Show("Create account for " + product.ProductId + " failed");
            }
        }

        private void UpdateProductInformation()
        {
            Product product = new Product();
            ProductInformation productInfo = new ProductInformation();

            product.ProductId = txtProductID.Text;
            productInfo.ProductId = txtProductID.Text;
            productInfo.ProductTypeId = cbProductType.Text;
            product.ProductName = txtProductName.Text;
            product.PictureLink = txtPictureLink.Text;
            product.Description = txtDescription.Text;
            productInfo.Quantity = Convert.ToInt32(txtQuantity.Text);
            productInfo.Price = Convert.ToInt32(txtPrice.Text);
            productInfo.Exp = dateTimeEXP.Value;
            productInfo.Origin = txtOrigin.Text;
            productInfo.SoldAmount = Convert.ToInt32(txtSoldAmmount.Text);

            IProductRepository IProduct = new ProductRepository();
            IProductInformationRepository IProductInfo = new ProductInformationRepository();

            if (IProduct.UpdateProduct(product) == true && IProductInfo.UpdateProductInfo(productInfo) == true)
            {
                MessageBox.Show("Update product for " + product.ProductId + " successful");
            }
            else
            {
                MessageBox.Show("Update account for " + product.ProductId + " failed");
            }
        }

        private void DeleteProduct()
        {
            IProductRepository IProduct = new ProductRepository();
            IProductInformationRepository IProductInfo = new ProductInformationRepository();
            if (IProductInfo.DeleteProductInfo(id) == true && IProduct.DeleteProduct(id) == true)
            {
                MessageBox.Show("Delete product for " + id + " successful");
            }
            else
            {
                MessageBox.Show("Delete product for " + id + " failed");
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Add new product
            if (CRUDStatus == 1)
            {
                CreateProduct();
                this.Close();
            }

            //Update product
            if (CRUDStatus == 2)
            {
                UpdateProductInformation();
                this.Close();
            }

            //Delete product
            if (CRUDStatus == 3)
            {
                DeleteProduct();
                this.Close();
            }
        }
    }
}
