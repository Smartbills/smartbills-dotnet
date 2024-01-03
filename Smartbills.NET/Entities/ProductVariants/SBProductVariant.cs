using Smartbills.NET.Entities.ProductImages;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ProductVariants
{
    public record SBProductVariant : SmartbillsEntityWithId
    {
        
        public decimal? InitialPrice { get; set; }
        
        public decimal Price { get; set; }
        // public List<SBProductVariantOption> Options { get; set; }
        
        public string WeightUnit { get; set; }
        
        public decimal Weight { get; set; }
        
        public bool Taxable { get; set; }
        
        public string Name { get; set; }
        
        public List<SBProductImage> Images { get; set; } = new List<SBProductImage>();
        
        public string Sku { get; set; }
        
        public string UPC { get; set; }
        
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
    }
}
