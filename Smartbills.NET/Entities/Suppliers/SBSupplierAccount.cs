namespace Smartbills.NET.Entities.Suppliers
{
    public record SBSupplierAccount : SBEntity
    {
        public string AccountNumber { get; set; }
        public string AccountId { get; set; }
        public decimal? AccountAge { get; set; }
        public decimal? InvoiceCount { get; set; }
        public decimal? TotalCharged { get; set; }
        public decimal? LatePaymentCount { get; set; }
        public decimal? CurrentLateBalance { get; set; }
        public string CurrencyCode { get; set; }
    }
}