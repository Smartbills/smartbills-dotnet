﻿using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Banks.BankBalances
{
    public record BankBalanceUpdateRequest : BaseRequest
    {

        public decimal Current { get; set; }

        public string CurrencyCode { get; set; }

        public decimal Limit { get; set; }

        public decimal Available { get; set; }
    }
}
