using Smartbills.NET.Entities.PromoCodes;
using Smartbills.NET.Entities.Receipts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptDiscounts
{
    public record SBReceiptDiscount
    {
        public long? PromoCodeId { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public decimal? Percentage { get; set; }
    }
}
