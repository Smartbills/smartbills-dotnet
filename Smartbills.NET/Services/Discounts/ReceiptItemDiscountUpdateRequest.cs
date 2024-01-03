using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Discounts
{
    public record ReceiptItemDiscountUpdateRequest : BaseRequest
    {
        
        public long DiscountId { get; set; }

        
        public decimal Amount { get; set; }
    }
}
