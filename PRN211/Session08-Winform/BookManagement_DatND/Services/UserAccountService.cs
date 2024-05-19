using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new UserAccountRepository();

        public UserAccount? CheckLogin(string username, string password)
        {
            return _repo.GetAccount(username, password);
        }

    }
}
