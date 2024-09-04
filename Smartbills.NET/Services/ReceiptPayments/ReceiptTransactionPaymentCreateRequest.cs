using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptPayments
{
    public record ReceiptTransactionPaymentCreateRequest
    {
        public string StatementDescriptor { get; set; }
        public ReceiptTransactionPaymentCardCreateRequest Card { get; set; }
    }
}
