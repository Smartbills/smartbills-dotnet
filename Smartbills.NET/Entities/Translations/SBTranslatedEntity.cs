
using System;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Entities.Translations
{
    public record SBTranslatedEntity : SBEntity, ITimestamp
    {
        public string Locale { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
