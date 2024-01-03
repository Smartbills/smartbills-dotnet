using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ProductImages
{
    public class ProductImageCreateRequest
    {
        
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        
        public string Src { get; set; }
        
        public string Name { get; set; }
    }
}


