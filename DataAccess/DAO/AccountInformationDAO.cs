using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountInformationInformationDAO
    {
        private static AccountInformationInformationDAO instance = null;
        private static readonly object instanceLock = new object();
        public static AccountInformationInformationDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountInformationInformationDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<AccountInformation> GetAccountInformationList()
        {
            var AccountInformation = new List<AccountInformation>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                AccountInformation = context.AccountInformations.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return AccountInformation;
        }

        public AccountInformation GetAccountInformationByUsername(string username)
        {
            AccountInformation AccountInformation = null;
            try
            {
                using var context = new FIVESTOREFINALContext();
                AccountInformation = context.AccountInformations.SingleOrDefault(c => c.Username == username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return AccountInformation;
        }

        public bool AddAccountInformation(AccountInformation AccountInformation)
        {
            try
            {
                AccountInformation accountInfo = GetAccountInformationByUsername(AccountInformation.Username);
                if (accountInfo == null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.AccountInformations.Add(AccountInformation);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The account is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public bool UpdateAccountInformation(AccountInformation AccountInformation)
        {
            try
            {
                AccountInformation accountInfo = GetAccountInformationByUsername(AccountInformation.Username);
                if (accountInfo != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.AccountInformations.Update(AccountInformation);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The account does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public bool DeleteAccountInformation(string username)
        {
            try
            {
                AccountInformation accountInfo = GetAccountInformationByUsername(username);
                if (accountInfo != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.AccountInformations.Remove(accountInfo);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The account does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}
