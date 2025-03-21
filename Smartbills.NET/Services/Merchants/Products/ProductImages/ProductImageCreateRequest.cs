using System.Collections.Generic;
using Smartbills.NET.Services.Images;

namespace Smartbills.NET.Services.Merchants.Products.ProductImages
{
    public record ProductImageCreateRequest : ImageUploadRequest
    {
        public List<long> ProductVariantIds { get; set; } = new List<long>();
    }
}
