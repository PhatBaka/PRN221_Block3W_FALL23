using BusinessObjects;
using BusinessObjects.Models;
using DataAccessObjects;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private AccountDAO dao;

        public AccountRepository()
        {
            dao = new AccountDAO();
        }

        public Account GetAccountByEmailAndPassword(string email, string password) => dao.GetAccountByEmailAndPassword(email, password);
    }
}
