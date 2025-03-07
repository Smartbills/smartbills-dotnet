
using System;

namespace Smartbills.NET.Entities.ReceiptUpload
{
    public record SBReceiptUpload : SBEntity, ITimestamp
    {
        public string FileName { get; set; }
        public long? AttachmentId { get; set; }

        public SBReceiptUploadStatus Status { get; set; }
        public string JobId { get; set; }

        public string IdempotentId { get; set; }
        public string StatusMessage { get; set; }

        public long? UserId { get; set; }

        public long? OrganizationId { get; set; }

        public long? MerchantId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? CompletedAt { get; set; }


    }
}
