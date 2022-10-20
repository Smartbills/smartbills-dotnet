using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Merchants
{
    public record UpdateMerchantRequest : BaseRequest
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
        [JsonPropertyName("phone_number")]
        public string Phone { get; set; }
        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        public string Locale { get; set; }
    }
}
