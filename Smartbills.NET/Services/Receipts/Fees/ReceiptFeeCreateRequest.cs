namespace Smartbills.NET.Services.Receipts.Fees
{
    public record ReceiptFeeCreateRequest
    {
        public long? FeeId { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public string Type { get; set; }
    }
}
