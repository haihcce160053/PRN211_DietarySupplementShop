using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(Product product)
        {
            return ProductDAO.Instance.AddProduct(product);
        }

        public bool DeleteProduct(string id)
        {
            return ProductDAO.Instance.DeleteProduct(id);
        }

        public Product GetProductByID(string id)
        {
            return ProductDAO.Instance.GetProductByID(id);
        }

        public IEnumerable<Product> GetProductList()
        {
            return ProductDAO.Instance.GetProductList();
        }

        public bool UpdateProduct(Product product)
        {
            return ProductDAO.Instance.UpdateProduct(product);
        }
    }
}
