
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Services.Vendors
{
    public record VendorUpdateRequest
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public SBAddress Address { get; set; }
        public string Website { get; set; }
    }
}
