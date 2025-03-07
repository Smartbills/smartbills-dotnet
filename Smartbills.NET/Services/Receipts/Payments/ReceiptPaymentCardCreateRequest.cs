using System.Collections.Generic;
using Smartbills.NET.Entities.Receipts.Payments;

namespace Smartbills.NET.Services.Receipts.Payments
{
    public record ReceiptPaymentCardCreateRequest
    {
        public string AuthorizationCode { get; set; }
        public string StatementDescriptor { get; set; }
        public SBReceiptPaymentMethodCard PaymentMethod { get; set; }

        public SBReceiptPaymentCardEntryMethod Method { get; set; }

        public SBReceiptPaymentCardEMV Emv { get; set; }

        public SBReceiptPaymentCardCvvResult Cvv { get; set; } = SBReceiptPaymentCardCvvResult.CVVNotChecked;
        public SBReceiptPaymentCardAvsResult Avs { get; set; } = SBReceiptPaymentCardAvsResult.PostalCodeAddressNotChecked;

        public bool RefundRequiresCardPresence = false;
        public SBReceiptPaymentCardTimeline Timeline { get; set; } = new();

        public List<SBReceiptPaymentCardError> Errors = new();

    }
}
