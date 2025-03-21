namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public class CreatePartialBankTransactionDTO
    {
        public long UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
