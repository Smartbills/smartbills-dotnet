using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptUploadResponse : SBEntity
    {
        public string JobId { get; set; }
    }
}