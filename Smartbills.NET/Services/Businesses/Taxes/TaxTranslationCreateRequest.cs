namespace Smartbills.NET.Services.Merchants.Taxes
{
    public record TaxTranslationCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Locale { get; set; }
    }
}
