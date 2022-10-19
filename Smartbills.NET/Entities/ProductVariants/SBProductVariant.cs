using Smartbills.NET.Entities.ProductImages;
using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ProductVariants
{
    public class SBProductVariant
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("initial_price")]
        public decimal? InitialPrice { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        // public List<SBProductVariantOption> Request { get; set; }

        [JsonPropertyName("weight_unit")]
        public string WeightUnit { get; set; }
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
        [JsonPropertyName("position")]
        public int Position { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("image")]
        public SBProductImage Image { get; set; }
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    }
}
