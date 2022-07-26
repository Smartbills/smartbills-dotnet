using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Companies
{
    public class CreateCustomerRequest
    {

        [MaxLength(255)]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [MaxLength(255)]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [EmailAddress]
        [JsonPropertyName("email")]

        public string Email { get; set; }
        [JsonPropertyName("tax_exempt")]
        public bool TaxExempt { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
        [MaxLength(3)]
        [Required]
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        [JsonPropertyName("phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

    }
}
