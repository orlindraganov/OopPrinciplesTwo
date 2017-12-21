using System;
using BankAccounts.Models.Contracts;
using Bytes2you.Validation;

namespace BankAccounts.Models
{
    public abstract class Account : IAccount
    {
        private readonly ICustomer customer;
        private decimal balance;
        private decimal interestRate;
        private readonly DateTime accountCreationDate;
        private bool isSpecialInterestProvisionActive;
        private decimal specialInterestRate;

        public Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            Guard.WhenArgument(customer, "Customer cannot be null").IsNull().Throw();
            this.customer = customer;

            this.Balance = balance;
            this.InterestRate = interestRate;
            this.accountCreationDate = DateTime.Today;
        }

        public ICustomer Customer => this.customer;

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                Guard.WhenArgument(value, "Interest rate cannot be negative").IsLessThan(0).Throw();
                this.interestRate = value;
            }
        }

        public DateTime AccountCreationDate => this.accountCreationDate;

        protected bool IsSpecialInterestProvisionActive
        {
            get
            {
                return this.isSpecialInterestProvisionActive;
            }
            set
            {
                this.isSpecialInterestProvisionActive = value;
            }
        }

        protected virtual decimal SpecialInterestRate
        {
            get
            {
                return this.specialInterestRate;
            }
            set
            {
                this.specialInterestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount()
        {
            var today = DateTime.Today;
            var monthsElapsed = (today.Year - this.AccountCreationDate.Year) * 12 + today.Month - this.AccountCreationDate.Month;
            decimal rate;

            if (this.IsSpecialInterestProvisionActive)
            {
                rate = this.SpecialInterestRate;
            }
            else
            {
                rate = this.InterestRate;
            }

            return monthsElapsed * rate;
        }
    }
}
