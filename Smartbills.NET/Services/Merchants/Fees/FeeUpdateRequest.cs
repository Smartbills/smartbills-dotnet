﻿using System.Collections.Generic;

namespace Smartbills.NET.Services.Merchants.Fees
{
    public record FeeUpdateRequest
    {
        public Dictionary<string, string> Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public string Type { get; set; }
    }
}
