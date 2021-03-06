using System;
using System.Text.Json.Serialization;
using Smartbills;
using Smartbills.Client.Entities;
using Smartbills.Services.BankBalances;

namespace Smartbills.Client.Services
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
        public  CreateBankBalanceRequest Balance { get; set; }

    }
}