using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class OrderList
    {
        public string OrderId { get; set; }
        public string OrderStatusId { get; set; }
        public string Username { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime OrderTime { get; set; }
        public int TotalBill { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
