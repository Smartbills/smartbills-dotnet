using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Discounts
{
    public record SBDiscount : SmartbillsEntityWithId
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        [JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }

        [JsonPropertyName("type")]
        public SBDiscountType Type { get; set; } = SBDiscountType.AMOUNT;
    }
}
