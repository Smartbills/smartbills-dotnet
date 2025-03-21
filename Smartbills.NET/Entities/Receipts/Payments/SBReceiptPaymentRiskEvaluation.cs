
using Smartbills.NET.Entities.Receipts.Payments;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public record ReceiptPaymentRiskEvaluation
    {
        public SBReceiptPaymentRiskLevel? RiskLevel { get; set; }
        public int RiskScore { get; set; }
    }
}