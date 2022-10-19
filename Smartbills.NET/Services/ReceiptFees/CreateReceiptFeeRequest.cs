using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ReceiptFees
{
    public class CreateReceiptFeeRequest
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
