using BankAccounts.Models.Contracts;
using Bytes2you.Validation;

namespace BankAccounts.Models
{
    public class MortgageAccount : Account, IAccount, IWithdraw
    {
        public MortgageAccount(ICustomer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public void WithdrawMoney(decimal amount)
        {
            Guard.WhenArgument(amount, "Withdraw amount cannot be negative").IsLessThan(0).Throw();
            this.Balance -= amount;
        }
    }
}
