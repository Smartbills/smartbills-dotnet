

using System;
using System.Collections.Generic;
using Smartbills.NET.Entities.Images;
using Smartbills.NET.Entities.ProductOptions;

namespace Smartbills.NET.Entities.Products
{
    public record SBProductVariant : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public decimal? InitialPrice { get; set; }
        public decimal Price { get; set; }
        public List<SBProductOption> Options { get; set; } = new();
        public List<SBImage> Images { get; set; } = new();
        public string Sku { get; set; }
        public string UPC { get; set; }
        public string WeightUnit { get; set; }
        public decimal Weight { get; set; }
        public bool Taxable { get; set; } = true;
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
