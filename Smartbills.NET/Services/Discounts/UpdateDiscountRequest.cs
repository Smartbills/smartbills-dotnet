using Smartbills.NET.Entities.Discount;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Discounts
{
    public record UpdateDiscountRequest: BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        [JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }

        [JsonPropertyName("total")]
        public decimal Total { get; set; }

        [JsonPropertyName("type")]
        public SBDiscountType Type { get; set; }

        [JsonPropertyName("maximum_discount")]
        public decimal? MaximumDiscount { get; set; }
    }
}
