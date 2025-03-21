
namespace Smartbills.NET.Entities.Receipts.LineItems
{
    public record SBReceiptLineItemProduct : SBEntity
    {
        public string Name { get; set; }
        //public string Slug { get; set; }
        //public string Vendor { get; set; }
        public string Category { get; set; }
        //public virtual List<ProductImageResponse> Images { get; set; } = new List<ProductImageResponse>();
    }
}
