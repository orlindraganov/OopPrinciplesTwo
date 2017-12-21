using System.Collections;
using System.Collections.Generic;

namespace BankAccounts.Models.Contracts
{
    public interface IBank
    {
        IList<IAccount> Accounts { get; }
    }
}