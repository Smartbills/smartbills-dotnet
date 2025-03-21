using System;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptBankTransaction : SBEntity
    {
        public decimal Amount { get; set; }
        public List<string> Categories { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public string PaymentChannel { get; set; }

    }
}
