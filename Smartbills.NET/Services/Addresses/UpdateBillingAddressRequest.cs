using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Addresses
{
    public class UpdateBillingAddressRequest
    {

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }


        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public UpdateAddressRequest Address { get; set; } = new UpdateAddressRequest();

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
