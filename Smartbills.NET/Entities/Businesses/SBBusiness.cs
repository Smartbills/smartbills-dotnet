using System;
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Entities.Businesses
{
    public record SBBusiness : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public SBAddress Address { get; set; }
        public string Currency { get; set; }
        public string Slug { get; set; }
        public string Timezone { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Logo { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}