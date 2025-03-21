namespace Smartbills.NET.Entities.Receipts.Payments
{
    public class SBReceiptPaymentCardEMV
    {
        public string ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationCryptogram { get; set; }
        public string CardholderVerificationMethod { get; set; }
        public string CardholderVerificationResult { get; set; }
    }
}