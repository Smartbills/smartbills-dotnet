namespace Smartbills.NET.Entities.ReceiptPayments
{
    public record SBReceiptPaymentCardError
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}