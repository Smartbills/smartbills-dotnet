using Newtonsoft.Json;
using System;

namespace Smartbills.NET.Entities.Wallet
{
    public record SBWalletTransaction
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
        [JsonProperty("total")]

        public decimal Total { get; set; }
        //[JsonProperty("type")]
        //public SBWalletTransactionType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
