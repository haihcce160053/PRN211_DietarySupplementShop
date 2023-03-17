using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductInformationDAO
    {
        private static ProductInformationDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductInformationDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductInformationDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<ProductInformation> GetProductInfoList()
        {
            var productInfo = new List<ProductInformation>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                productInfo = context.ProductInformations.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return productInfo;
        }

        public ProductInformation GetProductInfoByID(string id)
        {
            ProductInformation productInfo = null;
            try
            {
                using var context = new FIVESTOREFINALContext();
                productInfo = context.ProductInformations.SingleOrDefault(c => c.ProductId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return productInfo;
        }

        public bool AddProductInfo(ProductInformation productInfo)
        {
            try
            {
                ProductInformation _productInfo = GetProductInfoByID(productInfo.ProductId);
                if (_productInfo == null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.ProductInformations.Add(productInfo);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public bool UpdateProductInfo(ProductInformation productInfo)
        {
            try
            {
                ProductInformation _productInfo = GetProductInfoByID(productInfo.ProductId);
                if (_productInfo != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.ProductInformations.Update(productInfo);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public bool DeleteProductInfo(string id)
        {
            try
            {
                ProductInformation _productInfo = GetProductInfoByID(id);
                if (_productInfo != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.ProductInformations.Remove(_productInfo);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}
