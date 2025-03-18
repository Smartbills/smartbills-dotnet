namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public record AssociateBankTransactionRequest
    {
        public long BankTransactionId { get; set; }
    }
}
