namespace Smartbills.NET.Services.Payments.PaymentMethods
{
    public record SBPaymentMethodCardResponse
    {
        public SBPaymentMethodCardResponse() : base()
        {
        }
        public string Last4 { get; set; }
        public string DynamicLast4 { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Fingerprint { get; set; }
        public string TokenizationMethod { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string Brand { get; set; }
        public string Bin { get; set; }
    }
}
