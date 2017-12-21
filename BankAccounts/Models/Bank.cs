using System;
using System.Collections.Generic;
using BankAccounts.Models.Contracts;

namespace BankAccounts.Models
{
    internal class Bank :IBank
    {
        private IList<IAccount> accounts;

        public IList<IAccount> Accounts
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
        }
    }
}
