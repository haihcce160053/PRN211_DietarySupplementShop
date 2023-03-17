using DataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
   public class OrderDetailDAO
   {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail>GetOrderDetailList()
        {
            var orderdetail = new List<OrderDetail>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                orderdetail = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderdetail;
        }

        public IEnumerable<OrderDetail> GetOrderDetailByID(string id)
        {
            var orderdetail = new List<OrderDetail>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                orderdetail = context.OrderDetails.Where(o => o.OrderId == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return orderdetail;
        }

        public bool UpdateOrderDetail(OrderDetail orderdetail)
        {
            try
            {
                IEnumerable<OrderDetail> _orderdetail = GetOrderDetailByID(orderdetail.OrderId);
                if (_orderdetail != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.OrderDetails.Update(orderdetail);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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
