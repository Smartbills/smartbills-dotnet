using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Receipts.Payments
{
    public record ReceiptTransactionPaymentCreateRequest
    {
        public string StatementDescriptor { get; set; }
        public ReceiptTransactionPaymentCardCreateRequest Card { get; set; }
    }
}
