using System.Collections.Generic;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Translations
{
    public record TranslationUpdateRequest<T> : SBEntity
    {
        public string Locale { get; set; }
        public List<T> Translations { get; set; } = new List<T>();
    }

}
