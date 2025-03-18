using System.Collections.Generic;

namespace Smartbills.NET.Services.Merchants.Products
{
    public record ProductModifierGroupCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public int MinimumSelection { get; set; }
        public int MaximumSelection { get; set; }
        public bool Active { get; set; } = true;
        public int DisplayOrder { get; set; }
        public string Locale { get; set; }
        public List<ProductModifierCreateRequest> Modifiers { get; set; } = new();
    }
}