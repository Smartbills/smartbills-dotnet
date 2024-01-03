using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptTransactions
{
    public record ReceiptTransactionPayment
    {
        public string StatementDescriptor { get; set; }
        public ReceiptTransactionPaymentCard Card { get; set; }
    }
}
