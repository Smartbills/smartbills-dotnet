
using System;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Entities.Locations
{
    public record SBLocation : SBEntity, ITimestamp
    {
        public string Logo { get; set; }
        public bool IsActive { get; set; } = true;
        public string Name { get; set; }
        public string Description { get; set; }
        public SBAddress Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Locale { get; set; }
        public string Currency { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUsername { get; set; }
        public string InstagramUsername { get; set; }
        public string MerchantCategoryCode { get; set; }
        public string Timezone { get; set; }
        //public List<Image> Images { get; set; } = new List<Image>();
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
