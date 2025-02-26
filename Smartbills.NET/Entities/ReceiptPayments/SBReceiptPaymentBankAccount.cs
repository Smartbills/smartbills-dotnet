namespace Smartbills.NET.Entities.ReceiptPayments
{
    public class SBReceiptPaymentBankAccount
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountType { get; set; }
        public string Fingerprint { get; set; }
        public string StatementDescriptor { get; set; }
        public string CountryCode { get; set; }
    }
}