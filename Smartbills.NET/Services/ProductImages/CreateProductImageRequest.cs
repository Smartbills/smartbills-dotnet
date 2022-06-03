using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public class CreateProductImageRequest
    {
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }
        [JsonPropertyName("src")]
        public string Src { get; set; }
    }
}
