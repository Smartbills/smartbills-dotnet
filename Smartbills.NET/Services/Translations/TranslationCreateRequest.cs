using System.Collections.Generic;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Translations
{
    public record TranslationCreateRequest<T> : SBEntity, ITranslationCreateRequest<T>
    {
        public string Locale { get; set; }
        public List<T> Translations { get; set; } = new List<T>();
    }

    public interface ITranslationCreateRequest<T>
    {
        public string Locale { get; set; }
        public List<T> Translations { get; set; }
    }
}
