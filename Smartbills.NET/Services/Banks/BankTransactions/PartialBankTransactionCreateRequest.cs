namespace Smartbills.NET.Services.BankTransactions
{
    public class CreatePartialBankTransactionDTO
    {
        public long UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
