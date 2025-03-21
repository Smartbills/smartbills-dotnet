using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Receipts.Payments
{
    public class ReceiptPaymentCashUpdateRequest
    {
        public SBMoney Supplied { get; set; }
        public SBMoney Change { get; set; }
    }
}
