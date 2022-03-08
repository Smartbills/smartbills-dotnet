using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities.Taxes
{
    public class SBReceiptTax
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        [JsonPropertyName("total")]
        public decimal Total { get; set; }

        [JsonPropertyName("tin")]
        public string TIN { get; set; }
    }
}
