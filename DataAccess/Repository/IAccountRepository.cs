using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccountList();
        Account GetAccountByUsername(string username);
        bool AddAccount(Account account);
        bool UpdateAccount(Account account);
        bool DeleteAccount(string username);
    }
}
