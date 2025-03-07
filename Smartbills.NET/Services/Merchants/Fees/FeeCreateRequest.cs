using System.Collections.Generic;
using Smartbills.NET.Entities.Fees;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Fees
{
    public record FeeCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SBMoney Amount { get; set; }
        public SBFeeType? Type { get; set; }
        public SBFeeCategory? Category { get; set; }
        public decimal? Percentage { get; set; }
        public string Locale { get; set; }
        public List<SBFeeTranslation> Translations { get; set; } = new List<SBFeeTranslation>();
    }
}
