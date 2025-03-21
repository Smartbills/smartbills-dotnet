using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts.Payments
{
    public enum SBReceiptPaymentCardCvvResult
    {
        [JsonPropertyName("M")]
        CVVMatched,
        [JsonPropertyName("N")]
        CVVNotMatched,
        [JsonPropertyName("P")]
        CVVNotChecked
    }
}
