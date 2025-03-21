using System;
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Entities.Vendors
{
    public record SBCatalogVendor : SBEntity, ITimestamp
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public SBAddress Address { get; set; }
        public string Website { get; set; }
        //public SBVendorImage Logo { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}