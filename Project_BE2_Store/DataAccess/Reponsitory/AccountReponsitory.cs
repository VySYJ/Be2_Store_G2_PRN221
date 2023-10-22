using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsitory
{
    public class AccountReponsitory : IAccountReponsitory
    {
        public IEnumerable<Account> GetAccounts()
        {
            return AccountDAO.Instance.GetAccountList();
        }

        public Account GetAccountByUserName(string Username)
        {
            return AccountDAO.Instance.GetAccountByUserName(Username);
        }
        public bool Authenticate(string username, string password)
        {
            var account = GetAccountByUserName(username);

            if (account != null && account.Password == password)
            {
                return true; // Đăng nhập thành công
            }
            return false; // Đăng nhập thất bại
        }
        public Account AddAccount(Account account)
        {
            return AccountDAO.Instance.CreateAccount(account);
        }
    }
}
