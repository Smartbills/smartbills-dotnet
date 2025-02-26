using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.PromoCodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.ReceiptItems
{
    public record ReceiptItemDiscountRequest
    {
        public long PromoCodeId { get; set; }
        public SBMoney Amount { get; set; }
        public decimal Percentage { get; set; }
        public SBPromoCodeType Type { get; set; }
        public string Name { get; set; }
    }
}
