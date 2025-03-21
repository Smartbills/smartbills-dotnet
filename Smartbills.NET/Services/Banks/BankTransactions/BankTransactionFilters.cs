namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public record BankTransactionFilters
    {
        public bool? Linked { get; set; } = null;
    }
}
