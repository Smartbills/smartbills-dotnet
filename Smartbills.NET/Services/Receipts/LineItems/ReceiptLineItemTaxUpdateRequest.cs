namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemTaxUpdateRequest
    {
        public long? TaxId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
