namespace Smartbills.NET.Services.Payments.PaymentMethods
{
    public record PaymentMethodBankCreateRequest
    {
        public string TransitNumber { get; set; }
        public string InstitutionNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Currency { get; set; }
    }
}
