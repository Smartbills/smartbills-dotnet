using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public class CreateProductImageRequest
    {
        public List<Guid> ProductVariantIds { get; set; } = new List<Guid>();
        [JsonPropertyName("product_id")]
        public Guid? ProductId { get; set; }
        [JsonPropertyName("src")]
        public string Src { get; set; }
    }
}
