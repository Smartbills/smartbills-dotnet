namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptBatchUpdateRequest : ReceiptUpdateRequest
    {
        public long Id { get; set; }
    }
}
