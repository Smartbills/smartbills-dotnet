using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public class SBProductImage
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("variants_id")]
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        [JsonPropertyName("product_id")]
        public long? ProductId { get; set; }
        [JsonPropertyName("src")]
        public string Src { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
