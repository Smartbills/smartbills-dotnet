using System.Text.Json.Serialization;
using Smartbills.Client.Entities.Transactions.CreditCards;

namespace Smartbills.Client.Entities.Transactions.PaymentDetails
{
    public class CreatePaymentDetailDTO
    {
        [JsonPropertyName("avs_result_code")]
        public string AvsResultCode { get; set; }
        [JsonPropertyName("credit_card")]
        public CreateCreditCardDTO CreditCard { get; set; }
        [JsonPropertyName("cvv_result_code")]
        public string CvvResultCode { get; set; }
    }
}
