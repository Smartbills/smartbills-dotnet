using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Address
{
    public record SBAddress : SmartbillsEntityWithId
    {
        [JsonPropertyName("line_1")]
        public string Line1 { get; set; }
        [JsonPropertyName("line_2")]
        public string Line2 { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }


        [JsonPropertyName("location")]
        public SBCoordinate Location { get; set; }

        [JsonPropertyName("google_place_id")]
        public string GooglePlaceId { get; set; }

        public string FormattedAddress { get { return ToString(); } }
        public override string ToString()
        {
            return $"{Line1} {Line2}, {City}, {State}, {Country}, {ZipCode}";
        }
    }
}
