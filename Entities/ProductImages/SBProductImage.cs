using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities
{
    public class SBProductImage
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
     
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("variants_id")]
        public List<Guid> ProductVariantIds { get; set; } = new List<Guid>();
        [JsonPropertyName("product_id")]
        public Guid? ProductId { get; set; }
        [JsonPropertyName("src")]
        public string Src { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
