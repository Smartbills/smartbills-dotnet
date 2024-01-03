using Smartbills.NET.Constants;
using Smartbills.NET.Entities.Address;
using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Locations
{
    public record SBLocation : SmartbillsEntityWithId
    {
        
        public SBAddress Address { get; set; }

        

        public DateTimeOffset? UpdatedAt { get; set; }

        
        public DateTimeOffset CreatedAt { get; set; }
        public string Name { get; set; }
        
        public bool Active { get; set; } = true;

        
        public string PhoneNumber { get; set; }

        [JsonPropertyName(CommonProperties.MerchantId)]
        public long? MerchantId { get; set; }
    }
}
