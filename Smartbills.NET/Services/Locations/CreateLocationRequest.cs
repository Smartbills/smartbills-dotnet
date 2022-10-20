using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Locations
{
    public class CreateLocationRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; }

        [JsonPropertyName("description")]
        public CreateAddressRequest Description { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }


        [JsonPropertyName("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonPropertyName("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonPropertyName("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }


        [JsonPropertyName("mcc")]
        public string MCC { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}
