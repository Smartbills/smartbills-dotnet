using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptDiscounts
{
    public record CreateReceiptDiscountRequest
    {

        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("amount")]

        public string Amount { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
