using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.PromoCodes;

namespace Smartbills.NET.Services.PromoCodes
{
    public record PromoCodeCreateRequest
    {
        public string Name { get; set; }

        public SBMoney Amount { get; set; }
        public decimal? Percentage { get; set; }
        public SBPromoCodeType? Type { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
