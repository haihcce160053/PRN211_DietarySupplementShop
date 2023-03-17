using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductInformationRepository
    {
        IEnumerable<ProductInformation> GetProductInfoList();
        ProductInformation GetProductInfoByID(string id);
        bool AddProductInfo(ProductInformation productInformation);
        bool UpdateProductInfo(ProductInformation productInformation);
        bool DeleteProductInfo(string id);
    }
}
