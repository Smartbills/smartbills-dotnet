using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Stores
{
    public class SBStore
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        //[JsonPropertyName("address")]
        //public AddressDTO Address { get; set; }

        [JsonPropertyName("updated_at")]

        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;

        [JsonPropertyName("phone_number")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
