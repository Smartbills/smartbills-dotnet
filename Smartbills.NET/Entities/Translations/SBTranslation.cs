
namespace Smartbills.NET.Entities.Translations
{
    public record SBTranslation : ITranslation
    {
        public string Locale { get; set; }
    }
    public interface ITranslation
    {
        public string Locale { get; set; }
    }
}
