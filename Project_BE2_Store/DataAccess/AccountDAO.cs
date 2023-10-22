using BusinessObject;
using BusinessObject.BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                using var context = new GroceryContext();
                account = context.Accounts.ToList();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return account;
        }

        public Account GetAccountByUserName(string Username)
        {
            Account account = null;
            try
            {
                using var context = new GroceryContext();
                account = context.Accounts.SingleOrDefault(c => c.Username == Username);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return account;
        }

        public Account CreateAccount(Account account)
        {
            using var context = new GroceryContext();
            try
            {
                while (GetAccountByUserName(account.Username) != null)
                {
                    return null;
                }
                var newAccount = new Account
                {
                    Username = account.Username,
                    Password = account.Password,
                    Email = account.Email,
                    RoleId = 2,
                };
                context.Accounts.Add(newAccount);
                context.SaveChanges();
                return newAccount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
