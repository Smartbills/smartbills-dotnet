using System.Text.Json.Serialization;
using Smartbills.Client.Entities.Transactions.CreditCards;

namespace Smartbills.Client.Entities.Transactions.PaymentDetails
{
    public class PaymentDetailDTO
    {
        [JsonPropertyName("avs_result_code")]
        public string AvsResultCode { get; set; }
        [JsonPropertyName("credit_card")]
        public CreditCardDTO CreditCard { get; set; }
        [JsonPropertyName("cvv_result_code")]
        public string CvvResultCode { get; set; }
    }
}
