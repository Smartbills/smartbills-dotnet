using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Locations
{
    public record LocationUpdateRequest : BaseRequest
    {
        
        public string Name { get; set; }

        
        public AddressCreateRequest Address { get; set; }

        
        public AddressCreateRequest Description { get; set; }

        
        public bool Active { get; set; } = true;
        
        public string PhoneNumber { get; set; }


        
        public string FacebookUrl { get; set; }

        
        public string InstagramUsername { get; set; }

        
        public string TwitterUsername { get; set; }

        
        public string Currency { get; set; }


        
        public string MCC { get; set; }

        
        public string Locale { get; set; }

        
        public string Email { get; set; }

        
        public string Logo { get; set; }
    }
}
