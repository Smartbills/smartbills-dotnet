using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.PaymentMethods
{
    public record SBPaymentMethodCardFingerprint
    {
        public string Fingerprint { get; set; }
        public SBPaymentMethodCardFingerprintProvider Provider { get; set; }
    }
}
