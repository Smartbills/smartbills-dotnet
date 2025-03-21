namespace Smartbills.NET.Entities.PaymentMethods
{
    public record PaymentMethodBank : SBPaymentMethod
    {

        public string BankName { get; set; }
        public string InstitutionNumber { get; set; }
        public string TransitNumber { get; set; }
        public string Last4 { get; set; }

    }
}
