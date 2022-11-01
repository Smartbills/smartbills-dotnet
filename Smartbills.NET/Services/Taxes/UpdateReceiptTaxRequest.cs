﻿using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record UpdateReceiptTaxRequest:BaseRequest
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
