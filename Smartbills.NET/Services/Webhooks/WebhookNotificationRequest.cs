using System;

namespace Smartbills.NET.Services.Webhooks
{
    public record WebhookNotificationRequest<T>
    {
        public string Event { get; set; }
        public T Data { get; set; }
        public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.Now;

    }
}
