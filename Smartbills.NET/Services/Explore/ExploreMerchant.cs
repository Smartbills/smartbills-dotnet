using System.Collections.Generic;
using Smartbills.Entities.Locations;
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Services.Explore
{
    public record ExploreMerchant
    {
        public string Name { get; set; }
        public SBAddress Address { get; set; }
        public string Slug { get; set; }
        public string CustomerEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }

        public List<SBLocation> Locations { get; set; } = new List<SBLocation>();
    }
}
