using System;

namespace Smartbills.NET.Entities.Loyalty
{
    public record SBLoyaltyProgram : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public long PointIssued { get; set; }
        public long MerchantId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}