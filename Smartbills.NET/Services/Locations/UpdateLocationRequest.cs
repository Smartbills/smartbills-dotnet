using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Location
{
    public class UpdateLocationRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //[JsonPropertyName("address")]
        //public UpdateAddressRequest Address { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        [Phone]
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
