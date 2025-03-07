using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.PromoCodes;

namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemDiscountRequest
    {
        public long PromoCodeId { get; set; }
        public SBMoney Amount { get; set; }
        public decimal Percentage { get; set; }
        public SBPromoCodeType Type { get; set; }
        public string Name { get; set; }
    }
}
