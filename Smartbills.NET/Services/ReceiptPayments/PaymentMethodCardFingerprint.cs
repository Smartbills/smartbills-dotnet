using Smartbills.NET.Entities.PaymentMethods;

namespace Smartbills.NET.Services.ReceiptPayments
{
    public record PaymentMethodCardFingerprint
    {
        public SBPaymentMethodCardFingerprintProvider Provider { get; set; }
        public string Fingerprint{ get; set; }
    }
}