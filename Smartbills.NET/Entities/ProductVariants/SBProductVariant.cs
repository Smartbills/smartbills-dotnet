using Smartbills.NET.Entities.ProductImages;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ProductVariants
{
    public record SBProductVariant : SmartbillsEntityWithId
    {
        [JsonPropertyName("initial_price")]
        public decimal? InitialPrice { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        // public List<SBProductVariantOption> Options { get; set; }
        [JsonPropertyName("weight_unit")]
        public string WeightUnit { get; set; }
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }
        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("images")]
        public List<SBProductImage> Images { get; set; } = new List<SBProductImage>();
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
        [JsonPropertyName("upc")]
        public string UPC { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
