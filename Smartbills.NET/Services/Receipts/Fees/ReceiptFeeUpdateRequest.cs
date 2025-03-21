﻿namespace Smartbills.NET.Services.Receipts.Fees
{
    public record ReceiptFeeUpdateRequest
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public string Type { get; set; }
    }
}
