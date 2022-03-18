using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SBCompanyCustomer
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("phone")]

        public string Phone { get; set; }
        [JsonPropertyName("tags")]

        public List<string> Tags { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
