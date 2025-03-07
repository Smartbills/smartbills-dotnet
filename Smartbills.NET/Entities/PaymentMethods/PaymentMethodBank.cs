using Smartbills.NET.Entities.PaymentMethods;

namespace Smartbills.NET.Services.PaymentMethods
{
    public record PaymentMethodBank : SBPaymentMethod
    {

        public string BankName { get; set; }
        public string InstitutionNumber { get; set; }
        public string TransitNumber { get; set; }
        public string Last4 { get; set; }

    }
}
