using Smartbills.NET.Services.Addresses;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Merchants
{
    public class MerchantCreateRequest
    {

        public string Slug { get; set; }
        public string Logo { get; set; }
        public string CustomerEmail { get; set; }
        public string PhoneNumber { get; set; }
        public AddressCreateRequest Address { get; set; }
        public string Name { get; set; }
        public string Locale { get; set; }
    }
}
