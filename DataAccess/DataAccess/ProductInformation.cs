using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class ProductInformation
    {
        public string ProductId { get; set; }
        public string ProductTypeId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime Exp { get; set; }
        public string Origin { get; set; }
        public int SoldAmount { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
