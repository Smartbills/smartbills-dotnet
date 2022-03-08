using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Services.Banks
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
