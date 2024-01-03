using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Products;
using Smartbills.NET.Entities.ProductVariants;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptItem : SmartbillsEntityWithId
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long? VariantId { get; set; }
        public decimal Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalDiscount { get; set; }
        public List<SBReceiptItemTax> Taxes { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal TotalDuties { get; set; }
        public decimal Total { get; set; }
        public  SBProduct Product { get; set; }
        public  SBProductVariant Variant { get; set; }
    }
}
