using BusinessObjects.Helpers;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        private readonly FlowerShopContext myFlowerDB;

        public AccountDAO()
        {
            myFlowerDB = new FlowerShopContext();
        }

        public Account GetAccountByEmailAndPassword(string email, string password)
        {
            try
            {

                return myFlowerDB.Accounts.Include(a => a.OrderCustomers)
                                            .SingleOrDefault(a => a.Email.Equals(email)
                                                                    && a.Password.Equals(password));
            }
            catch (Exception ex)
            {
                LoggerService.Logger(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
