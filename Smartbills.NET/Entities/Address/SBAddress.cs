
namespace Smartbills.NET.Entities.Address
{
    public record SBAddress : SBEntity
    {

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public SBCoordinate Location { get; set; }
        public string GooglePlaceId { get; set; }
        public string FormattedAddress { get; set; }
    }
}
