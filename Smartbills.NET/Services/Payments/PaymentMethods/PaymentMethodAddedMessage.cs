namespace Smartbills.NET.Services.PaymentMethods
{
    public class PaymentMethodAddedMessage
    {
        public long UserId { get; set; }
        public long PaymentMethodId { get; set; }
        public string Email { get; set; }
    }
}