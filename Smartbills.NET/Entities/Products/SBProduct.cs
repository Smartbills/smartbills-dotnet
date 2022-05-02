
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SBProduct
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("company_id")]
        public long? CompanyId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }
        [JsonPropertyName("categories")]
        public string Categorie { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; } = new List<string>();
        [JsonPropertyName("published_at")]
        public DateTimeOffset? PublishedAt { get; set; }
        [JsonPropertyName("html_description")]
        public string HtmlDescription { get; set; }
        [JsonPropertyName("images")]
        public virtual List<SBProductImage> Images { get; set; } = new List<SBProductImage>();
        [JsonPropertyName("variants")]
        public virtual List<SBProductVariant> Variants { get; set; } = new List<SBProductVariant>();
        //[JsonPropertyName("options")]
        //public virtual List<ProductOptionDTO> Request { get; set; } = new List<ProductOptionDTO>();
    }
}
