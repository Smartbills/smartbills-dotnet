using Smartbills.NET.Entities.Discounts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptDiscounts
{
    public record CreateReceiptDiscountRequest
    {
        [JsonPropertyName("discount_id")]
        public long? DiscountId { get; set; }

        [JsonPropertyName("amount")]

        public decimal Amount { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }

        [JsonPropertyName("type")]
        public SBDiscountType Type { get; set; }

    }
}
