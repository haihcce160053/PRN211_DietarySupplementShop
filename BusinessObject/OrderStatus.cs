using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderLists = new HashSet<OrderList>();
        }

        public string OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }

        public virtual ICollection<OrderList> OrderLists { get; set; }
    }
}
