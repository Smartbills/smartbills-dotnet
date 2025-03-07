
using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services
{
    public record ProductCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public long? VendorId { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public DateTimeOffset? PublishedAt { get; set; }
        public string HtmlDescription { get; set; }
        public string Locale { get; set; }
        public List<ProductImageCreateRequest> Images { get; set; } = new List<ProductImageCreateRequest>();
        public virtual List<ProductVariantCreateRequest> Variants { get; set; } = new List<ProductVariantCreateRequest>();
        public virtual List<ProductOptionCreateRequest> Options { get; set; } = new List<ProductOptionCreateRequest>();


    }
}
