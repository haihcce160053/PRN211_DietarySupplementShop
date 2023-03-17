using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderListDAO
    {
        private static OrderListDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderListDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderListDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderList> GetOrderList()
        {
            var orderlist = new List<OrderList>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                orderlist = context.OrderLists.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderlist;
        }

        public OrderList GetOrderListByID(string id)
        {
            OrderList orderlist = null;
            try
            {
                using var context = new FIVESTOREFINALContext();
                orderlist = context.OrderLists.SingleOrDefault(c => c.OrderId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return orderlist;
        }

        public bool AddOrderList(OrderList orderlist)
        {
            try
            {
                OrderList _orderlist = GetOrderListByID(orderlist.OrderId);
                if (_orderlist == null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.OrderLists.Add(orderlist);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The order is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public bool UpdateOrderList(OrderList orderList)
        {
            try
            {
                OrderList _orderlist = GetOrderListByID(orderList.OrderId);
                if (_orderlist != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.OrderLists.Update(orderList);
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

        public bool DeleteOrderList(string id)
        {
            try
            {
                OrderList _orderlist = GetOrderListByID(id);
                if (_orderlist != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.OrderLists.Remove(_orderlist);
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
