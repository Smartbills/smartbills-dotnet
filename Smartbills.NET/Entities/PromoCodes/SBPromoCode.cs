using System;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.PromoCodes
{
    public record SBPromoCode : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public SBPromoCodeType Type { get; set; } = SBPromoCodeType.Amount;
        public bool IsDeleted { get; set; }

        public SBMoney Amount { get; set; }

        public decimal? Percentage { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
