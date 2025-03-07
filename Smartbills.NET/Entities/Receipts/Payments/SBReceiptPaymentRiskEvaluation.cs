
using Smartbills.NET.Entities.ReceiptPayments;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record ReceiptPaymentRiskEvaluation
    {
        public SBReceiptPaymentRiskLevel? RiskLevel { get; set; }
        public int RiskScore { get; set; }
    }
}