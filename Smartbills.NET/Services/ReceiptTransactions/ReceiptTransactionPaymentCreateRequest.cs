using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptTransactions
{
    public record ReceiptTransactionPaymentCreateRequest
    {
        public string StatementDescriptor { get; set; }
        public ReceiptTransactionPaymentCardCreateRequest Card { get; set; }
    }
}
