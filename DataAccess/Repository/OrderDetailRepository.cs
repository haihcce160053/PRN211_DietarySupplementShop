using DataAccess.DAO;
using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            return OrderDetailDAO.Instance.GetOrderDetailList();
        }

        public IEnumerable<OrderDetail> GetOrderDetailByID(string id)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByID(id);
        }

        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            return OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
        }
    }
}
