
using Smartbills.Core.Models.ReceiptPayments;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPaymentProcessingFee
    {
        public SBReceiptPaymentProcessingFeeType Type { get; set; } = SBReceiptPaymentProcessingFeeType.Initial;
        public SBMoney Amount { get; set; }
    }

}