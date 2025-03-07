using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services
{
    public record ProductUpdateRequest
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public Dictionary<string, string> LocalizedName { get; set; }
        public Dictionary<string, string> LocalizedDescription { get; set; }

        public string Vendor { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public DateTimeOffset? PublishedAt { get; set; }
        public string HtmlDescription { get; set; }
        public List<ProductImageCreateRequest> Images { get; set; } = new();
    }
}
