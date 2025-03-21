namespace Smartbills.NET.Services.Receipts.ReceiptTaxes
{
    public record ReceiptTaxUpdateRequest
    {
        public long? TaxId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal? Percentage { get; set; }
    }
}
