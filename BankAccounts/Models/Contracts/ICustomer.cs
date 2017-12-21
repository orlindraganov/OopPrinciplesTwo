using System;

namespace BankAccounts.Models.Contracts
{
    public interface ICustomer
    {
        string Name { get; }
        CustomerType Type { get; }
    }
}