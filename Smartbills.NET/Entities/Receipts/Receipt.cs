
using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class Receipt : SmartbillsEntityWithId
    {
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        [JsonPropertyName("user_id")]
        public Guid UserId { get; set; }
    }
}