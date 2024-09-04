using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.ReceiptPayments
{
    public class SBReceiptPaymentExternal
    {
        public string Source { get; set; }
        public string SourceId { get; set; }
        public SBMoney Fee { get; set; }
        public SBReceiptPaymentExternalType Type { get; set; }

    }
}