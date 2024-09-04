using Smartbills.NET.Entities.Money;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.ReceiptPayments
{
    public record SBReceiptPaymentProcessingFee
    {
        public SBReceiptPaymentProcessingFeeType Type { get; set; } = SBReceiptPaymentProcessingFeeType.Initial;
        public SBMoney Amount { get; set; }
    }

}
