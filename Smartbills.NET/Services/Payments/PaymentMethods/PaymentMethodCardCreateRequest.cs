﻿using Smartbills.NET.Entities.PaymentMethods;

namespace Smartbills.NET.Services.Payments.PaymentMethods
{
    public record PaymentMethodCardCreateRequest
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
        public PaymentMethodCardFingerprint Fingerprint { get; set; }
    }
}
