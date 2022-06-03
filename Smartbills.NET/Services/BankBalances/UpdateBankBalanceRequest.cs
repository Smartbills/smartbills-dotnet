using Smartbills.NET.Services;
using System.Text.Json.Serialization;

namespace Smartbills.Services.BankBalances
{
    public class UpdateBankBalanceRequest : BaseRequest
    {
        [JsonPropertyName("current")]
        public decimal Current { get; set; }
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
        [JsonPropertyName("limit")]
        public decimal Limit { get; set; }
        [JsonPropertyName("available")]
        public decimal Available { get; set; }
    }
}
