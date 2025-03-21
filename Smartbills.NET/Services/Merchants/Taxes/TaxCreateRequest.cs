using Smartbills.NET.Entities.Taxes;
using Smartbills.NET.Services.Merchants.Taxes;
using Smartbills.NET.Services.Translations;


namespace Smartbills.NET.Services.Taxes
{
    public record TaxCreateRequest : TranslationCreateRequest<TaxTranslationCreateRequest>
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public SBTaxType Type { get; set; }
        public decimal Percentage { get; set; }
        public string State { get; set; }
        public bool? Inclusive { get; set; } = true;
        public string Jurisdiction { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
