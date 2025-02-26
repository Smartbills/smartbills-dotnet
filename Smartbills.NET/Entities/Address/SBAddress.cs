using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Address
{
    public record SBAddress : SmartbillsEntityWithId
    {
        
        public string Line1 { get; set; }
        
        public string Line2 { get; set; }
        
        public string City { get; set; }

        
        public string State { get; set; }
        
        public string StateCode { get; set; }
        
        public string Country { get; set; }
        
        public string CountryCode { get; set; }

        
        public string ZipCode { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public DateTimeOffset? UpdatedAt { get; set; }


        
        public SBCoordinate Location { get; set; }

        
        public string GooglePlaceId { get; set; }

        public string FormattedAddress { get { return ToString(); } }
        public override string ToString()
        {
            return $"{Line1} {Line2}, {City}, {State}, {Country}, {ZipCode}";
        }
    }
}
