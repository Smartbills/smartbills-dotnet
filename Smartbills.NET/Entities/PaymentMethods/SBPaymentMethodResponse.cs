

namespace Smartbills.NET.Services.PaymentMethods
{
    public record SBPaymentMethodResponse : SBEntity
    {
        public string StripeId { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBPaymentMethodCardResponse Card { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
