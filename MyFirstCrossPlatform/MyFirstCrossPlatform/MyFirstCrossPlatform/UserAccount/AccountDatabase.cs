using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCrossPlatform.UserAccount
{
    public class AccountDatabase
    {
        readonly SQLiteAsyncConnection _accountDb;

        public AccountDatabase(string dbPath)
        {
            _accountDb = new SQLiteAsyncConnection(dbPath);
            _accountDb.CreateTableAsync<Account>().Wait();
        }

        public Task<Account> Login(string username, string password)
        {
            var account = _accountDb.Table<Account>().Where(a => a.Username == username && a.Password == password).FirstOrDefaultAsync();
            return account;
        }

        public Task<List<Account>> PopulateAccount()
        {
            return _accountDb.Table<Account>().ToListAsync();
        }
        public Task<int> CreateAccount(Account account)
        {
            return _accountDb.InsertAsync(account);
        }
    }
}
