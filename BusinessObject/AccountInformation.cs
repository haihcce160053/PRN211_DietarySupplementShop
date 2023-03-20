using System;
using System.Collections.Generic;

namespace DataAccess.DataAccess
{
    public partial class AccountInformation
    {
        public string Username { get; set; }
        public string AccountTypeId { get; set; }
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Account UsernameNavigation { get; set; }

    }
}
