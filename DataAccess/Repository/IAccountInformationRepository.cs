using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAccountInformationRepository
    {
        IEnumerable<AccountInformation> GetAccountInformationList();
        AccountInformation GetAccountInformationByUsername(string username);
        bool AddAccountInformation(AccountInformation account);
        bool UpdateAccountInformation(AccountInformation account);
        bool DeleteAccountInformation(string username);
    }
}
