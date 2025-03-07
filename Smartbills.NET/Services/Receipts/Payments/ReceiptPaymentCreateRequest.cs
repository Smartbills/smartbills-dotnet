
using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts.Payments
{
    public record ReceiptPaymentCreateRequest
    {
        public long ReceiptId { get; set; }
        public string StatementDescriptor { get; set; }
        public ReceiptPaymentCardCreateRequest Card { get; set; }
        public ReceiptPaymentCashCreateRequest Cash { get; set; }
        public SBReceiptPaymentBankAccount BankAccount { get; set; }
        public SBReceiptPaymentExternal External { get; set; }

        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public SBReceiptPaymentType Type { get; set; }

        public SBMoney Amount { get; set; }
        public SBMoney Tip { get; set; }
        public SBMoney ApplicationFee { get; set; }
        public SBMoney Total { get; set; }
        public SBMoney Approuved { get; set; }
        public SBMoney Refunded { get; set; }
        public SBReceiptPaymentStatus Status { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptUrl { get; set; }
        public string Note { get; set; }
        public ReceiptPaymentRiskEvaluation RiskEvaluation { get; set; }
        public List<ReceiptPaymentRefundCreateRequest> Refunds { get; set; } = new List<ReceiptPaymentRefundCreateRequest>();

    }
}
