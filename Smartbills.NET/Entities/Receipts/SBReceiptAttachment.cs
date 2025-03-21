using System;

namespace Smartbills.NET.Entities.Receipts
{
    public class SBReceiptAttachment
    {
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTimeOffset UploadedAt { get; set; }

    }
}