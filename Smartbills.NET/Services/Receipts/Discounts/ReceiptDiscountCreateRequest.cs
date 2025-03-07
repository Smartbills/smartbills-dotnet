using Smartbills.NET.Services.PromoCodes;

namespace Smartbills.NET.Services
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
