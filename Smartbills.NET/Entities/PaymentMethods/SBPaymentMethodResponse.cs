

using Smartbills.NET.Entities.Address;
using Smartbills.NET.Services.Payments.PaymentMethods;

namespace Smartbills.NET.Entities.PaymentMethods
{
    public record SBPaymentMethod : SBEntity
    {
        public string StripeId { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBPaymentMethodCardResponse Card { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
