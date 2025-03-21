namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemSplitCreateRequest
    {
        public long ItemId { get; set; }
        public long UserId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Percentage { get; set; }
    }
}
