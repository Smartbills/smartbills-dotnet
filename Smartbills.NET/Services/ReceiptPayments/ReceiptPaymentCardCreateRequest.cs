using Smartbills.NET.Entities.ReceiptPayments;
using System.Collections.Generic;

namespace Smartbills.NET.Services.ReceiptPayments
{
    public class ReceiptPaymentCardCreateRequest
    {
        public string AuthorizationCode { get; set; }
        public string StatementDescriptor { get; set; }
        public ReceiptPaymentCardPaymentMethod PaymentMethod { get; set; }

        public SBReceiptPaymentCardEntryMethod Method { get; set; } 

        public SBReceiptPaymentCardEMV Emv { get; set; }

        public SBReceiptPaymentCardCvvResult Cvv { get; set; } = SBReceiptPaymentCardCvvResult.CVVNotChecked;
        public SBReceiptPaymentCardAvsResult Avs { get; set; } = SBReceiptPaymentCardAvsResult.PostalCodeAddressNotChecked;

        public bool RefundRequiresCardPresence = false;
        public SBReceiptPaymentCardTimeline Timeline { get; set; } 

        public List<SBReceiptPaymentCardError> Errors = new();
    }
}