using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Services
{
    public class UpdateReceiptItemRequest
    {
        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("variant_id")]
        public long? VariantId { get; set; }

        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        [JsonPropertyName("total_discount")]
        public decimal TotalDiscount { get; set; }

        [JsonPropertyName("total_duties")]
        public decimal TotalDuties { get; set; }

        [JsonPropertyName("total")]
        public decimal Total { get; set; }

        [JsonPropertyName("total_taxes")]
        public decimal TotalTaxes { get; set; }

        [JsonPropertyName("sub_total")]
        public decimal SubTotal { get; set; }
        // public List<SBDuties> Duties { get; set; }
        public List<UpdateReceiptTaxRequest> Taxes { get; set; } = new List<UpdateReceiptTaxRequest> { };

        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
    }
}
