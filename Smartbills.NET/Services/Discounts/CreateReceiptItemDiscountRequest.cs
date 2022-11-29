using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Discounts
{
    public record CreateReceiptItemDiscountRequest : BaseRequest
    {
        [JsonPropertyName("discount_id")]
        public long DiscountId { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
    }
}
