using Smartbills.NET.Services.ProductImages;
using Smartbills.NET.Services.ProductVariants;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Products
{
    public record UpdateProductRequest : BaseRequest
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
        public List<UpdateProductImageRequest> Images { get; set; } = new List<UpdateProductImageRequest>();

        [JsonPropertyName("variants")]

        public List<UpdateProductVariantRequest> Variants { get; set; } = new List<UpdateProductVariantRequest>();

        //[JsonPropertyName("options")]
        //public virtual List<UpdateProductOptionDTO> Request { get; set; } = new List<UpdateProductOptionDTO>();

        //[JsonPropertyName("source")]
        //public SBProductSourceEnum Source { get; set; }
    }
}
