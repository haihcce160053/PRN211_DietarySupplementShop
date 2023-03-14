using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public bool AddAccount(Account account)
        {
            return AccountDAO.Instance.AddAccount(account);
        }

        public bool DeleteAccount(string username)
        {
            return AccountDAO.Instance.DeleteAccount(username);
        }

        public IEnumerable<Account> GetAccountList()
        {
            return AccountDAO.Instance.GetAccountList();
        }

        public Account GetAccountByUsername(string username)
        {
            return AccountDAO.Instance.GetAccountByUsername(username);
        }

        public bool UpdateAccount(Account account)
        {
            return AccountDAO.Instance.UpdateAccount(account);
        }
    }
}
