using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptTransactions.CreditCards
{
    public class CreateCreditCardDTO
    {

        public string Bin { get; set; }
        [JsonPropertyName("last_4")]
        public string Last4 { get; set; }
        [JsonPropertyName("company")]
        public string Company { get; set; }
    }
}
