using System;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Products.Images
{
    public record SBProductImage : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        public string Url { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}