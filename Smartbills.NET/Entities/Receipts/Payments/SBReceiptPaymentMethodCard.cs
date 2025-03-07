using Smartbills.NET.Entities.PaymentMethods;
using Smartbills.NET.Services.PaymentMethods;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPaymentMethodCard
    {
        public string CardholderName { get; set; }
        public string CardholderFirstName { get; set; }
        public string CardholderLastName { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public string CoBrand { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string Last4 { get; set; }
        public string DynamicLast4 { get; set; }
        public string Bin { get; set; }
        public SBPaymentMethodCardFingerprint Fingerprint { get; set; }

    }
}
