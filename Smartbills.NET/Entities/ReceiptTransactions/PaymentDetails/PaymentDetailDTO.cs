﻿using Smartbills.NET.Entities.Transactions.CreditCards;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Transactions.PaymentDetails
{
    public class PaymentDetailDTO
    {
        [JsonPropertyName("avs_result_code")]
        public string AvsResultCode { get; set; }
        [JsonPropertyName("credit_card")]
        public CreditCardDTO CreditCard { get; set; }
        [JsonPropertyName("cvv_result_code")]
        public string CvvResultCode { get; set; }
    }
}