
using Smartbills.NET.Services.ProductImages;
using Smartbills.NET.Services.ProductOptions;
using Smartbills.NET.Services.ProductVariants;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Products
{
    public record ProductCreateRequest : BaseRequest
    {

        public Dictionary<string, string> Name { get; set; }
        public string Slug { get; set; }
        public long? VendorId {get;set;}
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public DateTimeOffset? PublishedAt { get; set; }
        public string HtmlDescription { get; set; }
        public Dictionary<string, string> Description { get; set; }
        public List<ProductImageCreateRequest> Images { get; set; } = new List<ProductImageCreateRequest>();
        public virtual List<ProductVariantCreateRequest> Variants { get; set; } = new List<ProductVariantCreateRequest>();

        public virtual List<ProductOptionCreateRequest> Options { get; set; } = new List<ProductOptionCreateRequest>();


    }
}
