using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Addresses
{
    public class BillingAddressCreateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }

        public AddressCreateRequest Address { get; set; } = new AddressCreateRequest();
        
        public string Company { get; set; }
        public string Phone { get; set; }
    }
}
