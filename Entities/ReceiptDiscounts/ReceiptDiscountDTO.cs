using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities.ReceiptDiscounts
{
    public class ReceiptDiscountDTO
    {

        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
