namespace BankAccounts.Models.Contracts
{
    public interface IDeposit
    {
        void DepositMoney(decimal amount);
    }
}