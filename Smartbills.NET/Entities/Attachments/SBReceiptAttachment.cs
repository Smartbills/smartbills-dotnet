namespace Smartbills.NET.Entities.Attachments
{
    public record SBReceiptAttachment : SBEntity
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string Url { get; set; }
        public string VersionId { get; set; }
    }
}