using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Discounts
{
    public record SBDiscount : SmartbillsEntityWithId
    {
        
        public string Name { get; set; }

        
        public decimal? Amount { get; set; }

        
        public decimal? Percentage { get; set; }

        
        public SBDiscountType Type { get; set; } = SBDiscountType.AMOUNT;
    }
}
