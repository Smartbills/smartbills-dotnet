using System;
using System.Text.Json.Serialization;
using Smartbills;
using Smartbills.Client.Entities;
using Smartbills.Services.Banks;

namespace Smartbills.Client.Services
{
    public class UpdateBankAccountRequest : BaseRequest
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
        public UpdateBankBalanceRequest Balance { get; set; }
    }
}