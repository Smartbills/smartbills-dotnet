using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Money;
using Smartbills.NET.Entities.ReceiptPayments;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record SBReceiptPayment : SBEntity
    {
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public SBReceiptPaymentType Type { get; set; }
        public string StatementDescriptor { get; set; }
        public SBReceiptPaymentCard Card { get; set; }
        public SBReceiptPaymentCash Cash { get; set; }
        //public ReceiptPaymentBalance BalanceTransaction { get; set; }
        //public ReceiptPaymentBankAccount BankAccount { get; set; }
        //public ReceiptPaymentExternal External { get; set; }
        public string Note { get; set; }
        public SBMoney Amount { get; set; }
        public SBMoney Tip { get; set; }
        public SBMoney ApplicationFee { get; set; }
        public SBMoney Total { get; set; }
        public SBMoney Approuved { get; set; }
        public SBMoney Refunded { get; set; }
        public List<SBReceiptPaymentProcessingFee> PaymentProcessingFee { get; set; } = new();
        public SBReceiptPaymentStatus Status { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptUrl { get; set; }
        public ReceiptPaymentRiskEvaluation RiskEvaluation { get; set; }
        public List<ReceiptPaymentRefund> Refunds { get; set; } = new List<ReceiptPaymentRefund>();

    }
}
