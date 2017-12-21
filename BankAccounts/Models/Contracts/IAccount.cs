using System;

namespace BankAccounts.Models.Contracts
{
    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Balance { get; }

        decimal InterestRate { get; }

        decimal CalculateInterestAmount();
    }
}