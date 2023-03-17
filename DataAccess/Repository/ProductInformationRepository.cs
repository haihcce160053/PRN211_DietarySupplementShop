using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductInformationRepository : IProductInformationRepository
    {
        public bool AddProductInfo(ProductInformation productInformation)
        {
            return ProductInformationDAO.Instance.AddProductInfo(productInformation);
        }

        public bool DeleteProductInfo(string id)
        {
            return ProductInformationDAO.Instance.DeleteProductInfo(id);
        }

        public ProductInformation GetProductInfoByID(string id)
        {
            return ProductInformationDAO.Instance.GetProductInfoByID(id);
        }

        public IEnumerable<ProductInformation> GetProductInfoList()
        {
            return ProductInformationDAO.Instance.GetProductInfoList();
        }

        public bool UpdateProductInfo(ProductInformation productInformation)
        {
            return ProductInformationDAO.Instance.UpdateProductInfo(productInformation);
        }
    }
}
