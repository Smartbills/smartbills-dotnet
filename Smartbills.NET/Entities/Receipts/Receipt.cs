using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public record Receipt : SmartbillsEntityWithId
    {
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
    }
}