namespace Smartbills.NET.Services.PaymentMethods
{
    public record PaymentMethodBank : SBPaymentMethodResponse
    {

        public string BankName { get; set; }
        public string InstitutionNumber { get; set; }
        public string TransitNumber { get; set; }
        public string Last4 { get; set; }

    }
}
