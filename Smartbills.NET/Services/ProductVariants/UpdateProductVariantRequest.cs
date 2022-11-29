using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ProductVariants
{
    public class UpdateProductVariantRequest
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
        public bool Taxable { get; set; } = true;
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("image_ids")]
        public List<long> ImageIds { get; set; } = new List<long>();
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
        [JsonPropertyName("upc")]
        public string UPC { get; set; }
    }
}
