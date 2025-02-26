using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ProductImages
{
    public record SBProductImage: ISmartbillsEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<long> ProductVariantIds { get; set; } = new List<long>();
        public long ProductId { get; set; }
        public string Url { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
