namespace Smartbills.NET.Services.PaymentMethods
{
    public record PaymentMethodUpdateRequest
    {
        public long CustomerId { get; set; }
    }
}
