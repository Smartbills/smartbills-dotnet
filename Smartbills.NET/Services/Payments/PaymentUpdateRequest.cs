using System;

namespace Smartbills.NET.Services.Payments
{
    public record PaymentUpdateRequest
    {
        public string Status { get; set; }
        public string TransfertGroup { get; set; }
        public string StatementDescriptor { get; set; }
        public decimal? SmartbillsFees { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountCapturable { get; set; }
        public decimal AmountReceived { get; set; }
        public DateTimeOffset? CancelledAt { get; set; }
        public string CancellationReason { get; set; }
        public string Description { get; set; }
    }
}
