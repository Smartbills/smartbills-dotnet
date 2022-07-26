using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public class DeleteLocationRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //[JsonPropertyName("address")]
        //public CreateAddressDTO Address { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        [Phone]
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
