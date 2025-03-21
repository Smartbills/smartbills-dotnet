namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptUpsertRequest : ReceiptCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
