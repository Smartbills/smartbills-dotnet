using System;

namespace Smartbills.NET.Entities.Attachments
{
    public record SBAttachment : SBEntity, ITimestamp
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string VersionId { get; set; }
        public string Url { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}