namespace Smartbills.NET.Entities.ReceiptLineItems
{
    public record SBReceiptLineItemProductVariant : SBEntity
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string UPC { get; set; }
    }
}