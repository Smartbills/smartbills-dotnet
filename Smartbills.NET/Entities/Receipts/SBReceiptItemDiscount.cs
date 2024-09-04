using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.Products;
using Smartbills.NET.Entities.PromoCodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptItemDiscount : SmartbillsEntityWithId
    {
        public long PromoCodeId { get; set; }
        public SBMoney Amount { get; set; }
        public decimal Percentage { get; set; }
        public SBPromoCodeType Type { get; set; }
        public string Name { get; set; }
    }
}
