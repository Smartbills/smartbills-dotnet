using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public class CreateMerchantRequest
    {
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
        public CreateAddressRequest HQAddress { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
