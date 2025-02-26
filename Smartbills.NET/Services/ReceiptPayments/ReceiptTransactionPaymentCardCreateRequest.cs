namespace Smartbills.NET.Services.ReceiptPayments
{
    public record ReceiptTransactionPaymentCardCreateRequest
    {
        public string CardholderName { get; set; }
        public string CardholderFirstName { get; set; }
        public string CardholderLastName { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string Fingerprint { get; set; }
        public string Last4 { get; set; }
        public string DynamicLast4 { get; set; }
        public string Bin { get; set; }
    }
}
