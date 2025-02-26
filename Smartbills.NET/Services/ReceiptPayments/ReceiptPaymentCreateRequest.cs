using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.ReceiptPayments;
using Smartbills.NET.Services.Addresses;
using System;
using System.Collections.Generic;


namespace Smartbills.NET.Services.ReceiptPayments
{
    public record ReceiptPaymentCreateRequest
    {
        public ReceiptPaymentCardCreateRequest Card { get; set; }
        public ReceiptPaymentCashCreateRequest Cash { get; set; }
        public SBReceiptPaymentBankAccount BankAccount { get; set; }
        public SBReceiptPaymentExternal External { get; set; }
        public BillingAddressCreateRequest BillingAddress { get; set; }
        public BillingAddressCreateRequest ShippingAddress { get; set; }
        public SBReceiptPaymentType Type { get; set; }
        public SBMoney Amount { get; set; }
        public SBMoney Tip { get; set; }
        public SBMoney ApplicationFee { get; set; }
        public List<SBReceiptPaymentProcessingFee> ProcessingFee { get; set; } = new List<SBReceiptPaymentProcessingFee>();

        public SBMoney Total { get; set; }
        public SBMoney Approuved { get; set; }
        public SBMoney Refunded { get; set; }

        public SBReceiptPaymentStatus Status { get; set; } = SBReceiptPaymentStatus.Approved;
        public string ReceiptNumber { get; set; }
        public string ReceiptUrl { get; set; }
        public string Note { get; set; }
        public SBReceiptPaymentRiskEvaluation RiskEvaluation { get; set; }
        public List<ReceiptPaymentRefundCreateRequest> Refunds { get; set; } = new List<ReceiptPaymentRefundCreateRequest>();

    }
}
