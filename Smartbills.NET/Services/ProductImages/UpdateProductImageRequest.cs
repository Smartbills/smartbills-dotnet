using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ProductImages
{
    public class UpdateProductImageRequest
    {
        [JsonPropertyName("product_variant_ids")]
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        [JsonPropertyName("src")]
        public string Src { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
