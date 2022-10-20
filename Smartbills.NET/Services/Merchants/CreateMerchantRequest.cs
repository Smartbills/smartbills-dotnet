using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Merchants
{
    public class CreateMerchantRequest
    {
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("customer_email")]
        public string CustomerEmail { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("locale")]
        public string Locale { get; set; }
    }
}
