using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();
        Product GetProductByID(string id);
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(string id);
    }
}
