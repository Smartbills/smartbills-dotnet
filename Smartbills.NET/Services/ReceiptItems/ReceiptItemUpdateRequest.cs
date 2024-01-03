using Smartbills.NET.Services.Taxes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptItems
{
    public class ReceiptItemUpdateRequest
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
        public List<ReceiptItemTaxUpdateRequest> Taxes { get; set; } = new List<ReceiptItemTaxUpdateRequest> { };

        
        public bool Taxable { get; set; }
    }
}
