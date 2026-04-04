using manager.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace manager.DataAccess
{
    public class AccountAuth
    {
        private readonly IMongoCollection<Account> _accountCollection;

        public AccountAuth()
        {
            var context = new MongoContext();
            _accountCollection = context.GetCollection<Account>("Accounts");
        }

        // Hàm kiểm tra đăng nhập
        public async Task<Account> LoginAsync(string username, string password)
        {
            var filter = Builders<Account>.Filter.Eq(a => a.Username, username);

            var account = await _accountCollection.Find(filter).FirstOrDefaultAsync();

            if (account != null)
            {

                bool isValidPassword = BC.Verify(password, account.Password);

                if (isValidPassword)
                {
                    return account;
                }
            }

            return null;
        }
    }
}
