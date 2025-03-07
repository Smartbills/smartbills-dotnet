using Smartbills.NET.Entities.Translations;

namespace Smartbills.NET.Services.Reviews
{
    public record ReviewTranslationCreateRequest : SBTranslation
    {
        public string Comment { get; set; }
    }
}
