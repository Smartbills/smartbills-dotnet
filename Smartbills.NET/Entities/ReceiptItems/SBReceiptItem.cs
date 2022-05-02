
using Smartbills.Client.Entities.Taxes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SBReceiptItem
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }
        [JsonPropertyName("product")]
        public  SBProduct Product { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("variant")]
        public  SBProductVariant Variant { get; set; }

        [JsonPropertyName("variant_id")]
        public long? VariantId { get; set; }
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }
        [JsonPropertyName("sub_total")]
        public decimal SubTotal { get; set; }
        [JsonPropertyName("total_discount")]
        public decimal TotalDiscount { get; set; }
        [JsonPropertyName("taxes")]
        public List<SBReceiptTax> Taxes { get; set; }
        [JsonPropertyName("total_taxes")]
        public decimal TotalTaxes { get; set; }
        [JsonPropertyName("total_duties")]
        public decimal TotalDuties { get; set; }

        [JsonPropertyName("total")]
        public decimal Total { get; set; }
    }
}
