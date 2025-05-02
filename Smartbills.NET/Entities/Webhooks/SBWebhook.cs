using System;
using System.Collections.Generic;
namespace Smartbills.NET.Entities.Webhooks
{
    public record Webhook : SBEntity
    {
        public string Event { get; set; }
        public object Data { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }

    public record Webhook<T> : SBEntity
    {
        public string Event { get; set; }
        public T Data { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
