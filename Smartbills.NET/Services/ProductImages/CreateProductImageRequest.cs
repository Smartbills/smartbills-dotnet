using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ProductImages
{
    public class CreateProductImageRequest
    {
        [JsonPropertyName("product_variant_ids")]
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }
        [JsonPropertyName("src")]
        public string Src { get; set; }
    }
}
