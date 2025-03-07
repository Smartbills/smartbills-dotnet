
using System;

namespace Smartbills.NET.Entities.Products.Modifiers
{
    public record SBProductModifier : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? InitialPrice { get; set; }
        public bool Active { get; set; }
        public int DisplayOrder { get; set; }
        public string Sku { get; set; }
        public string UPC { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}