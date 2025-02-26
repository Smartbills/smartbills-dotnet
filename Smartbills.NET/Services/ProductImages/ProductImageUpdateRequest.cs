using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ProductImages
{
    public record ProductImageUpdateRequest
    {
        
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        
        public string Src { get; set; }
        
        public string Name { get; set; }
    }
}
