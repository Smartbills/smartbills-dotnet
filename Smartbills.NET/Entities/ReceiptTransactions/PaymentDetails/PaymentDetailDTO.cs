using Smartbills.NET.Entities.ReceiptTransactions.CreditCards;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptTransactions.PaymentDetails
{
    public record PaymentDetailDTO
    {
        [JsonPropertyName("avs_result_code")]
        public string AvsResultCode { get; set; }
        [JsonPropertyName("credit_card")]
        public CreditCardDTO CreditCard { get; set; }
        [JsonPropertyName("cvv_result_code")]
        public string CvvResultCode { get; set; }
    }
}
