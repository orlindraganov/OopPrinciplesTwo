using BankAccounts.Models.Contracts;
using Bytes2you.Validation;

namespace BankAccounts.Models
{
    public class Customer : ICustomer
    {
        private readonly string name;
        private readonly CustomerType type;

        public Customer(string name, CustomerType type)
        {
            Guard.WhenArgument(name, "First name cannot be null or empty").IsNullOrEmpty().Throw();
            this.name = name;
            this.type = type;
        }

        public string Name => this.name;
        public CustomerType Type => this.type;
    }
}
