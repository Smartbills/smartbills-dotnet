
using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.PromoCodes;

namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemDiscountCreateRequest
    {
        public ReceiptLineItemDiscountCreateRequest()
        {
            Name = string.Empty;
            Amount = new SBMoney();
        }


        public long PromoCodeId { get; set; }
        public SBMoney Amount { get; set; } = new SBMoney();
        public decimal Percentage { get; set; }
        public SBPromoCodeType Type { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}