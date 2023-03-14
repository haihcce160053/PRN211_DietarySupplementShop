using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class Account
    {
        public Account()
        {
            OrderLists = new HashSet<OrderList>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string SercurityAnswer { get; set; }

        public virtual ICollection<OrderList> OrderLists { get; set; }
    }
}
