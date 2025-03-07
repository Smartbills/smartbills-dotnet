using System;

namespace Smartbills.NET.Entities.Cards
{
    public record SBPaymentMethodCard : SBEntity
    {
        public string Name { get; set; }
        public string Bin { get; set; }
        public string Last4 { get; set; }
        public string Brand { get; set; }
        public string Fingerprint { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string Type { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string TokenizationMethod { get; set; }
        public string DynamicLast4 { get; set; }
    }
}
