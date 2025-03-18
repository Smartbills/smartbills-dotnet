using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Services.Payments.PaymentMethods
{
    public record PaymentMethodCreateRequest
    {
        public string Type { get; set; }
        public SBBillingAddress Billing { get; set; }

        public PaymentMethodBankCreateRequest AcssDebit { get; set; } = null;
        public PaymentMethodCardCreateRequest Card { get; set; } = null;
    }
}
