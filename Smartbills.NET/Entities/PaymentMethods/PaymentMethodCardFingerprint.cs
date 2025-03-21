

namespace Smartbills.NET.Entities.PaymentMethods
{
    public record PaymentMethodCardFingerprint
    {
        public string Fingerprint { get; set; }
        public SBPaymentMethodCardFingerprintProvider Provider { get; set; }
    }
}
