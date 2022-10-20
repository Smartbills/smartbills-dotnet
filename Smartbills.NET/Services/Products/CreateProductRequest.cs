using Smartbills.NET.Services.ProductImages;
using Smartbills.NET.Services.ProductVariants;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Products
{
    public record CreateProductRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
        [JsonPropertyName("published_at")]
        public DateTimeOffset? PublishedAt { get; set; }
        [JsonPropertyName("html_description")]
        public string HtmlDescription { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("images")]
        public List<CreateProductImageRequest> Images { get; set; } = new List<CreateProductImageRequest>();

        [JsonPropertyName("variants")]

        public List<CreateProductVariantRequest> Variants { get; set; } = new List<CreateProductVariantRequest>();

        //[JsonPropertyName("options")]
        //public virtual List<CreateProductOptionDTO> Request { get; set; } = new List<CreateProductOptionDTO>();

        //[JsonPropertyName("source")]
        //public SBProductSourceEnum Source { get; set; }

    }
}
