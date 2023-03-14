﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class OrderDetail
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

        public virtual OrderList Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
