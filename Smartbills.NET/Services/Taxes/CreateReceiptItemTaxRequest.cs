using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record CreateReceiptItemTaxRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
