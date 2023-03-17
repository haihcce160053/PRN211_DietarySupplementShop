using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderListRepository
    {
        IEnumerable<OrderList> GetOrderList();
        OrderList GetOrderListByID(string id);
        bool AddOrderList(OrderList orderlist);
        bool UpdateOrderList(OrderList orderlist);
        bool DeleteOrderlist(string id);
    }
}
