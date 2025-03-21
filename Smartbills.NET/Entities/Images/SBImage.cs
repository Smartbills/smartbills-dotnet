using System;

namespace Smartbills.NET.Entities.Images
{

    public record SBImage : SBEntity
    {
        public string Url { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public string AltText { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}