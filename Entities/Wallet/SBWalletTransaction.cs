using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Smartbills.Client.Entities.Wallet
{
    public class SBWalletTransaction
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
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
        public string Url{ get; set; }
    }
}
