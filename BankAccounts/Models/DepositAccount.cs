using System;
using BankAccounts.Models.Contracts;
using Bytes2you.Validation;

namespace BankAccounts.Models
{
    public class DepositAccount : Account, IAccount, IDeposit, IWithdraw
    {
        public DepositAccount(ICustomer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        protected override decimal SpecialInterestRate
        {
            get
            {
                return this.specialInterestRate;
            }
            set
            {
                
            }
        }

        public void DepositMoney(decimal amount)
        {
            Guard.WhenArgument(amount, "Deposit amount cannot be negative").IsLessThan(0).Throw();
            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            Guard.WhenArgument(amount, "Withdraw amount cannot be negative").IsLessThan(0).Throw();
            this.Balance -= amount;
        }
    }
}
