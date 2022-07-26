using Smartbills.NET.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Products
{
    public record UpdateProductRequest : BaseRequest
    {

        [Required]
        [MaxLength(255)]
        [JsonPropertyName("name")]
        public string Name { get; set; }
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
    }
}
