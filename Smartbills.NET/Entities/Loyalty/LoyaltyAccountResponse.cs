using System;

namespace Smartbills.NET.Entities.Loyalty
{
    public record LoyaltyAccountResponse : SmartbillsEntityWithId
    {
        public long UserId { get; set; }
        public string ProgramId { get; set; }
        public long Balance { get; set; }
        public long LifetimePoints { get; set; }
        public DateTimeOffset EnrolledAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public long CustomerId { get; set; }
        public long MerchantId { get; set; }
        public long LoyaltyProgramId { get; set; }
    }
}