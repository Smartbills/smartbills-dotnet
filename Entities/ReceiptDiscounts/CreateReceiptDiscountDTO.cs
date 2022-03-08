using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Smartbills.Client.Entities.Taxes;

namespace Smartbills.Client.Entities.ReceiptDiscounts
{
    public class CreateReceiptDiscountDTO
    {

        [JsonPropertyName("code")]	
        public string Code { get; set; }
        [JsonPropertyName("amount")]	

        public string Amount { get; set; }

        [JsonPropertyName("type")]	
        public string Type { get; set; }
    }
}
