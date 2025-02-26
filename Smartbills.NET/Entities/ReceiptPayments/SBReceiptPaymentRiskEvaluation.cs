
namespace Smartbills.NET.Entities.ReceiptPayments
{
    public record SBReceiptPaymentRiskEvaluation
    {
        public SBReceiptPaymentRiskLevel? RiskLevel { get; set; }
        public int RiskScore { get; set; }
    }
}