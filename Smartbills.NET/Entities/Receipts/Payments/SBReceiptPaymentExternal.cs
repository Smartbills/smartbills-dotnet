
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPaymentExternal
    {
        public string Source { get; set; }
        public string SourceId { get; set; }
        public SBMoney Fee { get; set; }
        public SBReceiptPaymentExternalType Type { get; set; }
    }
}