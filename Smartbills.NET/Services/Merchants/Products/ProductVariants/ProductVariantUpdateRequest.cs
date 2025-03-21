using System.Collections.Generic;

namespace Smartbills.NET.Services.Merchants.Products.ProductVariants
{
    public record ProductVariantUpdateRequest
    {
        public decimal? InitialPrice { get; set; }
        public decimal Price { get; set; }
        // public List<SBProductVariantOption> Options { get; set; }
        public string WeightUnit { get; set; }
        public decimal Weight { get; set; }
        public bool Taxable { get; set; }
        public string Name { get; set; }
        public List<long> ImageIds { get; set; } = new List<long>();
        public string Sku { get; set; }
        public string UPC { get; set; }
    }
}
