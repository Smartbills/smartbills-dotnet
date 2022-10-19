using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Addresses
{
    public  class CreateBillingAddressRequest
    {

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; } = new CreateAddressRequest();

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
