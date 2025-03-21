namespace Smartbills.NET.Services.Payments.PaymentMethods
{
    public record PaymentMethodUpdateRequest
    {
        public long CustomerId { get; set; }
    }
}
