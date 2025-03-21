using System.Collections.Generic;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPaymentCard
    {
        public string AuthorizationCode { get; set; }
        public string StatementDescriptor { get; set; }
        public SBReceiptPaymentCardEntryMethod Method { get; set; }

        public SBReceiptPaymentCardEMV Emv { get; set; }
        public SBReceiptPaymentMethodCard PaymentMethod { get; set; }

        public SBReceiptPaymentCardCvvResult Cvv { get; set; } = SBReceiptPaymentCardCvvResult.CVVNotChecked;
        public SBReceiptPaymentCardAvsResult Avs { get; set; } = SBReceiptPaymentCardAvsResult.PostalCodeAddressNotChecked;

        public bool RefundRequiresCardPresence = false;
        public SBReceiptPaymentCardTimeline Timeline { get; set; } = new();

        public List<SBReceiptPaymentCardError> Errors = new();
    }
}
