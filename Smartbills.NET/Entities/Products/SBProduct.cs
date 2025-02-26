using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ProductImages;
using Smartbills.NET.Entities.ProductOption;
using Smartbills.NET.Entities.ProductVariants;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Products
{
    public record SBProduct: ISmartbillsEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Vendor { get; set; }
        public string Category { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public DateTimeOffset? PublishedAt { get; set; }
        public string HtmlDescription { get; set; }
        public virtual List<SBProductImage> Images { get; set; } = new List<SBProductImage>();
        public virtual List<SBProductVariant> Variants { get; set; } = new List<SBProductVariant>();
        public virtual List<SBProductOption> Options { get; set; } = new List<SBProductOption>();
    }
}
