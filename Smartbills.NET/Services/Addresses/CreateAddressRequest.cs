using Smartbills.NET.Entities.Address;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Addresses
{
    public class CreateAddressRequest
    {
        [JsonPropertyName("line_1")]
        public string Line1 { get; set; }
        [JsonPropertyName("line_2")]
        public string Line2 { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        [JsonPropertyName("coordinates")]
        public SBCoordinate Coordinates { get; set; }

    }
}
