using System;
using System.Collections.Generic;
namespace Smartbills.NET.Entities.Webhooks
{
    public record SBWebhookSubscription : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<string> Events { get; set; } = new();
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
