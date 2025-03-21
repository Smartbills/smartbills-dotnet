using System;

namespace Smartbills.NET.Entities.Subscriptions
{
    public record SBSubscription : SBEntity
    {
        public string SubscriptionName { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}