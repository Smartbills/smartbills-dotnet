using System;

namespace Smartbills.NET.Entities.Files
{
    public record SBFile : SBEntity
    {
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string Key { get; set; }
        public string ETag { get; set; }
        public string VersionId { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public long FileSize { get; set; }
        public string Url { get; set; }
        public bool IsLatest { get; set; }
    }
}