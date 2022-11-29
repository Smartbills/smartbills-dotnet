using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Addresses
{
    public class CreateBillingAddressRequest
    {

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; } = new CreateAddressRequest();

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
