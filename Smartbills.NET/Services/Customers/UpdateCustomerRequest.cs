using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Customers
{
    public class UpdateCustomerRequest
    {

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("tax_exempt")]
        public bool TaxExempt { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }
    }
}
