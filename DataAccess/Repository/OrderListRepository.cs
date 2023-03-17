using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderListRepository : IOrderListRepository
    {
        public bool AddOrderList(OrderList orderlist)
        {
            return OrderListDAO.Instance.AddOrderList(orderlist);
        }

        public bool DeleteOrderlist(string id)
        {
            return OrderListDAO.Instance.DeleteOrderList(id);
        }

        public IEnumerable<OrderList> GetOrderList()
        {
            return OrderListDAO.Instance.GetOrderList();
        }

        public OrderList GetOrderListByID(string id)
        {
            return OrderListDAO.Instance.GetOrderListByID(id);
        }

        public bool UpdateOrderList(OrderList orderlist)
        {
            return OrderListDAO.Instance.UpdateOrderList(orderlist);
        }
    }
}
