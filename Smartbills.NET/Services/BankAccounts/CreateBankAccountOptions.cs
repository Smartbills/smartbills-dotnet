using Smartbills.Services.BankBalances;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public class CreateBankAccountRequest : BaseRequest
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("mask")]
        public string Mask { get; set; }
        [JsonPropertyName("official_name")]
        public string OfficialName { get; set; }
        [JsonPropertyName("balance")]
        public CreateBankBalanceRequest Balance { get; set; }

    }
}