using Smartbills.NET.Entities.Address;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Addresses
{
    public class AddressCreateRequest
    {
        
        public string Line1 { get; set; }
        
        public string Line2 { get; set; }
        
        public string City { get; set; }

        
        public string State { get; set; }
        
        public string StateCode { get; set; }
        
        public string Country { get; set; }
        
        public string CountryCode { get; set; }

        
        public string ZipCode { get; set; }

        
        public SBCoordinate Coordinates { get; set; }

    }
}
