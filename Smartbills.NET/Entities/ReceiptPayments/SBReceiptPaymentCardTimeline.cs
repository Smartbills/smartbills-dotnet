using System;

namespace Smartbills.NET.Entities.ReceiptPayments
{
    public class SBReceiptPaymentCardTimeline
    {
        public DateTimeOffset? AuthorizedAt { get; set; }
        public DateTimeOffset? CapturedAt { get; set; }
        public DateTimeOffset? VoidedAt { get; set; }
    }
}