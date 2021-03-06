using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SBCompany
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("customer_email")]
        public string CustomerEmail { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        [JsonPropertyName("hq_phone_number")]
        public string HQPhoneNumber { get; set; }
        [JsonPropertyName("hq_address")]
        public virtual SBAddress HQAddress { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
