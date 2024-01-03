using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Addresses
{
    public class BillingAddressUpdateRequest
    {

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }


        
        public string Name { get; set; }

        
        public AddressUpdateRequest Address { get; set; } = new AddressUpdateRequest();

        
        public string Company { get; set; }

        
        public string Phone { get; set; }
    }
}
