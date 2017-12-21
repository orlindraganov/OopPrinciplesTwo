namespace BankAccounts.Models.Contracts
{
    public interface IWithdraw
    {
        void WithdrawMoney(decimal amount);
    }
}