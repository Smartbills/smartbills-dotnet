using Smartbills.NET.Services._base;
using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Locations
{
    public record UpdateLocationRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
