using Smartbills.NET.Entities.PaymentMethods;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBPaymentMethodCardFingerprint
    {
        public SBPaymentMethodCardFingerprintProvider Provider { get; set; }
        public string Fingerprint { get; set; }
    }
}