using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text.Json.Serialization;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public class CreateProductRequest
    {
        [Required]
        [MaxLength(255)]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [MaxLength(255)]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [MaxLength(255)]
        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }
        [JsonPropertyName("category")]
        [MaxLength(255)]
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

        public virtual List<CreateProductVariantDTO> Variants { get; set; } = new List<CreateProductVariantDTO>();

        //[JsonPropertyName("options")]
        //public virtual List<CreateProductOptionDTO> Request { get; set; } = new List<CreateProductOptionDTO>();

        //[JsonPropertyName("source")]
        //public SBProductSourceEnum Source { get; set; }

    }
}
