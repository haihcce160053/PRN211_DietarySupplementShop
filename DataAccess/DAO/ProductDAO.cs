using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetProductList()
        {
            var product = new List<Product>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                product = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public Product GetProductByID(string id)
        {
            Product product = null;
            try
            {
                using var context = new FIVESTOREFINALContext();
                product = context.Products.SingleOrDefault(c => c.ProductId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return product;
        }

        public bool AddProduct(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product == null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.Products.Add(product);
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

        public bool UpdateProduct(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.Products.Update(product);
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

        public bool DeleteProduct(string id)
        {
            try
            {
                Product _product = GetProductByID(id);
                if (_product != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.Products.Remove(_product);
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
