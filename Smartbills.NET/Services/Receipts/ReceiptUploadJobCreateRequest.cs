using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptUploadJobCreateRequest
    {
        public string JobId { get; set; }
        public List<long> AttachmentIds { get; set; } = new();
    }
}