using System;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Payments
{
    public record PaymentCreateRequest
    {
        public string Status { get; set; }
        public string TransfertGroup { get; set; }
        public string StatementDescriptor { get; set; }
        public SBMoney? SmartbillsFees { get; set; }
        public string Currency { get; set; }
        public SBMoney Amount { get; set; }
        public SBMoney AmountCapturable { get; set; }
        public SBMoney AmountReceived { get; set; }
        public DateTimeOffset? CancelledAt { get; set; }
        public string CancellationReason { get; set; }
        public string Description { get; set; }
    }
}
