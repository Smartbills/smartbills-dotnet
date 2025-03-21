namespace Smartbills.NET.Entities.Receipts.LineItems
{
    public record SBReceiptLineItemProductVariant : SBEntity
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string UPC { get; set; }
    }
}