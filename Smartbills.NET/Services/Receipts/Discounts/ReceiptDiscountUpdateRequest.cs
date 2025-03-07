namespace Smartbills.NET.Services
{
    public record ReceiptDiscountUpdateRequest
    {
        public long? PromoCodeId { get; set; }
        public long ReceiptId { get; set; }
        public decimal Amount { get; set; }

        public string Name { get; set; }
        public decimal? Percentage { get; set; }
    }
}
