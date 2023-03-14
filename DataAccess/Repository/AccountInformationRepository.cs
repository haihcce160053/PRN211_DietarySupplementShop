using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AccountInformationRepository : IAccountInformationRepository
    {
        public bool AddAccountInformation(AccountInformation account)
        {
            return AccountInformationInformationDAO.Instance.AddAccountInformation(account);
        }

        public bool DeleteAccountInformation(string username)
        {
            return AccountInformationInformationDAO.Instance.DeleteAccountInformation(username);
        }

        public AccountInformation GetAccountInformationByUsername(string username)
        {
            return AccountInformationInformationDAO.Instance.GetAccountInformationByUsername(username);
        }

        public IEnumerable<AccountInformation> GetAccountInformationList()
        {
            return AccountInformationInformationDAO.Instance.GetAccountInformationList();
        }

        public bool UpdateAccountInformation(AccountInformation account)
        {
            return AccountInformationInformationDAO.Instance.UpdateAccountInformation(account);
        }
    }
}
