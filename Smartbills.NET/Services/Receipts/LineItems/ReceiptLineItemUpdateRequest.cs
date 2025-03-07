using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemUpdateRequest
    {
        public long? ProductId { get; set; }

        public decimal Price { get; set; }

        public long? VariantId { get; set; }

        public decimal Quantity { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalDuties { get; set; }

        public decimal Total { get; set; }

        public decimal TotalTaxes { get; set; }

        public decimal SubTotal { get; set; }
        // public List<SBDuties> Duties { get; set; }

        public List<ReceiptLineItemDiscountRequest> Discounts { get; set; } = new List<ReceiptLineItemDiscountRequest> { };
        public List<ReceiptLineItemTaxUpdateRequest> Taxes { get; set; } = new List<ReceiptLineItemTaxUpdateRequest> { };

        public bool Taxable { get; set; }
    }
}
