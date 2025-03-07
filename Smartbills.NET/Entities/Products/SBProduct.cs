using Smartbills.NET.Entities.Images;
using Smartbills.NET.Entities.ProductOptions;

using System;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Products
{
    public record SBProduct : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Category { get; set; }
        public string HtmlDescription { get; set; }
        public List<SBImage> Images { get; set; } = new List<SBImage>();
        public List<SBProductVariant> Variants { get; set; } = new List<SBProductVariant>();
        public List<SBProductOption> Options { get; set; } = new List<SBProductOption>();
        public List<string> Tags { get; set; } = new List<string>();
        public string Url { get; set; }
        public SBProductVendor Vendor { get; set; }
        public DateTimeOffset? PublishedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
