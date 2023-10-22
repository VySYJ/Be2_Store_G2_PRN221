using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsitory
{
    public interface IAccountReponsitory
    {
        IEnumerable<Account> GetAccounts();

        Account GetAccountByUserName(string Username);

        bool Authenticate(string username, string password);
        Account AddAccount(Account account);
    }
}
