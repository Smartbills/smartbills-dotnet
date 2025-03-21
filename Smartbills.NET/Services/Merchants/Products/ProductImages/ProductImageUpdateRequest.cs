using System.Collections.Generic;

namespace Smartbills.NET.Services.Merchants.Products.ProductImages
{
    public record ProductImageUpdateRequest
    {
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        public string Src { get; set; }
        public string Name { get; set; }
    }
}
