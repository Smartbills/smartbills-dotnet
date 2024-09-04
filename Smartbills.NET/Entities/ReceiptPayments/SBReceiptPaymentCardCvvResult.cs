using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.ReceiptPayments
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
