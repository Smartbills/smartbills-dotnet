using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.Products.Variants;
using Smartbills.NET.Services.Receipts;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Receipts.LineItems
{
    public record SBReceiptLineItem : SBEntity
    {

        public decimal Quantity { get; set; }
        public SBMoney Price { get; set; }
        public SBReceiptLineItemProduct Product { get; set; }
        public SBProductVariant Variant { get; set; }
        public SBMoney TotalDuties { get; set; }
        public SBMoney TotalDiscounts { get; set; }
        public SBMoney SubTotal { get; set; }
        public SBMoney TotalTaxes { get; set; }
        public SBMoney Total { get; set; }
        public List<SBReceiptLineItemDiscount> Discounts { get; set; } = new();
        public List<SBReceiptLineItemTax> Taxes { get; set; } = new();
        public List<SBReceiptLineItemModifier> Modifiers { get; set; } = new();
    }
}
