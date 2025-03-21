using Smartbills.NET.Services.BulkJobs;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptBulkJobCreateRequest : BulkJobCreateRequest
    {

        public bool SendReceipts { get; set; }
    }
}
