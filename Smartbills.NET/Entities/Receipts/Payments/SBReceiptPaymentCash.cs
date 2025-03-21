using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPaymentCash
    {
        public SBMoney CashGiven { get; set; }
        public SBMoney ChangeReturned { get; set; }
    }
}
