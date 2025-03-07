using System;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Services
{
    public record SBNotification : SBEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public int BadgeCount { get; set; }
        public SBNotificationType Type { get; set; }
        public string Data { get; set; }
        public bool Read { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
