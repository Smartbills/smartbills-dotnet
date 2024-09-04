using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services.ReceiptPayments
{
    public record ReceipTransactionCreateRequest
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string DeviceId { get; set; }
        public string ErrorCode { get; set; }
        public string Gateway { get; set; }
        public string SourceName { get; set; }
        public string Kind { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string AuthorizationCode { get; set; }
        public string Description { get; set; }

        public DateTimeOffset ProcessedAt { get; set; }
        public ReceiptTransactionPaymentCreateRequest Payment { get; set; }
        public List<ReceipTransactionCreateRequest> Refunds { get; set; } = new();
    }
}
