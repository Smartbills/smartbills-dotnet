using Smartbills.NET.Services.Taxes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptItems
{
    public class ReceiptItemUpdateRequest
    {
        public long? ProductId { get; set; }
        public decimal Price { get; set; }
        public Dictionary<string, string> Description { get; set; } = new Dictionary<string, string>();
        public long? VariantId { get; set; }
        public decimal Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalDuties { get; set; }
        public decimal Total { get; set; }
        public decimal TotalTaxes { get; set; }
        public bool Taxable { get; set; }
        public List<ReceiptItemTaxCreateRequest> Taxes { get; set; } = new List<ReceiptItemTaxCreateRequest> { };
        public List<ReceiptItemDiscountRequest> Discounts { get; set; } = new List<ReceiptItemDiscountRequest> { };

    }
}
