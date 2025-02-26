
using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Money;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.ReceiptPayments
{
    public record SBReceiptPayment: SmartbillsEntity
    {
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public SBReceiptPaymentType Type { get; set; }
        public string StatementDescriptor { get; set; }
        public SBReceiptPaymentCard Card { get; set; }
        public SBReceiptPaymentCash Cash { get; set; }
        public SBReceiptPaymentBalance BalanceTransaction { get; set; }

        public SBReceiptPaymentBankAccount BankAccount { get; set; }
        public SBReceiptPaymentExternal External { get; set; }

        public string Note { get; set; }
        public SBMoney Amount { get; set; }
        public SBMoney Tip { get; set; }
        public SBMoney ApplicationFee { get; set; }
        public SBMoney ProcessingFee { get; set; }
        public SBMoney Total { get; set; }
        public SBMoney Approuved { get; set; }
        public SBMoney Refunded { get; set; }
        public SBReceiptPaymentStatus Status { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptUrl { get; set; }
        public SBReceiptPaymentRiskEvaluation RiskEvaluation { get; set; }
        public List<SBReceiptPaymentRefund> Refunds { get; set; } = new List<SBReceiptPaymentRefund>();

    }
}
