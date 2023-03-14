using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Account> GetAccountList()
        {
            var account = new List<Account>();
            try
            {
                using var context = new FIVESTOREFINALContext();
                account = context.Accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }

        public Account GetAccountByUsername(string username)
        {
            Account account = null;
            try
            {
                using var context = new FIVESTOREFINALContext();
                account = context.Accounts.SingleOrDefault(c => c.Username == username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return account;
        }

        public bool AddAccount(Account account)
        {
            try
            {
                Account _account = GetAccountByUsername(account.Username);
                if (_account == null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.Accounts.Add(account);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public bool UpdateAccount(Account account)
        {
            try
            {
                Account _account = GetAccountByUsername(account.Username);
                if (_account != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.Accounts.Update(account);
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

        public bool DeleteAccount(string username)
        {
            try
            {
                Account _account = GetAccountByUsername(username);
                if (_account != null)
                {
                    using var context = new FIVESTOREFINALContext();
                    context.Accounts.Remove(_account);
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
