namespace Smartbills.NET.Services
{
    public record BankTransactionFilters
    {
        public bool? Linked { get; set; } = null;
    }
}
