using Smartbills.NET.Services.Merchants.PromoCodes;

namespace Smartbills.NET.Services.Receipts.Discounts
{
    public record ReceiptDiscountCreateRequest : IOptionalPromoCodeId
    {

        public long? PromoCodeId { get; set; }
        public long ReceiptId { get; set; }
        public decimal Amount { get; set; }

        public string Name { get; set; }

        public decimal? Percentage { get; set; }
    }
}
