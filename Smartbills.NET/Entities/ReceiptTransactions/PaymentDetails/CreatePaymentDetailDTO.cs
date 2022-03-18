using Smartbills.Client.Entities.Transactions.CreditCards;
using System.Text.Json.Serialization;

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
