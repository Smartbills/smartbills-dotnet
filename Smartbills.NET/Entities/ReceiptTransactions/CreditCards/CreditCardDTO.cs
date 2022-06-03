

using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Transactions.CreditCards
{
    public class CreditCardDTO
    {
        [JsonPropertyName("bin")]
        public string Bin { get; set; }
        [JsonPropertyName("last_4")]
        public string Last4 { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
