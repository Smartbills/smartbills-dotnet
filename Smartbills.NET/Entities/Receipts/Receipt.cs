using Smartbills.NET.Entities._base;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public class Receipt : SmartbillsEntityWithId
    {
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
    }
}