using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.Fees
{
    public record SBFee : SBEntity
    {
        public string Name { get; set; }

        public SBMoney Amount { get; set; }

        public decimal? Percentage { get; set; }

        public SBFeeType Type { get; set; }
        public SBFeeCategory Category { get; set; }
    }
}
