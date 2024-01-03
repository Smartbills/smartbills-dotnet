using Smartbills.NET.Abstractions;
using System;

namespace Smartbills.NET.Entities.ReceiptTransactions
{
    public record SBReceiptTransaction: ISmartbillsEntity
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public string AuthorizationCode { get; set; }
        public string Currency { get; set; }
        public long DeviceId { get; set; }
        public string ErrorCode { get; set; }
        public string Gateway { get; set; }
        public string Kind { get; set; }
        public string Message { get; set; }
        public SBReceiptTransaction ParentTransaction { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? ProcessedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public ReceiptTransactionPayment Payment { get; set; }
    }
}
