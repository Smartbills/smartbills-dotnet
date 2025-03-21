using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptListRequest : ListRequest
    {
        public long? MerchantId { get; set; }
        public long? CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public decimal? MinTotal { get; set; }
        public decimal? MaxTotal { get; set; }
        public string Currency { get; set; }
        public bool? HasBankTransaction { get; set; } = null;

        public List<long> CustomerIds { get; set; } = new List<long>();

        public List<long> LocationIds { get; set; } = new List<long>();

        public List<long> PromoCodeIds { get; set; } = new List<long>();

    }
}