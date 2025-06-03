using Smartbills.NET.Entities.Translations;

namespace Smartbills.NET.Services.Merchants.Products
{
    public record ProductTranslationRequest : ITranslation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string HtmlDescription { get; set; }
        public string Locale { get; set; }
    }
}
