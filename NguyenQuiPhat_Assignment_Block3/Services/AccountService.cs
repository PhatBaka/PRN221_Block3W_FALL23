using BusinessObjects;
using BusinessObjects.Helpers;
using BusinessObjects.Models;
using Repositories;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        //public AccountService(IAccountRepository accountRepository)
        //{
        //    _accountRepository = accountRepository;
        //}

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }
        public Account GetAccountByEmailAndPassword(string email, string password)
        {
            try
            {
                return _accountRepository.GetAccountByEmailAndPassword(email, password);          
            }
            catch (Exception ex)
            {
                LoggerService.Logger(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
