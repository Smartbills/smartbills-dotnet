namespace Smartbills.NET.Services
{
    public record AssociateBankTransactionRequest
    {
        public long BankTransactionId { get; set; }
    }
}
