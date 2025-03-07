using Smartbills.NET.Services.Translations;

namespace Smartbills.NET.Entities.Fees
{
    public record SBFeeTranslation : SBTranslatedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
