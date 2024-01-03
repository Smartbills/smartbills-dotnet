using Smartbills.NET.Services;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Products
{
    public record ProductUpdateRequest : BaseRequest
    {

        public string Name { get; set; }
        public string Vendor { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public DateTimeOffset? PublishedAt { get; set; }
        public string HtmlDescription { get; set; }
        public string Description { get; set; }
    }
}
