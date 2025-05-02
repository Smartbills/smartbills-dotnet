using Smartbills.NET.Entities.Translations;


namespace Smartbills.NET.Entities.Products
{
    public record SBProductTranslation : SBEntity, ITranslation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string HtmlDescription { get; set; }
        public string Locale { get; set; }
    }
}
