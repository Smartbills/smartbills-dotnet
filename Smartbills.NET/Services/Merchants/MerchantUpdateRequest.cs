using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Merchants
{
    public record MerchantUpdateRequest : BaseRequest
    {

        
        public string Logo { get; set; }
        
        public string CustomerEmail { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public AddressCreateRequest Address { get; set; }
        
        public string Name { get; set; }
        
        public string Currency { get; set; }
        
        public string Locale { get; set; }
    }
}
