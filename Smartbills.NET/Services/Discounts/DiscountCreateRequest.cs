using Smartbills.NET.Entities.Discounts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Discounts
{
    public record DiscountCreateRequest : BaseRequest
    {
        
        public string Name { get; set; }

        
        public decimal? Amount { get; set; }

        
        public decimal? Percentage { get; set; }

        
        public SBDiscountType Type { get; set; }
    }
}
