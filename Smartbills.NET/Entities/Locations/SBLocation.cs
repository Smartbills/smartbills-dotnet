using Smartbills.NET.Constants;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Locations
{
    public class SBLocation
    {
        [JsonPropertyName("address")]
        public SBAddress Address { get; set; }

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

        [JsonPropertyName(CommonProperties.MERCHANT_ID)]
        public long? MerchantId { get; set; }
    }
}
