namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPaymentCardError
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}