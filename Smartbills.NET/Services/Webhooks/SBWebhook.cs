using System;
using System.Collections.Generic;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Webhooks
{
    public record SBWebhook : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<string> Events { get; set; } = new();
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
