using Smartbills.NET.Entities.Discounts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Discounts
{
    public record CreateDiscountRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        [JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }

        [JsonPropertyName("type")]
        public SBDiscountType Type { get; set; }

    }
}
