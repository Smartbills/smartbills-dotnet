using Smartbills.Client.Entities.Taxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Services
{
    public class CreateReceiptItemRequest
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
        public List<CreateReceiptTaxRequest> Taxes { get; set; } = new List<CreateReceiptTaxRequest> { };

        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
    }
}