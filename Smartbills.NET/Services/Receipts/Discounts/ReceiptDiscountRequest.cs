using Smartbills.NET.Entities.PromoCodes;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Receipts.Discounts
{
    public record ReceiptDiscountRequest
    {

        public long? PromoCodeId { get; set; }

        public decimal Amount { get; set; }
        public string Name { get; set; }
        public decimal? Percentage { get; set; }
        public SBPromoCodeType Type { get; set; }
    }
}
